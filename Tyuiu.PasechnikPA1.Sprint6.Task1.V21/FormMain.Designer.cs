namespace Tyuiu.PasechnikPA1.Sprint6.Task1.V21
{
    partial class FormMain_KEA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KEA));
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxStartValue_KEA = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_KEA = new System.Windows.Forms.TextBox();
            this.labelStartValue_KEA = new System.Windows.Forms.Label();
            this.labelStopValue_KEA = new System.Windows.Forms.Label();
            this.buttonExecute_KEA = new System.Windows.Forms.Button();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.groupBoxOutput_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KEA = new System.Windows.Forms.TextBox();
            this.labelResult_KEA = new System.Windows.Forms.Label();
            this.groupBoxTask_KEA.SuspendLayout();
            this.groupBoxInput_KEA.SuspendLayout();
            this.groupBoxOutput_KEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(512, 257);
            this.groupBoxTask_KEA.TabIndex = 0;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие";
            this.groupBoxTask_KEA.Enter += new System.EventHandler(this.groupBoxTask_KEA_Enter);
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.Enabled = false;
            this.textBoxTask_KEA.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_KEA.Location = new System.Drawing.Point(0, 24);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(459, 190);
            this.textBoxTask_KEA.TabIndex = 1;
            this.textBoxTask_KEA.Text = resources.GetString("textBoxTask_KEA.Text");
            this.textBoxTask_KEA.TextChanged += new System.EventHandler(this.textBoxTask_KEA_TextChanged);
            // 
            // groupBoxInput_KEA
            // 
            this.groupBoxInput_KEA.Controls.Add(this.textBoxStartValue_KEA);
            this.groupBoxInput_KEA.Controls.Add(this.textBoxStopValue_KEA);
            this.groupBoxInput_KEA.Controls.Add(this.labelStartValue_KEA);
            this.groupBoxInput_KEA.Controls.Add(this.labelStopValue_KEA);
            this.groupBoxInput_KEA.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_KEA.Location = new System.Drawing.Point(12, 275);
            this.groupBoxInput_KEA.Name = "groupBoxInput_KEA";
            this.groupBoxInput_KEA.Size = new System.Drawing.Size(512, 102);
            this.groupBoxInput_KEA.TabIndex = 1;
            this.groupBoxInput_KEA.TabStop = false;
            this.groupBoxInput_KEA.Text = "Входные данные: ";
            this.groupBoxInput_KEA.Enter += new System.EventHandler(this.groupBoxInput_KEA_Enter);
            // 
            // textBoxStartValue_KEA
            // 
            this.textBoxStartValue_KEA.Location = new System.Drawing.Point(9, 42);
            this.textBoxStartValue_KEA.Multiline = true;
            this.textBoxStartValue_KEA.Name = "textBoxStartValue_KEA";
            this.textBoxStartValue_KEA.Size = new System.Drawing.Size(111, 40);
            this.textBoxStartValue_KEA.TabIndex = 3;
            this.textBoxStartValue_KEA.Text = "-5";
            this.textBoxStartValue_KEA.TextChanged += new System.EventHandler(this.textBoxStartValue_KEA_TextChanged);
            // 
            // textBoxStopValue_KEA
            // 
            this.textBoxStopValue_KEA.Location = new System.Drawing.Point(246, 42);
            this.textBoxStopValue_KEA.Multiline = true;
            this.textBoxStopValue_KEA.Name = "textBoxStopValue_KEA";
            this.textBoxStopValue_KEA.Size = new System.Drawing.Size(100, 40);
            this.textBoxStopValue_KEA.TabIndex = 2;
            this.textBoxStopValue_KEA.Text = "5";
            this.textBoxStopValue_KEA.TextChanged += new System.EventHandler(this.textBoxStopValue_KEA_TextChanged);
            // 
            // labelStartValue_KEA
            // 
            this.labelStartValue_KEA.Location = new System.Drawing.Point(6, 21);
            this.labelStartValue_KEA.Name = "labelStartValue_KEA";
            this.labelStartValue_KEA.Size = new System.Drawing.Size(234, 18);
            this.labelStartValue_KEA.TabIndex = 1;
            this.labelStartValue_KEA.Text = "Старт шага:";
            // 
            // labelStopValue_KEA
            // 
            this.labelStopValue_KEA.Location = new System.Drawing.Point(243, 21);
            this.labelStopValue_KEA.Name = "labelStopValue_KEA";
            this.labelStopValue_KEA.Size = new System.Drawing.Size(216, 18);
            this.labelStopValue_KEA.TabIndex = 0;
            this.labelStopValue_KEA.Text = "Конец шага: ";
            // 
            // buttonExecute_KEA
            // 
            this.buttonExecute_KEA.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonExecute_KEA.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExecute_KEA.Location = new System.Drawing.Point(628, 389);
            this.buttonExecute_KEA.Name = "buttonExecute_KEA";
            this.buttonExecute_KEA.Size = new System.Drawing.Size(151, 49);
            this.buttonExecute_KEA.TabIndex = 4;
            this.buttonExecute_KEA.Text = "Выполнить";
            this.buttonExecute_KEA.UseVisualStyleBackColor = false;
            this.buttonExecute_KEA.Click += new System.EventHandler(this.buttonExecute_KEA_Click);
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonHelp_KEA.Location = new System.Drawing.Point(566, 389);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(56, 49);
            this.buttonHelp_KEA.TabIndex = 4;
            this.buttonHelp_KEA.Text = "?";
            this.buttonHelp_KEA.UseVisualStyleBackColor = false;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // groupBoxOutput_KEA
            // 
            this.groupBoxOutput_KEA.Controls.Add(this.textBoxResult_KEA);
            this.groupBoxOutput_KEA.Controls.Add(this.labelResult_KEA);
            this.groupBoxOutput_KEA.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_KEA.Location = new System.Drawing.Point(530, 12);
            this.groupBoxOutput_KEA.Name = "groupBoxOutput_KEA";
            this.groupBoxOutput_KEA.Size = new System.Drawing.Size(258, 365);
            this.groupBoxOutput_KEA.TabIndex = 5;
            this.groupBoxOutput_KEA.TabStop = false;
            this.groupBoxOutput_KEA.Text = "Вывод данных:";
            // 
            // textBoxResult_KEA
            // 
            this.textBoxResult_KEA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KEA.Location = new System.Drawing.Point(9, 42);
            this.textBoxResult_KEA.Multiline = true;
            this.textBoxResult_KEA.Name = "textBoxResult_KEA";
            this.textBoxResult_KEA.ReadOnly = true;
            this.textBoxResult_KEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KEA.Size = new System.Drawing.Size(240, 317);
            this.textBoxResult_KEA.TabIndex = 1;
            this.textBoxResult_KEA.TextChanged += new System.EventHandler(this.textBoxResult_KEA_TextChanged);
            // 
            // labelResult_KEA
            // 
            this.labelResult_KEA.AutoSize = true;
            this.labelResult_KEA.Location = new System.Drawing.Point(6, 21);
            this.labelResult_KEA.Name = "labelResult_KEA";
            this.labelResult_KEA.Size = new System.Drawing.Size(78, 18);
            this.labelResult_KEA.TabIndex = 0;
            this.labelResult_KEA.Text = "Результат:";
            // 
            // FormMain_KEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_KEA);
            this.Controls.Add(this.buttonHelp_KEA);
            this.Controls.Add(this.buttonExecute_KEA);
            this.Controls.Add(this.groupBoxInput_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Name = "FormMain_KEA";
            this.Text = "Спринт 6 | Таск 1 | Вариант 21 | Култышева Е.А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            this.groupBoxInput_KEA.ResumeLayout(false);
            this.groupBoxInput_KEA.PerformLayout();
            this.groupBoxOutput_KEA.ResumeLayout(false);
            this.groupBoxOutput_KEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.GroupBox groupBoxInput_KEA;
        private System.Windows.Forms.TextBox textBoxStartValue_KEA;
        private System.Windows.Forms.TextBox textBoxStopValue_KEA;
        private System.Windows.Forms.Label labelStartValue_KEA;
        private System.Windows.Forms.Label labelStopValue_KEA;
        private System.Windows.Forms.Button buttonExecute_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.GroupBox groupBoxOutput_KEA;
        private System.Windows.Forms.TextBox textBoxResult_KEA;
        private System.Windows.Forms.Label labelResult_KEA;
    }
}
