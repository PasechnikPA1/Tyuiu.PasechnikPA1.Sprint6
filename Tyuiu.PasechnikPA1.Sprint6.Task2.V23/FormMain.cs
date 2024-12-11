using Tyuiu.PasechnikPA1.Sprint6.Task2.V23.Lib;
namespace Tyuiu.PasechnikPA1.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();

        private void buttonDone_SSV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxStartStep_SSV.Text);
                int stopStep = int.Parse(textBoxStopStep_SSV.Text);

                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = dataService.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функции f(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++, startStep++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_SSV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SSV.BackColor = Color.Red;
        }

        private void buttonDone_SSV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SSV.BackColor = Color.Green;
        }

        private void buttonDone_SSV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SSV.BackColor = Color.Blue;
        }

        private void buttonHelp_SSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-2 Сбродов Степан Владимирович", "Сообщение");
        }

        private void textBoxStartStep_SSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
