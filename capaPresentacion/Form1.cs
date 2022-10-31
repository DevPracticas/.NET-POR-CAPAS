using capaLogica;
namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }int numero1, numero2;

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNumero2.Text != "")
                {
                    numero2 = int.Parse(txtNumero2.Text);
                    clSumar objSumar = new clSumar(numero1, numero2);
                    lblRespuesta.Text = objSumar.sumar().ToString();
                    
                }
                else
                    MessageBox.Show("ingrese valores");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNumero1.Text != "")
                {
                    numero1 = int.Parse(txtNumero1.Text);
                    txtNumero2.Focus();
                }
                else
                    MessageBox.Show("ingrese valores");
            }
        }
    }
}