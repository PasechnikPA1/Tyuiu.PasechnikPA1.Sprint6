using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PasechnikPA1.Sprint6.Task4.V23.Lib;
namespace Tyuiu.PasechnikPA1.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain_CSR()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_CSR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_CSR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_CSR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);


                this.chartResult_CSR.ChartAreas[0].AxisX.Title = "��� X";
                this.chartResult_CSR.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult_CSR.Text = "";

                chartResult_CSR.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_CSR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_CSR.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_CSR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
                File.WriteAllText(path, textBoxResult_CSR.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + path + " �������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 ��������� ��������� ������ �����-23-1 ������ ����� ���������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void splitterLeft_CSR_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void groupBoxResult_CSR_Enter(object sender, EventArgs e)
        {

        }

        private void buttonResult_CSR_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonResult_CSR_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
