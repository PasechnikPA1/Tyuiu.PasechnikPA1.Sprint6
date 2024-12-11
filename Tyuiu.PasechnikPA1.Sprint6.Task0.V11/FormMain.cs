using Tyuiu.PasechnikPA1.Sprint6.Task0.V11.Lib;
namespace Tyuiu.PasechnikPA1.Sprint6.Task0.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_AKS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_AKS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_AKS.Text)));
            }
            catch
            {

                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInput_AKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 0 выполнил студент группы ј—ќи”б-24-1 ѕасечник ѕавел јндреевич", "—ообщение");
        }
    }
}
