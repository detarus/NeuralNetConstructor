namespace NNC_1
{
    partial class Input
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.graphInput = new Accord.Controls.ScatterplotView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvLearningSource = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьКлассическоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox15.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.graphInput);
            this.groupBox15.Location = new System.Drawing.Point(263, 73);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(654, 423);
            this.groupBox15.TabIndex = 9;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "График";
            this.groupBox15.Enter += new System.EventHandler(this.groupBox15_Enter);
            // 
            // graphInput
            // 
            this.graphInput.AutoSize = true;
            this.graphInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphInput.LinesVisible = false;
            this.graphInput.Location = new System.Drawing.Point(3, 18);
            this.graphInput.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.graphInput.Name = "graphInput";
            this.graphInput.ScaleTight = false;
            this.graphInput.Size = new System.Drawing.Size(648, 402);
            this.graphInput.SymbolSize = 7F;
            this.graphInput.TabIndex = 5;
            this.graphInput.Load += new System.EventHandler(this.graphInput_Load);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvLearningSource);
            this.groupBox7.Location = new System.Drawing.Point(2, 73);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(261, 425);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Входные данные";
            // 
            // dgvLearningSource
            // 
            this.dgvLearningSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLearningSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLearningSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLearningSource.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLearningSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLearningSource.EnableHeadersVisualStyles = false;
            this.dgvLearningSource.Location = new System.Drawing.Point(3, 18);
            this.dgvLearningSource.Name = "dgvLearningSource";
            this.dgvLearningSource.ReadOnly = true;
            this.dgvLearningSource.RowHeadersVisible = false;
            this.dgvLearningSource.Size = new System.Drawing.Size(255, 404);
            this.dgvLearningSource.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(2, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 100);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выбрать исходные данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(517, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(393, 100);
            this.button2.TabIndex = 11;
            this.button2.Text = "Перейти к созданию сети";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(263, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 100);
            this.button3.TabIndex = 12;
            this.button3.Text = "Справка";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Начальный этап. Ввод начальных данных.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьКлассическоеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьКлассическоеToolStripMenuItem
            // 
            this.открытьКлассическоеToolStripMenuItem.Name = "открытьКлассическоеToolStripMenuItem";
            this.открытьКлассическоеToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.открытьКлассическоеToolStripMenuItem.Text = "Перейти в классический режим";
            this.открытьКлассическоеToolStripMenuItem.Click += new System.EventHandler(this.открытьКлассическоеToolStripMenuItem_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(909, 614);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox7);
            this.Name = "Input";
            this.Text = "Визуальный конструктор ИНС - Заполнение вводных данных";
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox15;
        private Accord.Controls.ScatterplotView graphInput;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvLearningSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьКлассическоеToolStripMenuItem;
    }
}