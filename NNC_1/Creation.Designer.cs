namespace NNC_1
{
    partial class Creation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.zedGraphControl2 = new Accord.Controls.ScatterplotView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSameWeights = new System.Windows.Forms.CheckBox();
            this.cbNguyenWidrow = new System.Windows.Forms.CheckBox();
            this.cbRegularization = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.currentElapsed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentErrorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentIterationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.neuronsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alphaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.learningRateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьКлассическоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(737, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 100);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Перейти к тестированию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.LinesVisible = false;
            this.zedGraphControl2.Location = new System.Drawing.Point(3, 18);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScaleTight = true;
            this.zedGraphControl2.Size = new System.Drawing.Size(625, 423);
            this.zedGraphControl2.SymbolSize = 7F;
            this.zedGraphControl2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(197, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 100);
            this.button3.TabIndex = 23;
            this.button3.Text = "&Справка";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(6, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 100);
            this.button2.TabIndex = 22;
            this.button2.Text = "&Вернуться к выбору данных";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSameWeights);
            this.groupBox1.Controls.Add(this.cbNguyenWidrow);
            this.groupBox1.Controls.Add(this.cbRegularization);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.neuronsBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.alphaBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.learningRateBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.iterationsBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(14, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 445);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // cbSameWeights
            // 
            this.cbSameWeights.AutoSize = true;
            this.cbSameWeights.Enabled = false;
            this.cbSameWeights.Location = new System.Drawing.Point(15, 215);
            this.cbSameWeights.Name = "cbSameWeights";
            this.cbSameWeights.Size = new System.Drawing.Size(200, 21);
            this.cbSameWeights.TabIndex = 26;
            this.cbSameWeights.Text = "Статичная иницилизация";
            this.cbSameWeights.UseVisualStyleBackColor = true;
            this.cbSameWeights.CheckedChanged += new System.EventHandler(this.cbSameWeights_CheckedChanged);
            // 
            // cbNguyenWidrow
            // 
            this.cbNguyenWidrow.AutoSize = true;
            this.cbNguyenWidrow.Location = new System.Drawing.Point(15, 179);
            this.cbNguyenWidrow.Name = "cbNguyenWidrow";
            this.cbNguyenWidrow.Size = new System.Drawing.Size(164, 21);
            this.cbNguyenWidrow.TabIndex = 26;
            this.cbNguyenWidrow.Text = "Веса Нгуена Видроу";
            this.cbNguyenWidrow.UseVisualStyleBackColor = true;
            this.cbNguyenWidrow.CheckedChanged += new System.EventHandler(this.cbNguyenWidrow_CheckedChanged);
            // 
            // cbRegularization
            // 
            this.cbRegularization.AutoSize = true;
            this.cbRegularization.Location = new System.Drawing.Point(15, 141);
            this.cbRegularization.Name = "cbRegularization";
            this.cbRegularization.Size = new System.Drawing.Size(241, 21);
            this.cbRegularization.TabIndex = 26;
            this.cbRegularization.Text = "Байесосовская классификация:";
            this.cbRegularization.UseVisualStyleBackColor = true;
            this.cbRegularization.CheckedChanged += new System.EventHandler(this.cbRegularization_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.currentElapsed);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.currentErrorBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.currentIterationBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(0, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 152);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Текущий проход";
            // 
            // currentElapsed
            // 
            this.currentElapsed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.currentElapsed.Location = new System.Drawing.Point(105, 96);
            this.currentElapsed.Name = "currentElapsed";
            this.currentElapsed.ReadOnly = true;
            this.currentElapsed.Size = new System.Drawing.Size(122, 22);
            this.currentElapsed.TabIndex = 3;
            this.currentElapsed.TextChanged += new System.EventHandler(this.currentElapsed_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Прошло:";
            // 
            // currentErrorBox
            // 
            this.currentErrorBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.currentErrorBox.Location = new System.Drawing.Point(105, 68);
            this.currentErrorBox.Name = "currentErrorBox";
            this.currentErrorBox.ReadOnly = true;
            this.currentErrorBox.Size = new System.Drawing.Size(122, 22);
            this.currentErrorBox.TabIndex = 3;
            this.currentErrorBox.TextChanged += new System.EventHandler(this.currentErrorBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Общая ошибка:";
            // 
            // currentIterationBox
            // 
            this.currentIterationBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.currentIterationBox.Location = new System.Drawing.Point(107, 27);
            this.currentIterationBox.Name = "currentIterationBox";
            this.currentIterationBox.ReadOnly = true;
            this.currentIterationBox.Size = new System.Drawing.Size(120, 22);
            this.currentIterationBox.TabIndex = 1;
            this.currentIterationBox.TextChanged += new System.EventHandler(this.currentIterationBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Номер:";
            // 
            // neuronsBox
            // 
            this.neuronsBox.Location = new System.Drawing.Point(155, 95);
            this.neuronsBox.Name = "neuronsBox";
            this.neuronsBox.Size = new System.Drawing.Size(74, 22);
            this.neuronsBox.TabIndex = 7;
            this.neuronsBox.Text = "10";
            this.neuronsBox.TextChanged += new System.EventHandler(this.neuronsBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол-во нейронов:";
            // 
            // alphaBox
            // 
            this.alphaBox.Location = new System.Drawing.Point(155, 67);
            this.alphaBox.Name = "alphaBox";
            this.alphaBox.Size = new System.Drawing.Size(74, 22);
            this.alphaBox.TabIndex = 5;
            this.alphaBox.Text = "2";
            this.alphaBox.TextChanged += new System.EventHandler(this.alphaBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Альфа-значение:";
            // 
            // learningRateBox
            // 
            this.learningRateBox.Location = new System.Drawing.Point(155, 39);
            this.learningRateBox.Name = "learningRateBox";
            this.learningRateBox.Size = new System.Drawing.Size(74, 22);
            this.learningRateBox.TabIndex = 1;
            this.learningRateBox.Text = "0.1";
            this.learningRateBox.TextChanged += new System.EventHandler(this.learningRateBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Скорость обучения:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(11, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 2);
            this.label8.TabIndex = 22;
            // 
            // iterationsBox
            // 
            this.iterationsBox.Location = new System.Drawing.Point(107, 273);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(122, 22);
            this.iterationsBox.TabIndex = 9;
            this.iterationsBox.Text = "50";
            this.iterationsBox.TextChanged += new System.EventHandler(this.iterationsBox_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 40);
            this.label9.TabIndex = 8;
            this.label9.Text = "Кол-во проходов:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.startButton.Location = new System.Drawing.Point(379, 525);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(167, 100);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "&Начать обучение сети";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zedGraphControl2);
            this.groupBox2.Location = new System.Drawing.Point(298, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 444);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "График";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.stopButton.Location = new System.Drawing.Point(552, 525);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(179, 100);
            this.stopButton.TabIndex = 20;
            this.stopButton.Text = "&Пристановить обучение";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(19, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(555, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Основной этап. Создание и обучение ИНС";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьКлассическоеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьКлассическоеToolStripMenuItem
            // 
            this.открытьКлассическоеToolStripMenuItem.Name = "открытьКлассическоеToolStripMenuItem";
            this.открытьКлассическоеToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.открытьКлассическоеToolStripMenuItem.Text = "Перейти в классический режим";
            this.открытьКлассическоеToolStripMenuItem.Click += new System.EventHandler(this.открытьКлассическоеToolStripMenuItem_Click);
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 637);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Creation";
            this.Text = "Визуальный конструктор ИНС - Создание Сети";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Accord.Controls.ScatterplotView zedGraphControl2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSameWeights;
        private System.Windows.Forms.CheckBox cbNguyenWidrow;
        private System.Windows.Forms.CheckBox cbRegularization;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox currentElapsed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentErrorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentIterationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox neuronsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alphaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox learningRateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьКлассическоеToolStripMenuItem;
    }
}