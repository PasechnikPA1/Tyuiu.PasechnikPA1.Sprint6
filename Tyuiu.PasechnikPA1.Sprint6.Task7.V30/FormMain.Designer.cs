namespace Tyuiu.PasechnikPA1.Sprint6.Task7.V30
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            panelUp_KNA = new Panel();
            buttonInfo_KNA = new Button();
            buttonDone_KNA = new Button();
            buttonSave_KNA = new Button();
            buttonOpenFile_KNA = new Button();
            panelUp2_KNA = new Panel();
            groupBoxTask_KNA = new GroupBox();
            textBoxTask_KNA = new TextBox();
            panelLeft_KNA = new Panel();
            groupBoxIn_KNA = new GroupBox();
            dataGridIn_KNA = new DataGridView();
            panelFill_KNA = new Panel();
            groupBoxOut_KNA = new GroupBox();
            dataGridOut_KNA = new DataGridView();
            splitterVD2_KNA = new Splitter();
            splitterVD_KNA = new Splitter();
            openFileDialogTask_KNA = new OpenFileDialog();
            saveFileDialogMatrix_KNA = new SaveFileDialog();
            toolTipButton_KNA = new ToolTip(components);
            panelUp_KNA.SuspendLayout();
            panelUp2_KNA.SuspendLayout();
            groupBoxTask_KNA.SuspendLayout();
            panelLeft_KNA.SuspendLayout();
            groupBoxIn_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridIn_KNA).BeginInit();
            panelFill_KNA.SuspendLayout();
            groupBoxOut_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOut_KNA).BeginInit();
            SuspendLayout();
            // 
            // panelUp_KNA
            // 
            panelUp_KNA.Controls.Add(buttonInfo_KNA);
            panelUp_KNA.Controls.Add(buttonDone_KNA);
            panelUp_KNA.Controls.Add(buttonSave_KNA);
            panelUp_KNA.Controls.Add(buttonOpenFile_KNA);
            panelUp_KNA.Dock = DockStyle.Top;
            panelUp_KNA.Location = new Point(0, 0);
            panelUp_KNA.Name = "panelUp_KNA";
            panelUp_KNA.Size = new Size(1121, 115);
            panelUp_KNA.TabIndex = 0;
            // 
            // buttonInfo_KNA
            // 
            buttonInfo_KNA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_KNA.BackColor = SystemColors.Menu;
            buttonInfo_KNA.Location = new Point(992, 7);
            buttonInfo_KNA.Margin = new Padding(4, 4, 4, 4);
            buttonInfo_KNA.Name = "buttonInfo_KNA";
            buttonInfo_KNA.Size = new Size(113, 104);
            buttonInfo_KNA.TabIndex = 3;
            toolTipButton_KNA.SetToolTip(buttonInfo_KNA, "buttonHelp_KNA_MouseEnter");
            buttonInfo_KNA.UseVisualStyleBackColor = false;
            buttonInfo_KNA.Click += buttonInfo_KNA_Click;
            // 
            // buttonDone_KNA
            // 
            buttonDone_KNA.BackColor = SystemColors.Menu;
            buttonDone_KNA.Location = new Point(125, 4);
            buttonDone_KNA.Margin = new Padding(4, 4, 4, 4);
            buttonDone_KNA.Name = "buttonDone_KNA";
            buttonDone_KNA.Size = new Size(113, 104);
            buttonDone_KNA.TabIndex = 1;
            toolTipButton_KNA.SetToolTip(buttonDone_KNA, "Выполнить");
            buttonDone_KNA.UseVisualStyleBackColor = false;
            buttonDone_KNA.Click += buttonDone_KNA_Click;
            // 
            // buttonSave_KNA
            // 
            buttonSave_KNA.BackColor = SystemColors.Menu;
            buttonSave_KNA.Location = new Point(247, 4);
            buttonSave_KNA.Margin = new Padding(4, 4, 4, 4);
            buttonSave_KNA.Name = "buttonSave_KNA";
            buttonSave_KNA.Size = new Size(113, 104);
            buttonSave_KNA.TabIndex = 2;
            toolTipButton_KNA.SetToolTip(buttonSave_KNA, "Сохранить файл");
            buttonSave_KNA.UseVisualStyleBackColor = false;
            buttonSave_KNA.Click += buttonSave_KNA_Click;
            // 
            // buttonOpenFile_KNA
            // 
            buttonOpenFile_KNA.BackColor = SystemColors.Menu;
            buttonOpenFile_KNA.Location = new Point(4, 4);
            buttonOpenFile_KNA.Margin = new Padding(4, 4, 4, 4);
            buttonOpenFile_KNA.Name = "buttonOpenFile_KNA";
            buttonOpenFile_KNA.Size = new Size(113, 104);
            buttonOpenFile_KNA.TabIndex = 0;
            toolTipButton_KNA.SetToolTip(buttonOpenFile_KNA, "Открыть файл\r\n");
            buttonOpenFile_KNA.UseVisualStyleBackColor = false;
            buttonOpenFile_KNA.Click += buttonOpenFile_KNA_Click;
            // 
            // panelUp2_KNA
            // 
            panelUp2_KNA.Controls.Add(groupBoxTask_KNA);
            panelUp2_KNA.Dock = DockStyle.Top;
            panelUp2_KNA.Location = new Point(0, 115);
            panelUp2_KNA.Name = "panelUp2_KNA";
            panelUp2_KNA.Size = new Size(1121, 115);
            panelUp2_KNA.TabIndex = 1;
            // 
            // groupBoxTask_KNA
            // 
            groupBoxTask_KNA.Controls.Add(textBoxTask_KNA);
            groupBoxTask_KNA.Dock = DockStyle.Fill;
            groupBoxTask_KNA.Location = new Point(0, 0);
            groupBoxTask_KNA.Margin = new Padding(4, 4, 4, 4);
            groupBoxTask_KNA.Name = "groupBoxTask_KNA";
            groupBoxTask_KNA.Padding = new Padding(4, 4, 4, 4);
            groupBoxTask_KNA.Size = new Size(1121, 115);
            groupBoxTask_KNA.TabIndex = 2;
            groupBoxTask_KNA.TabStop = false;
            groupBoxTask_KNA.Text = "Условие";
            // 
            // textBoxTask_KNA
            // 
            textBoxTask_KNA.BackColor = SystemColors.Menu;
            textBoxTask_KNA.BorderStyle = BorderStyle.None;
            textBoxTask_KNA.Location = new Point(8, 28);
            textBoxTask_KNA.Margin = new Padding(4, 4, 4, 4);
            textBoxTask_KNA.Multiline = true;
            textBoxTask_KNA.Name = "textBoxTask_KNA";
            textBoxTask_KNA.Size = new Size(772, 72);
            textBoxTask_KNA.TabIndex = 0;
            // 
            // panelLeft_KNA
            // 
            panelLeft_KNA.Controls.Add(groupBoxIn_KNA);
            panelLeft_KNA.Dock = DockStyle.Left;
            panelLeft_KNA.Location = new Point(0, 230);
            panelLeft_KNA.Name = "panelLeft_KNA";
            panelLeft_KNA.Size = new Size(537, 657);
            panelLeft_KNA.TabIndex = 0;
            // 
            // groupBoxIn_KNA
            // 
            groupBoxIn_KNA.Controls.Add(dataGridIn_KNA);
            groupBoxIn_KNA.Dock = DockStyle.Fill;
            groupBoxIn_KNA.Location = new Point(0, 0);
            groupBoxIn_KNA.Margin = new Padding(4, 4, 4, 4);
            groupBoxIn_KNA.Name = "groupBoxIn_KNA";
            groupBoxIn_KNA.Padding = new Padding(4, 4, 4, 4);
            groupBoxIn_KNA.Size = new Size(537, 657);
            groupBoxIn_KNA.TabIndex = 0;
            groupBoxIn_KNA.TabStop = false;
            groupBoxIn_KNA.Text = "Ввод";
            // 
            // dataGridIn_KNA
            // 
            dataGridIn_KNA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridIn_KNA.Dock = DockStyle.Fill;
            dataGridIn_KNA.Location = new Point(4, 23);
            dataGridIn_KNA.Margin = new Padding(4, 4, 4, 4);
            dataGridIn_KNA.Name = "dataGridIn_KNA";
            dataGridIn_KNA.RowHeadersWidth = 47;
            dataGridIn_KNA.Size = new Size(529, 630);
            dataGridIn_KNA.TabIndex = 1;
            // 
            // panelFill_KNA
            // 
            panelFill_KNA.Controls.Add(groupBoxOut_KNA);
            panelFill_KNA.Controls.Add(splitterVD2_KNA);
            panelFill_KNA.Controls.Add(splitterVD_KNA);
            panelFill_KNA.Dock = DockStyle.Fill;
            panelFill_KNA.Location = new Point(537, 230);
            panelFill_KNA.Name = "panelFill_KNA";
            panelFill_KNA.Size = new Size(584, 657);
            panelFill_KNA.TabIndex = 0;
            // 
            // groupBoxOut_KNA
            // 
            groupBoxOut_KNA.Controls.Add(dataGridOut_KNA);
            groupBoxOut_KNA.Dock = DockStyle.Fill;
            groupBoxOut_KNA.Location = new Point(8, 0);
            groupBoxOut_KNA.Margin = new Padding(4, 4, 4, 4);
            groupBoxOut_KNA.Name = "groupBoxOut_KNA";
            groupBoxOut_KNA.Padding = new Padding(4, 4, 4, 4);
            groupBoxOut_KNA.Size = new Size(576, 657);
            groupBoxOut_KNA.TabIndex = 2;
            groupBoxOut_KNA.TabStop = false;
            groupBoxOut_KNA.Text = "Вывод";
            // 
            // dataGridOut_KNA
            // 
            dataGridOut_KNA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOut_KNA.Dock = DockStyle.Fill;
            dataGridOut_KNA.Location = new Point(4, 23);
            dataGridOut_KNA.Margin = new Padding(4, 4, 4, 4);
            dataGridOut_KNA.Name = "dataGridOut_KNA";
            dataGridOut_KNA.RowHeadersWidth = 47;
            dataGridOut_KNA.Size = new Size(568, 630);
            dataGridOut_KNA.TabIndex = 2;
            // 
            // splitterVD2_KNA
            // 
            splitterVD2_KNA.Location = new Point(4, 0);
            splitterVD2_KNA.Margin = new Padding(4, 4, 4, 4);
            splitterVD2_KNA.Name = "splitterVD2_KNA";
            splitterVD2_KNA.Size = new Size(4, 657);
            splitterVD2_KNA.TabIndex = 1;
            splitterVD2_KNA.TabStop = false;
            // 
            // splitterVD_KNA
            // 
            splitterVD_KNA.Location = new Point(0, 0);
            splitterVD_KNA.Margin = new Padding(4, 4, 4, 4);
            splitterVD_KNA.Name = "splitterVD_KNA";
            splitterVD_KNA.Size = new Size(4, 657);
            splitterVD_KNA.TabIndex = 0;
            splitterVD_KNA.TabStop = false;
            // 
            // openFileDialogTask_KNA
            // 
            openFileDialogTask_KNA.FileName = "openFileDialog1";
            // 
            // toolTipButton_KNA
            // 
            toolTipButton_KNA.IsBalloon = true;
            toolTipButton_KNA.OwnerDraw = true;
            toolTipButton_KNA.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 887);
            Controls.Add(panelFill_KNA);
            Controls.Add(panelLeft_KNA);
            Controls.Add(panelUp2_KNA);
            Controls.Add(panelUp_KNA);
            MinimumSize = new Size(1137, 924);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 30 | Карпенко Н.А.";
            Load += FormMain_Load_1;
            panelUp_KNA.ResumeLayout(false);
            panelUp2_KNA.ResumeLayout(false);
            groupBoxTask_KNA.ResumeLayout(false);
            groupBoxTask_KNA.PerformLayout();
            panelLeft_KNA.ResumeLayout(false);
            groupBoxIn_KNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridIn_KNA).EndInit();
            panelFill_KNA.ResumeLayout(false);
            groupBoxOut_KNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOut_KNA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUp_KNA;
        private System.Windows.Forms.Panel panelUp2_KNA;
        private System.Windows.Forms.Panel panelLeft_KNA;
        private System.Windows.Forms.Panel panelFill_KNA;
        private System.Windows.Forms.Splitter splitterVD2_KNA;
        private System.Windows.Forms.Splitter splitterVD_KNA;
        private System.Windows.Forms.Button buttonSave_KNA;
        private System.Windows.Forms.Button buttonDone_KNA;
        private System.Windows.Forms.Button buttonOpenFile_KNA;
        private System.Windows.Forms.GroupBox groupBoxIn_KNA;
        private System.Windows.Forms.GroupBox groupBoxOut_KNA;
        private System.Windows.Forms.Button buttonInfo_KNA;
        private System.Windows.Forms.GroupBox groupBoxTask_KNA;
        private System.Windows.Forms.TextBox textBoxTask_KNA;
        private System.Windows.Forms.DataGridView dataGridIn_KNA;
        private System.Windows.Forms.DataGridView dataGridOut_KNA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KNA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KNA;
        private System.Windows.Forms.ToolTip toolTipButton_KNA;
    }
}
