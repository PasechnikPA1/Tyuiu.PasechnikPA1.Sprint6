using Tyuiu.PasechnikPA1.Sprint6.Task1.V21.Lib;
namespace Tyuiu.PasechnikPA1.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain_KEA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTask_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStopValue_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartValue_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExecute_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_KEA.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_KEA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KEA.Text = "";
                textBoxResult_KEA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KEA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_KEA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_KEA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KEA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-23-3 Култышева Екатерина Александровна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
