namespace Aula_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            lbx.Items.Add($"{dataTimePicker.Value:d} - {txtTarefa.Text}");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = lbx.Items.Count - 1; i >= 0; i--)
            {
                if (lbx.GetSelected(i))
                {
                    lbx.Items.RemoveAt(i);
                }
            }
        }
    }
}