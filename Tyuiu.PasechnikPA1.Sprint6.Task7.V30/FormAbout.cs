using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PasechnikPA1.Sprint6.Task7.V30
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            InitializeComponent();
        }

        private void buttonOk_KNA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
