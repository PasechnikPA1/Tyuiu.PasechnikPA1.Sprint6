namespace Tyuiu.PasechnikPA1.Sprint6.Task6.V15
{
    partial class FormAbout
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
            LabelInfo_RKN = new TextBox();
            buttonOk_RKN = new Button();
            SuspendLayout();
            // 
            // LabelInfo_RKN
            // 
            LabelInfo_RKN.BorderStyle = BorderStyle.None;
            LabelInfo_RKN.Location = new Point(14, 15);
            LabelInfo_RKN.Margin = new Padding(3, 4, 3, 4);
            LabelInfo_RKN.Multiline = true;
            LabelInfo_RKN.Name = "LabelInfo_RKN";
            LabelInfo_RKN.ReadOnly = true;
            LabelInfo_RKN.Size = new Size(368, 193);
            LabelInfo_RKN.TabIndex = 0;
            // 
            // buttonOk_RKN
            // 
            buttonOk_RKN.AllowDrop = true;
            buttonOk_RKN.Location = new Point(233, 196);
            buttonOk_RKN.Margin = new Padding(3, 4, 3, 4);
            buttonOk_RKN.Name = "buttonOk_RKN";
            buttonOk_RKN.Size = new Size(128, 49);
            buttonOk_RKN.TabIndex = 1;
            buttonOk_RKN.Text = "Ок";
            buttonOk_RKN.UseVisualStyleBackColor = true;
            buttonOk_RKN.Click += buttonOk_RKN_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 261);
            Controls.Add(buttonOk_RKN);
            Controls.Add(LabelInfo_RKN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LabelInfo_RKN;
        private Button buttonOk_RKN;
    }
}