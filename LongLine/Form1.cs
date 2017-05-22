using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LongLine
{
    public partial class Form1 : Form
    {
        private float fl, fh, f0, fn, C1, C2, L, R, R0, Rn, Am0, Amn,
            dt, Time, dE0, dEn, mismatch, MinX, MaxX, MinY, MaxY, w;
        //Complex Rw;
        private int Nc, Nd, Nt, FFTArraySize;
        const double pi = 3.14159265, twoPi = 6.28318530718;
        float[] V, U, dV, dU, TmprFFTin, TmprFFTout, FFTArray, TimeToSave;
        TextAnnotation annotationTime = new TextAnnotation();

        private void buttonStart_Click(object sender, EventArgs e)
        {
            fl = float.Parse(textBoxfl.Text);
            fh = float.Parse(textBoxfh.Text);
            f0 = float.Parse(textBoxf0.Text);
            fn = float.Parse(textBoxfn.Text);
            C1 = float.Parse(textBoxC1.Text);
            R = float.Parse(textBoxR.Text);
            Am0 = float.Parse(textBoxAm0.Text);
            Amn = float.Parse(textBoxAmn.Text);
            Time = float.Parse(textBoxTime.Text);
            Nc = Int32.Parse(textBoxNc.Text);
            Nd = Int32.Parse(textBoxNd.Text);
            mismatch = float.Parse(textBoxMismatch.Text);

            C2 = (float)(C1 / 2 * ((Math.Pow(fh, 2) / Math.Pow(fl, 2)) - 1));
            L = (float)(1 / (Math.Pow(2 * pi * fl, 2) * C2));

            //характеристическое сопротивление
            w = (float)(2 * pi * f0);
            Complex Z1 = 2 / ((-1) * w * C1), Z2 = 1 / ((-1) * w * C2), Z3 = (-1) * w * L, Rw;
            Rw = Complex.Sqrt((Complex.Pow(Z1, 2) * (Z2 + Z3)) / (2 * Z1 + Z2 + Z3));

            //метод Эйлера
            //блок-схема с помощью сторонней программы (Crystal - Rev C/C++)

            Rn = R0 = (float)Rw.Real * mismatch;
            dt = 1 / (fh * Nd);

            V = new float[Nc + 1];
            dV = new float[Nc + 1];
            U = new float[Nc];
            dU = new float[Nc];
            
            for (int i = 0; i < Nc; i++) V[i] = dV[i] = U[i] = dU[i] = 0.0F;
            V[Nc] = dV[Nc] = 0.0F;

            dt = 1.0F / fh / Nd; //f0
            Nt = (int)(Time / dt);

            TmprFFTin = new float[Nt];
            TmprFFTout = new float[Nt];

            if (comboBoxChart.SelectedIndex == 4)
            {
                FFTArraySize = (int)(Math.Pow(2.0F, Math.Truncate(Math.Log(TmprFFTin.Length) / Math.Log(2))));
                FFTArray = new float[FFTArraySize];
            }
            else if (comboBoxChart.SelectedIndex == 5)
            {
                FFTArraySize = (int)(Math.Pow(2.0F, Math.Truncate(Math.Log(TmprFFTout.Length) / Math.Log(2))));
                FFTArray = new float[FFTArraySize];
            }

            if (checkBoxAutosave.Checked && checkBoxAutosave.Enabled && textBoxAutosave.Text != "")
            {
                string[] TemporaryTimeToSave = textBoxAutosave.Text.Split(';');

                TimeToSave = new float[TemporaryTimeToSave.Length];

                for (int i = 0; i < TemporaryTimeToSave.Length; i++)
                    TimeToSave[i] = float.Parse(TemporaryTimeToSave[i]);
            }

            chart1.Series["V"].Points.Clear();
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "F2";
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "F3";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Voltage";
            chart1.Series["V"].ChartType = SeriesChartType.Spline;
            
            if (!checkBoxAxisXAutocorrection.Checked)
            {
                MinX = float.Parse(textBoxAxisXCorrectionMin.Text);
                MaxX = float.Parse(textBoxAxisXCorrectionMax.Text);
                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = MinX;
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = MaxX;
            }
            else
            {
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = chart1.ChartAreas["ChartArea2"].AxisX.Maximum;
                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = chart1.ChartAreas["ChartArea2"].AxisX.Minimum;
            }

            if (!checkBoxAxisYAutocorrection.Checked)
            {
                MinY = float.Parse(textBoxAxisYCorrectionMin.Text);
                MaxY = float.Parse(textBoxAxisYCorrectionMax.Text);
                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = MinY;
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = MaxY;
            }
            else
            {
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = chart1.ChartAreas["ChartArea2"].AxisY.Maximum;
                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = chart1.ChartAreas["ChartArea2"].AxisY.Minimum;
            }

            if (radioButtonCells.Enabled && radioButtonCells.Checked) { chart1.ChartAreas["ChartArea1"].AxisX.Title = "Cells"; annotationTime.Visible = true; }
            else annotationTime.Visible = false;

            if (radioButtonTime.Enabled && radioButtonTime.Checked) chart1.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            
            for (int it = 0; it < Nt; it++) //для каждой ячейки
            {
                float time = it * dt;

                if (checkBoxSin.Checked && checkBoxPulse.Checked)
                {
                    dE0 = (float)(Am0 * 2 * pi * f0 * Math.Sin(2 * pi * f0 * time) - Am0 * dPulse(time));
                    dEn = (float)(Amn * 2 * pi * fn * Math.Sin(2 * pi * fn * time) - Amn);
                }
                else if (checkBoxSin.Checked)
                {
                    dE0 = (float)(Am0 * 2 * pi * f0 * Math.Sin(2 * pi * f0 * time));
                    dEn = (float)(Amn * 2 * pi * fn * Math.Sin(2 * pi * fn * time));
                }
                else if (checkBoxPulse.Checked)
                {
                    dE0 = (float)(-Am0 * dPulse(time));
                    dEn = (float)(-Amn);
                }
                else break;

                dV[0] += 2.0F / (R0 * C1) * (dE0 - dV[0]) * dt + 2.0F / (L * C1) * (V[1] - V[0] + U[0]) * dt;
                dV[Nc] += 2.0F / (L * C1) * (V[Nc - 1] - V[Nc] - U[Nc - 1]) * dt - 2.0F / (Rn * C1) * (dV[Nc] - dEn) * dt;

                for (int i = 0; i < Nc; i++)
                {
                    dU[i] += 1.0F / (L * C2) * (V[i] - V[i + 1] - U[i]) * dt - 1.0F / (R * C2) * dU[i] * dt;
                    if (i == 0) continue;
                    dV[i] += 1.0F / (L * C1) * (V[i - 1] - 2 * V[i] + V[i + 1] + U[i] - U[i - 1]) * dt;
                } //цикл по i

                if (radioButtonCells.Enabled && radioButtonCells.Checked) chart1.Series["V"].Points.Clear();

                for (int i = 0; i < Nc; i++)
                {
                    V[i] += dV[i] * dt;
                    U[i] += dU[i] * dt;

                    if (radioButtonCells.Enabled && radioButtonCells.Checked)
                        switch (comboBoxChart.SelectedIndex)
                        {
                            case 0: { chart1.Series["V"].Points.AddXY(i, V[i]); break; } //на С1
                            case 2: { chart1.Series["V"].Points.AddXY(i, U[i]); break; } //на С2
                        }
                    annotationTime.Text = "Current time: " + String.Format("{0:0.000}", (time + dt)) + " sec";
                } //цикл по i (ячейки)

                V[Nc] += dV[Nc] * dt;

                if (checkBoxPassing.Checked) chart1.Update();

                if (comboBoxChart.SelectedIndex == 0 || comboBoxChart.SelectedIndex == 2)
                    chart1.Series["V"].Color = Color.Blue;
                else if (comboBoxChart.SelectedIndex == 1 || comboBoxChart.SelectedIndex == 3)
                    chart1.Series["V"].Color = Color.Red;
                else chart1.Series["V"].Color = Color.Green;
                
                if ((it % 1) == 0)
                {
                    if ((radioButtonTime.Enabled && radioButtonTime.Checked) || !radioButtonTime.Enabled)
                    {
                        switch (comboBoxChart.SelectedIndex)
                        {
                            case 0: { chart1.Series["V"].Points.AddXY(time, V[0]); break; }
                            case 1: { chart1.Series["V"].Points.AddXY(time, V[Nc]); break; }
                            case 2: { chart1.Series["V"].Points.AddXY(time, U[0]); break; }
                            case 3: { chart1.Series["V"].Points.AddXY(time, U[Nc - 1]); break; }
                            case 4: { TmprFFTin[it] = V[0]; break; }
                            case 5: { TmprFFTout[it] = V[Nc]; break; }
                        }
                    }
                }//цикл по time (время)

                if (textBoxAutosave.Enabled && textBoxAutosave.Text != "")
                    for (int i = 0; i < TimeToSave.Length; i++)
                        if ((TimeToSave[i] < (time + 2 * dt)) && (TimeToSave[i] > (time)))
                            chart1.SaveImage("C:\\Users\\Maxim\\Desktop\\"+ comboBoxChart.Text + "Time" + (TimeToSave[i]) + ".png", ChartImageFormat.Png);
            }
            if (comboBoxChart.SelectedIndex == 4 || comboBoxChart.SelectedIndex == 5)
                if (checkBoxPulse.Checked || checkBoxSin.Checked)
                {
                    FFTAnalysis();

                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Harmonics";
                    
                    for (int i = 0; i < FFTArraySize/2; i++) //по гармоникам
                        chart1.Series["V"].Points.AddXY(i * (1 / (FFTArraySize * dt)), FFTArray[i]);
                }
            if (checkBoxSaveFinal.Checked) chart1.SaveImage("C:\\Users\\Maxim\\Desktop\\" + comboBoxChart.Text + "Final(Time" + Time + ").png", ChartImageFormat.Png);
        }

        private float Pulse(float T)
        {
            float Start = 0, Stop = 3, fwFront = 1, bwFront = 1;
            float ret = (T >= Start && T <= Stop) ? 1 : 0;
            if (T >= Start && T <= (Start + fwFront))
                if (fwFront > 0.0)
                    ret *= (float)(0.5 * (1.0 - Math.Cos(pi * (T - Start) * fwFront)));
            if (T >= (Stop - bwFront) && T <= Stop)
                if (bwFront > 0.0)
                    ret *= (float)(0.5 * (1.0 - Math.Cos(pi * (Stop - T) * bwFront)));
            return ret;
        }

        private float dPulse(float T)
        {
            float Start = 0, Stop = 3, fwFront = 1, bwFront = 1;
            float ret = 0;
            if ((T >= Start) && (T <= (Start + fwFront)))
                if (fwFront > 0.0)
                    ret = (float)(-0.5 * Math.Sin(pi * (T - Start) / fwFront) * pi / fwFront);
            if ((T >= (Stop - bwFront)) && (T <= Stop))
                if (bwFront > 0.0)
                    ret = (float)(0.5 * Math.Sin(pi * (Stop - T) / bwFront) * pi / bwFront);
            return ret;
        }

        private void FFTAnalysis()
        {
            int i, j, n, m, Mmax, Istp;
            float Tmpr, Tmpi, Wtmp, Theta;
            float Wpr, Wpi, Wr, Wi;
            float[] Tmvl;

            n = FFTArraySize * 2;

            Tmvl = new float[n];

            if (comboBoxChart.SelectedIndex == 4)
                for (i = 0; i < n; i += 2)
                {
                    Tmvl[i] = 0;
                    Tmvl[i + 1] = TmprFFTin[i / 2];
                }
            else if (comboBoxChart.SelectedIndex == 5)
                for (i = 0; i < n; i += 2)
                {
                    Tmvl[i] = 0;
                    Tmvl[i + 1] = TmprFFTout[i / 2];
                };

            i = 1; j = 1;
            while (i < n)
            {
                if (j > i)
                {
                    Tmpr = Tmvl[i]; Tmvl[i] = Tmvl[j]; Tmvl[j] = Tmpr;
                    Tmpr = Tmvl[i + 1]; Tmvl[i + 1] = Tmvl[j + 1]; Tmvl[j + 1] = Tmpr;
                }
                i = i + 2; m = FFTArraySize;

                while ((m >= 2) && (j > m)) { j = j - m; m = m >> 1; }

                j = j + m;
            }

            Mmax = 2;
            while (n > Mmax)
            {
                Theta = (float)(-twoPi / Mmax); Wpi = (float)(Math.Sin(Theta));
                Wtmp = (float)(Math.Sin(Theta / 2)); Wpr = Wtmp * Wtmp * 2;
                Istp = Mmax * 2; Wr = 1; Wi = 0; m = 1;

                while (m < Mmax)
                {
                    i = m; m = m + 2; Tmpr = Wr; Tmpi = Wi;
                    Wr = Wr - Tmpr * Wpr - Tmpi * Wpi;
                    Wi = Wi + Tmpr * Wpi - Tmpi * Wpr;

                    while (i < n)
                    {
                        j = i + Mmax;
                        Tmpr = Wr * Tmvl[j] - Wi * Tmvl[j - 1];
                        Tmpi = Wi * Tmvl[j] + Wr * Tmvl[j - 1];

                        Tmvl[j] = Tmvl[i] - Tmpr; Tmvl[j - 1] = Tmvl[i - 1] - Tmpi;
                        Tmvl[i] = Tmvl[i] + Tmpr; Tmvl[i - 1] = Tmvl[i - 1] + Tmpi;
                        i = i + Istp;
                    }
                }
                Mmax = Istp;
            }
            for (i = 0; i < FFTArraySize; i++)
            {
                j = i * 2;
                FFTArray[i] = (float)(2 * Math.Sqrt(Math.Pow(Tmvl[j], 2) + Math.Pow(Tmvl[j + 1], 2)) / FFTArraySize);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxfl.Text += 1;
            this.textBoxfh.Text += 10;
            this.textBoxf0.Text += 5;
            this.textBoxfn.Text += 0;
            this.textBoxC1.Text += 0.01F;
            this.textBoxR.Text += 0.01F;
            this.textBoxAm0.Text += 1;
            this.textBoxAmn.Text += 0;
            this.textBoxTime.Text += 3;
            this.textBoxNc.Text += 5;
            this.textBoxNd.Text += 20;
            this.textBoxMismatch.Text += 1;

            textBoxAxisXCorrectionMin.Text = Convert.ToString(0);
            textBoxAxisXCorrectionMax.Text = Convert.ToString(1);
            textBoxAxisYCorrectionMin.Text = Convert.ToString(0);
            textBoxAxisYCorrectionMax.Text = Convert.ToString(1);

            checkBoxSin.Checked = true;
            textBoxAutosave.Enabled = false;
            radioButtonTime.Checked = true;
            textBoxAxisXCorrectionMin.Enabled = false;
            textBoxAxisXCorrectionMax.Enabled = false;
            textBoxAxisYCorrectionMin.Enabled = false;
            textBoxAxisYCorrectionMax.Enabled = false;
            checkBoxAxisXAutocorrection.Checked = true;
            checkBoxAxisYAutocorrection.Checked = true;
            comboBoxChart.SelectedIndex = 0;

            annotationTime.Visible = false;
            annotationTime.Name = "annotationTime";
            annotationTime.X = 64;
            annotationTime.Y = 0;
            annotationTime.Font = new Font("Arial", 10);
            chart1.Annotations.Add(annotationTime);
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            chart1.Series["V"].Points.Clear();
            textBoxfh.Text = Convert.ToString(10); //fh
            textBoxf0.Text = Convert.ToString(5); ; //f0
            textBoxfn.Text = Convert.ToString(0); ; //fn
            textBoxC1.Text = Convert.ToString(0.01F); //C1
            textBoxR.Text = Convert.ToString(0.01F); //R
            textBoxAm0.Text = Convert.ToString(1); //Am0
            textBoxAmn.Text = Convert.ToString(0); //Amn
            textBoxTime.Text = Convert.ToString(3); //Time
            textBoxfl.Text = Convert.ToString(1); //fl
            textBoxNc.Text = Convert.ToString(5); //Nc
            textBoxNd.Text = Convert.ToString(20); //Nd
            textBoxMismatch.Text = Convert.ToString(1); //k
            textBoxAxisXCorrectionMin.Text = Convert.ToString(0);
            textBoxAxisXCorrectionMax.Text = Convert.ToString(1);
            textBoxAxisYCorrectionMin.Text = Convert.ToString(0);
            textBoxAxisYCorrectionMax.Text = Convert.ToString(1);
            comboBoxChart.SelectedIndex = 0;

            radioButtonTime.Select();

            checkBoxPassing.Checked = false;
            checkBoxSin.Checked = true;
            checkBoxPulse.Checked = false;
            checkBoxAutosave.Checked = false;
            checkBoxAxisXAutocorrection.Checked = true;
            checkBoxAxisYAutocorrection.Checked = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonTime_CheckedChanged(object sender, EventArgs e) {}

        private void radioButtonCells_CheckedChanged(object sender, EventArgs e) {}

        private void checkBoxAxisYAutocorrection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAxisYAutocorrection.Checked) { textBoxAxisYCorrectionMin.Enabled = false; textBoxAxisYCorrectionMax.Enabled = false; }
            else { textBoxAxisYCorrectionMin.Enabled = true; textBoxAxisYCorrectionMax.Enabled = true; }
        }

        private void checkBoxAxisXAutocorrection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAxisXAutocorrection.Checked) { textBoxAxisXCorrectionMin.Enabled = false; textBoxAxisXCorrectionMax.Enabled = false; }
            else { textBoxAxisXCorrectionMin.Enabled = true; textBoxAxisXCorrectionMax.Enabled = true; }
        }

        private void checkBoxAutosave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutosave.Checked) textBoxAutosave.Enabled = true;
            else textBoxAutosave.Enabled = false;
        }

        private void comboBoxChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChart.SelectedIndex)
            {
                case 1:
                case 3: {
                        checkBoxPassing.Enabled = true;
                        checkBoxAutosave.Enabled = true;// textBoxAutosave.Enabled = true;
                        radioButtonCells.Enabled = false;
                        radioButtonTime.Enabled = true; radioButtonTime.Checked = true;
                        radioButtonHarmonics.Enabled = false; radioButtonHarmonics.Checked = false; break;
                    }
                case 4:
                case 5: {
                        checkBoxPassing.Checked = false; checkBoxPassing.Enabled = false;
                        textBoxAutosave.Text = null;
                        checkBoxAutosave.Checked = false; checkBoxAutosave.Enabled = false;
                        radioButtonCells.Enabled = false;
                        radioButtonTime.Enabled = false;
                        radioButtonHarmonics.Enabled = true; radioButtonHarmonics.Checked = true; break;
                    }
                default: {
                        checkBoxPassing.Enabled = true;
                        checkBoxAutosave.Enabled = true;
                        radioButtonCells.Enabled = true; 
                        radioButtonTime.Enabled = true; radioButtonTime.Checked = true;
                        radioButtonHarmonics.Enabled = false; radioButtonHarmonics.Checked = false; break;
                    }
            }
        }
    }
}