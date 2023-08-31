namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCero_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }

        }

        private void btnocho_Click(object sender, EventArgs e)
        {

        }
    }
}