namespace LongLine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfl = new System.Windows.Forms.TextBox();
            this.textBoxfh = new System.Windows.Forms.TextBox();
            this.textBoxf0 = new System.Windows.Forms.TextBox();
            this.textBoxfn = new System.Windows.Forms.TextBox();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxAm0 = new System.Windows.Forms.TextBox();
            this.textBoxAmn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNc = new System.Windows.Forms.TextBox();
            this.textBoxNd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxSin = new System.Windows.Forms.CheckBox();
            this.checkBoxPulse = new System.Windows.Forms.CheckBox();
            this.radioButtonTime = new System.Windows.Forms.RadioButton();
            this.radioButtonCells = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxPassing = new System.Windows.Forms.CheckBox();
            this.checkBoxAutosave = new System.Windows.Forms.CheckBox();
            this.textBoxAutosave = new System.Windows.Forms.TextBox();
            this.comboBoxChart = new System.Windows.Forms.ComboBox();
            this.radioButtonHarmonics = new System.Windows.Forms.RadioButton();
            this.textBoxMismatch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxSaveFinal = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxAxisXCorrectionMax = new System.Windows.Forms.TextBox();
            this.textBoxAxisXCorrectionMin = new System.Windows.Forms.TextBox();
            this.textBoxAxisYCorrectionMin = new System.Windows.Forms.TextBox();
            this.textBoxAxisYCorrectionMax = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBoxAxisXAutocorrection = new System.Windows.Forms.CheckBox();
            this.checkBoxAxisYAutocorrection = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea2.Visible = false;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "V";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(516, 329);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Properties:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "fl:";
            // 
            // textBoxfl
            // 
            this.textBoxfl.Location = new System.Drawing.Point(582, 35);
            this.textBoxfl.Name = "textBoxfl";
            this.textBoxfl.Size = new System.Drawing.Size(100, 20);
            this.textBoxfl.TabIndex = 4;
            // 
            // textBoxfh
            // 
            this.textBoxfh.Location = new System.Drawing.Point(582, 61);
            this.textBoxfh.Name = "textBoxfh";
            this.textBoxfh.Size = new System.Drawing.Size(100, 20);
            this.textBoxfh.TabIndex = 5;
            // 
            // textBoxf0
            // 
            this.textBoxf0.Location = new System.Drawing.Point(582, 87);
            this.textBoxf0.Name = "textBoxf0";
            this.textBoxf0.Size = new System.Drawing.Size(100, 20);
            this.textBoxf0.TabIndex = 6;
            // 
            // textBoxfn
            // 
            this.textBoxfn.Location = new System.Drawing.Point(582, 113);
            this.textBoxfn.Name = "textBoxfn";
            this.textBoxfn.Size = new System.Drawing.Size(100, 20);
            this.textBoxfn.TabIndex = 7;
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(582, 139);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(100, 20);
            this.textBoxC1.TabIndex = 8;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(582, 165);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 9;
            // 
            // textBoxAm0
            // 
            this.textBoxAm0.Location = new System.Drawing.Point(582, 191);
            this.textBoxAm0.Name = "textBoxAm0";
            this.textBoxAm0.Size = new System.Drawing.Size(100, 20);
            this.textBoxAm0.TabIndex = 10;
            // 
            // textBoxAmn
            // 
            this.textBoxAmn.Location = new System.Drawing.Point(582, 217);
            this.textBoxAmn.Name = "textBoxAmn";
            this.textBoxAmn.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "fh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "f0:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "fn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "C1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "R:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Am0:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Amn:";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(582, 243);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Time:";
            // 
            // textBoxNc
            // 
            this.textBoxNc.Location = new System.Drawing.Point(582, 269);
            this.textBoxNc.Name = "textBoxNc";
            this.textBoxNc.Size = new System.Drawing.Size(100, 20);
            this.textBoxNc.TabIndex = 21;
            // 
            // textBoxNd
            // 
            this.textBoxNd.Location = new System.Drawing.Point(582, 295);
            this.textBoxNd.Name = "textBoxNd";
            this.textBoxNd.Size = new System.Drawing.Size(100, 20);
            this.textBoxNd.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(546, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Nd:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(549, 428);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 23);
            this.buttonStart.TabIndex = 26;
            this.buttonStart.Text = "Draw";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(549, 486);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 23);
            this.buttonClose.TabIndex = 28;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(237, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Choose configuration and type of characteristics:";
            // 
            // checkBoxSin
            // 
            this.checkBoxSin.AutoSize = true;
            this.checkBoxSin.Location = new System.Drawing.Point(189, 438);
            this.checkBoxSin.Name = "checkBoxSin";
            this.checkBoxSin.Size = new System.Drawing.Size(41, 17);
            this.checkBoxSin.TabIndex = 30;
            this.checkBoxSin.Text = "Sin";
            this.checkBoxSin.UseVisualStyleBackColor = true;
            // 
            // checkBoxPulse
            // 
            this.checkBoxPulse.AutoSize = true;
            this.checkBoxPulse.Location = new System.Drawing.Point(189, 460);
            this.checkBoxPulse.Name = "checkBoxPulse";
            this.checkBoxPulse.Size = new System.Drawing.Size(52, 17);
            this.checkBoxPulse.TabIndex = 31;
            this.checkBoxPulse.Text = "Pulse";
            this.checkBoxPulse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.AutoSize = true;
            this.radioButtonTime.Location = new System.Drawing.Point(50, 437);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(48, 17);
            this.radioButtonTime.TabIndex = 33;
            this.radioButtonTime.TabStop = true;
            this.radioButtonTime.Text = "Time";
            this.radioButtonTime.UseVisualStyleBackColor = true;
            this.radioButtonTime.CheckedChanged += new System.EventHandler(this.radioButtonTime_CheckedChanged);
            // 
            // radioButtonCells
            // 
            this.radioButtonCells.AutoSize = true;
            this.radioButtonCells.Location = new System.Drawing.Point(50, 459);
            this.radioButtonCells.Name = "radioButtonCells";
            this.radioButtonCells.Size = new System.Drawing.Size(47, 17);
            this.radioButtonCells.TabIndex = 34;
            this.radioButtonCells.TabStop = true;
            this.radioButtonCells.Text = "Cells";
            this.radioButtonCells.UseVisualStyleBackColor = true;
            this.radioButtonCells.CheckedChanged += new System.EventHandler(this.radioButtonCells_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "X-axis:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(144, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Signal:";
            // 
            // checkBoxPassing
            // 
            this.checkBoxPassing.AutoSize = true;
            this.checkBoxPassing.Location = new System.Drawing.Point(50, 405);
            this.checkBoxPassing.Name = "checkBoxPassing";
            this.checkBoxPassing.Size = new System.Drawing.Size(155, 17);
            this.checkBoxPassing.TabIndex = 37;
            this.checkBoxPassing.Text = "Pass signal through the line";
            this.checkBoxPassing.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutosave
            // 
            this.checkBoxAutosave.AutoSize = true;
            this.checkBoxAutosave.Location = new System.Drawing.Point(534, 379);
            this.checkBoxAutosave.Name = "checkBoxAutosave";
            this.checkBoxAutosave.Size = new System.Drawing.Size(160, 17);
            this.checkBoxAutosave.TabIndex = 38;
            this.checkBoxAutosave.Text = "Save chart at sec(s) (#,#;#):";
            this.checkBoxAutosave.UseVisualStyleBackColor = true;
            this.checkBoxAutosave.CheckedChanged += new System.EventHandler(this.checkBoxAutosave_CheckedChanged);
            // 
            // textBoxAutosave
            // 
            this.textBoxAutosave.Location = new System.Drawing.Point(534, 402);
            this.textBoxAutosave.Name = "textBoxAutosave";
            this.textBoxAutosave.Size = new System.Drawing.Size(148, 20);
            this.textBoxAutosave.TabIndex = 39;
            // 
            // comboBoxChart
            // 
            this.comboBoxChart.FormattingEnabled = true;
            this.comboBoxChart.Items.AddRange(new object[] {
            "Vin",
            "Vout",
            "Uin",
            "Uout",
            "FFTin(V)",
            "FFTout(V)"});
            this.comboBoxChart.Location = new System.Drawing.Point(14, 378);
            this.comboBoxChart.Name = "comboBoxChart";
            this.comboBoxChart.Size = new System.Drawing.Size(234, 21);
            this.comboBoxChart.TabIndex = 40;
            this.comboBoxChart.SelectedIndexChanged += new System.EventHandler(this.comboBoxChart_SelectedIndexChanged);
            // 
            // radioButtonHarmonics
            // 
            this.radioButtonHarmonics.AutoSize = true;
            this.radioButtonHarmonics.Location = new System.Drawing.Point(50, 482);
            this.radioButtonHarmonics.Name = "radioButtonHarmonics";
            this.radioButtonHarmonics.Size = new System.Drawing.Size(75, 17);
            this.radioButtonHarmonics.TabIndex = 41;
            this.radioButtonHarmonics.TabStop = true;
            this.radioButtonHarmonics.Text = "Harmonics";
            this.radioButtonHarmonics.UseVisualStyleBackColor = true;
            // 
            // textBoxMismatch
            // 
            this.textBoxMismatch.Location = new System.Drawing.Point(656, 321);
            this.textBoxMismatch.Name = "textBoxMismatch";
            this.textBoxMismatch.Size = new System.Drawing.Size(26, 20);
            this.textBoxMismatch.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(546, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "R0(n)/Rw mismatch:";
            // 
            // checkBoxSaveFinal
            // 
            this.checkBoxSaveFinal.AutoSize = true;
            this.checkBoxSaveFinal.Location = new System.Drawing.Point(534, 356);
            this.checkBoxSaveFinal.Name = "checkBoxSaveFinal";
            this.checkBoxSaveFinal.Size = new System.Drawing.Size(149, 17);
            this.checkBoxSaveFinal.TabIndex = 44;
            this.checkBoxSaveFinal.Text = "Save final version of chart";
            this.checkBoxSaveFinal.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(549, 457);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(133, 23);
            this.buttonClear.TabIndex = 45;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(273, 378);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Axis X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(273, 434);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Axis Y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(274, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Chart scale correction:";
            // 
            // textBoxAxisXCorrectionMax
            // 
            this.textBoxAxisXCorrectionMax.Location = new System.Drawing.Point(427, 402);
            this.textBoxAxisXCorrectionMax.Name = "textBoxAxisXCorrectionMax";
            this.textBoxAxisXCorrectionMax.Size = new System.Drawing.Size(86, 20);
            this.textBoxAxisXCorrectionMax.TabIndex = 49;
            // 
            // textBoxAxisXCorrectionMin
            // 
            this.textBoxAxisXCorrectionMin.Location = new System.Drawing.Point(427, 375);
            this.textBoxAxisXCorrectionMin.Name = "textBoxAxisXCorrectionMin";
            this.textBoxAxisXCorrectionMin.Size = new System.Drawing.Size(86, 20);
            this.textBoxAxisXCorrectionMin.TabIndex = 50;
            // 
            // textBoxAxisYCorrectionMin
            // 
            this.textBoxAxisYCorrectionMin.Location = new System.Drawing.Point(427, 432);
            this.textBoxAxisYCorrectionMin.Name = "textBoxAxisYCorrectionMin";
            this.textBoxAxisYCorrectionMin.Size = new System.Drawing.Size(86, 20);
            this.textBoxAxisYCorrectionMin.TabIndex = 51;
            // 
            // textBoxAxisYCorrectionMax
            // 
            this.textBoxAxisYCorrectionMax.Location = new System.Drawing.Point(427, 458);
            this.textBoxAxisYCorrectionMax.Name = "textBoxAxisYCorrectionMax";
            this.textBoxAxisYCorrectionMax.Size = new System.Drawing.Size(86, 20);
            this.textBoxAxisYCorrectionMax.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(391, 378);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Min:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(391, 434);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "Min:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(391, 405);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "Max:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(391, 461);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Max:";
            // 
            // checkBoxAxisXAutocorrection
            // 
            this.checkBoxAxisXAutocorrection.AutoSize = true;
            this.checkBoxAxisXAutocorrection.Location = new System.Drawing.Point(324, 377);
            this.checkBoxAxisXAutocorrection.Name = "checkBoxAxisXAutocorrection";
            this.checkBoxAxisXAutocorrection.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAxisXAutocorrection.TabIndex = 57;
            this.checkBoxAxisXAutocorrection.Text = "Auto";
            this.checkBoxAxisXAutocorrection.UseVisualStyleBackColor = true;
            this.checkBoxAxisXAutocorrection.CheckedChanged += new System.EventHandler(this.checkBoxAxisXAutocorrection_CheckedChanged);
            // 
            // checkBoxAxisYAutocorrection
            // 
            this.checkBoxAxisYAutocorrection.AutoSize = true;
            this.checkBoxAxisYAutocorrection.Location = new System.Drawing.Point(324, 433);
            this.checkBoxAxisYAutocorrection.Name = "checkBoxAxisYAutocorrection";
            this.checkBoxAxisYAutocorrection.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAxisYAutocorrection.TabIndex = 58;
            this.checkBoxAxisYAutocorrection.Text = "Auto";
            this.checkBoxAxisYAutocorrection.UseVisualStyleBackColor = true;
            this.checkBoxAxisYAutocorrection.CheckedChanged += new System.EventHandler(this.checkBoxAxisYAutocorrection_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 515);
            this.Controls.Add(this.checkBoxAxisYAutocorrection);
            this.Controls.Add(this.checkBoxAxisXAutocorrection);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxAxisYCorrectionMax);
            this.Controls.Add(this.textBoxAxisYCorrectionMin);
            this.Controls.Add(this.textBoxAxisXCorrectionMin);
            this.Controls.Add(this.textBoxAxisXCorrectionMax);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxSaveFinal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxMismatch);
            this.Controls.Add(this.radioButtonHarmonics);
            this.Controls.Add(this.comboBoxChart);
            this.Controls.Add(this.textBoxAutosave);
            this.Controls.Add(this.checkBoxAutosave);
            this.Controls.Add(this.checkBoxPassing);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButtonCells);
            this.Controls.Add(this.radioButtonTime);
            this.Controls.Add(this.checkBoxPulse);
            this.Controls.Add(this.checkBoxSin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNd);
            this.Controls.Add(this.textBoxNc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAmn);
            this.Controls.Add(this.textBoxAm0);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxC1);
            this.Controls.Add(this.textBoxfn);
            this.Controls.Add(this.textBoxf0);
            this.Controls.Add(this.textBoxfh);
            this.Controls.Add(this.textBoxfl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "LongLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfl;
        private System.Windows.Forms.TextBox textBoxfh;
        private System.Windows.Forms.TextBox textBoxf0;
        private System.Windows.Forms.TextBox textBoxfn;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxAm0;
        private System.Windows.Forms.TextBox textBoxAmn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNc;
        private System.Windows.Forms.TextBox textBoxNd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxSin;
        private System.Windows.Forms.CheckBox checkBoxPulse;
        private System.Windows.Forms.RadioButton radioButtonTime;
        private System.Windows.Forms.RadioButton radioButtonCells;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxPassing;
        private System.Windows.Forms.CheckBox checkBoxAutosave;
        private System.Windows.Forms.TextBox textBoxAutosave;
        private System.Windows.Forms.ComboBox comboBoxChart;
        private System.Windows.Forms.RadioButton radioButtonHarmonics;
        private System.Windows.Forms.TextBox textBoxMismatch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBoxSaveFinal;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxAxisXCorrectionMax;
        private System.Windows.Forms.TextBox textBoxAxisXCorrectionMin;
        private System.Windows.Forms.TextBox textBoxAxisYCorrectionMin;
        private System.Windows.Forms.TextBox textBoxAxisYCorrectionMax;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBoxAxisXAutocorrection;
        private System.Windows.Forms.CheckBox checkBoxAxisYAutocorrection;
    }
}

