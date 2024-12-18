using Tyuiu.PasechnikPA1.Sprint6.Task3.V5.Lib;
namespace Tyuiu.PasechnikPA1.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[,] { { 30, -20, 7, -8, 9 }, { 32, 17, -14, -7, 33 },
                { 19, -19, -13, 14, -20}, { 11, 30, -1, 26, 6 }, { 30, -15, -20, -5, 15 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;
            dataGridViewData_SME.RowCount = rows;
            dataGridViewData_SME.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewData_SME.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewData_SME.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_SME_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;
            dataGridViewMatrix_SME.RowCount = rows;
            dataGridViewMatrix_SME.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SME.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SME.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }

            }

        }

        private void buttonHelp_SME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 3 ��������� ������� ������ ����-23-2 ��������� �. �.", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
