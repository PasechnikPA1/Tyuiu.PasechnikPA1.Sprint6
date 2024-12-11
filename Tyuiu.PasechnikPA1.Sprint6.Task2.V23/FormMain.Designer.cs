namespace Tyuiu.PasechnikPA1.Sprint6.Task2.V23
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_SSV = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStartStep = new System.Windows.Forms.Label();
            this.labelStopStep = new System.Windows.Forms.Label();
            this.textBoxStopStep_SSV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SSV = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_SSV = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.GroupBoxInput.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SSV
            // 
            this.buttonDone_SSV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SSV.Location = new System.Drawing.Point(355, 250);
            this.buttonDone_SSV.Name = "buttonDone_SSV";
            this.buttonDone_SSV.Size = new System.Drawing.Size(112, 55);
            this.buttonDone_SSV.TabIndex = 14;
            this.buttonDone_SSV.Text = "Выполнить";
            this.buttonDone_SSV.UseVisualStyleBackColor = false;
            this.buttonDone_SSV.Click += new System.EventHandler(this.buttonDone_SSV_Click);
            this.buttonDone_SSV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SSV_MouseDown);
            this.buttonDone_SSV.MouseEnter += new System.EventHandler(this.buttonDone_SSV_MouseEnter);
            this.buttonDone_SSV.MouseLeave += new System.EventHandler(this.buttonDone_SSV_MouseLeave);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(455, 232);
            this.groupBoxTask.TabIndex = 15;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(442, 206);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Протабулировать функцию F(x) в заданном диапозоне\r\nРезультат вывести в DataGridVi" +
    "ew и построить график функции\r\n\r\n";
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.Controls.Add(this.labelStartStep);
            this.GroupBoxInput.Controls.Add(this.labelStopStep);
            this.GroupBoxInput.Controls.Add(this.textBoxStopStep_SSV);
            this.GroupBoxInput.Controls.Add(this.textBoxStartStep_SSV);
            this.GroupBoxInput.Location = new System.Drawing.Point(12, 250);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Size = new System.Drawing.Size(252, 55);
            this.GroupBoxInput.TabIndex = 15;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "Ввод данных";
            // 
            // labelStartStep
            // 
            this.labelStartStep.AutoSize = true;
            this.labelStartStep.Location = new System.Drawing.Point(3, 13);
            this.labelStartStep.Name = "labelStartStep";
            this.labelStartStep.Size = new System.Drawing.Size(68, 13);
            this.labelStartStep.TabIndex = 1;
            this.labelStartStep.Text = "Старт Шага:";
            // 
            // labelStopStep
            // 
            this.labelStopStep.AutoSize = true;
            this.labelStopStep.Location = new System.Drawing.Point(127, 13);
            this.labelStopStep.Name = "labelStopStep";
            this.labelStopStep.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep.TabIndex = 1;
            this.labelStopStep.Text = "Конец шага:";
            // 
            // textBoxStopStep_SSV
            // 
            this.textBoxStopStep_SSV.Location = new System.Drawing.Point(130, 29);
            this.textBoxStopStep_SSV.Name = "textBoxStopStep_SSV";
            this.textBoxStopStep_SSV.Size = new System.Drawing.Size(116, 20);
            this.textBoxStopStep_SSV.TabIndex = 0;
            this.textBoxStopStep_SSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_SSV_KeyPress);
            // 
            // textBoxStartStep_SSV
            // 
            this.textBoxStartStep_SSV.Location = new System.Drawing.Point(6, 29);
            this.textBoxStartStep_SSV.Name = "textBoxStartStep_SSV";
            this.textBoxStartStep_SSV.Size = new System.Drawing.Size(118, 20);
            this.textBoxStartStep_SSV.TabIndex = 0;
            this.textBoxStartStep_SSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_SSV_KeyPress);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewFunction);
            this.groupBoxResult.Controls.Add(this.chartFunction);
            this.groupBoxResult.Location = new System.Drawing.Point(473, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(544, 290);
            this.groupBoxResult.TabIndex = 15;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(122, 249);
            this.dataGridViewFunction.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction.Legends.Add(legend4);
            this.chartFunction.Location = new System.Drawing.Point(137, 35);
            this.chartFunction.Name = "chartFunction";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction.Series.Add(series4);
            this.chartFunction.Size = new System.Drawing.Size(401, 252);
            this.chartFunction.TabIndex = 6;
            this.chartFunction.Text = "chart1";
            // 
            // buttonHelp_SSV
            // 
            this.buttonHelp_SSV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SSV.Location = new System.Drawing.Point(270, 253);
            this.buttonHelp_SSV.Name = "buttonHelp_SSV";
            this.buttonHelp_SSV.Size = new System.Drawing.Size(79, 49);
            this.buttonHelp_SSV.TabIndex = 16;
            this.buttonHelp_SSV.Text = "Справка";
            this.buttonHelp_SSV.UseVisualStyleBackColor = false;
            this.buttonHelp_SSV.Click += new System.EventHandler(this.buttonHelp_SSV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.buttonHelp_SSV);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.GroupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.buttonDone_SSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Сбродов С. В";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.GroupBoxInput.ResumeLayout(false);
            this.GroupBoxInput.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SSV;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox GroupBoxInput;
        private System.Windows.Forms.Label labelStartStep;
        private System.Windows.Forms.Label labelStopStep;
        private System.Windows.Forms.TextBox textBoxStopStep_SSV;
        private System.Windows.Forms.TextBox textBoxStartStep_SSV;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button buttonHelp_SSV;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}
