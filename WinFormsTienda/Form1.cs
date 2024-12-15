namespace WinFormsTienda
{
    public partial class FormPORTADA : Form
    {
        public FormPORTADA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLOGIN  a1 = new FormLOGIN();
            this.Hide();
            a1.Show();
        }
    }
}
