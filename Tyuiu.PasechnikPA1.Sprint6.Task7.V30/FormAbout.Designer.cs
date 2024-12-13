namespace Tyuiu.PasechnikPA1.Sprint6.Task7.V30
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
            groupBoxInfo_KNA = new GroupBox();
            textBoxInfo_KNA = new TextBox();
            pictureBox1 = new PictureBox();
            buttonOk_KNA = new Button();
            pictureBox2 = new PictureBox();
            groupBoxInfo_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo_KNA
            // 
            groupBoxInfo_KNA.Controls.Add(textBoxInfo_KNA);
            groupBoxInfo_KNA.Location = new Point(465, 70);
            groupBoxInfo_KNA.Margin = new Padding(4, 4, 4, 4);
            groupBoxInfo_KNA.Name = "groupBoxInfo_KNA";
            groupBoxInfo_KNA.Padding = new Padding(4, 4, 4, 4);
            groupBoxInfo_KNA.Size = new Size(521, 456);
            groupBoxInfo_KNA.TabIndex = 0;
            groupBoxInfo_KNA.TabStop = false;
            // 
            // textBoxInfo_KNA
            // 
            textBoxInfo_KNA.BackColor = SystemColors.Menu;
            textBoxInfo_KNA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInfo_KNA.Location = new Point(8, 98);
            textBoxInfo_KNA.Margin = new Padding(4, 4, 4, 4);
            textBoxInfo_KNA.Multiline = true;
            textBoxInfo_KNA.Name = "textBoxInfo_KNA";
            textBoxInfo_KNA.ReadOnly = true;
            textBoxInfo_KNA.Size = new Size(459, 263);
            textBoxInfo_KNA.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 51);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 519);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonOk_KNA
            // 
            buttonOk_KNA.Location = new Point(880, 593);
            buttonOk_KNA.Margin = new Padding(4, 4, 4, 4);
            buttonOk_KNA.Name = "buttonOk_KNA";
            buttonOk_KNA.Size = new Size(171, 47);
            buttonOk_KNA.TabIndex = 2;
            buttonOk_KNA.Text = "Ок";
            buttonOk_KNA.UseVisualStyleBackColor = true;
            buttonOk_KNA.Click += buttonOk_KNA_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.kit;
            pictureBox2.Location = new Point(24, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(657, 507);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 658);
            Controls.Add(pictureBox2);
            Controls.Add(buttonOk_KNA);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxInfo_KNA);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormAbout";
            Text = "Справка";
            groupBoxInfo_KNA.ResumeLayout(false);
            groupBoxInfo_KNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_KNA;
        private System.Windows.Forms.TextBox textBoxInfo_KNA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOk_KNA;
        private PictureBox pictureBox2;
    }
}