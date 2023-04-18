namespace CalculadoraWF
{
    public partial class Calculadora : Form
    {
        double n1, n2, result;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonCE_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void BotonIgual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(Pantalla.Text);

            switch (operacion)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "^":
                    result = 1;
                    for (int i = 0; i < n2; i++)
                    {
                        result *= n1;
                    }
                    break;
            }

            Pantalla.Text = result.ToString();
        }

        private void Boton0_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "0";
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "1";
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "2";
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "3";
        }

        private void BotonComa_Click(object sender, EventArgs e)
        {
            Pantalla.Text += ",";
        }

        private void Boton4_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "4";
        }

        private void Boton5_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "5";
        }

        private void Boton6_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "6";
        }

        private void BotonPotencia_Click(object sender, EventArgs e)
        {
            operacion = "^";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Boton7_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "7";
        }

        private void Boton8_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "8";
        }

        private void Boton9_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "9";
        }

        private void BotonSumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void BotonDiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void BotonMult_Click(object sender, EventArgs e)
        {
            operacion = "*";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void BotonRestar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }
    }
}