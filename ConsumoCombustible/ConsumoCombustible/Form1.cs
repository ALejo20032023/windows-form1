namespace ConsumoCombustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Kilometros = double.Parse(txtD.Text);
            double rendimiento = double.Parse(txtC.Text);



            double Galonesconsumidos = Kilometros / rendimiento * 1;

            txtG.Text = Galonesconsumidos.ToString();
        }
    }
}
