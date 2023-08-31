namespace Calculadora2
{
    public enum operacion
    {
        nodefinida = 0,
        suma = 1,
        resta = 2,
        division = 3,
        multiplicacion = 4,
        modulo = 5,
        potencia = 6,
        raiz = 7
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        operacion operador = operacion.nodefinida;
        bool unnumero = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void LeerNumero(string numero)
        {
            unnumero = true;
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case operacion.suma:
                    resultado = valor1 + valor2;
                    break;
                case operacion.resta:
                    resultado = valor1 - valor2;
                    break;
                case operacion.division:
                    if (valor2 == 0)
                    {
                        lblHistorial.Text = "No se puede dividir entre 0";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case operacion.multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case operacion.modulo:
                    resultado = valor1 % valor2;
                    break;
                case operacion.potencia:
                    resultado = valor1 = Math.Pow(valor1, 2);
                    break;
                case operacion.raiz:
                    resultado = valor1 = Math.Sqrt(valor1);
                    break;
            }
            return resultado;
        }
        private void btncero_Click(object sender, EventArgs e)
        {
            unnumero = true;
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }

        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");

        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void obtenervalor(string operador)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado + operador;
            cajaResultado.Text = "0";
        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = operacion.suma;
            obtenervalor("+");
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && unnumero)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unnumero = false;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = operacion.resta;
            obtenervalor("-");
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = operacion.multiplicacion;
            obtenervalor("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = operacion.division;
            obtenervalor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = operacion.modulo;
            obtenervalor("%");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text = "";
        }

        private void cajaResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Length > 1)
            {
                string txtresultado = cajaResultado.Text;
                //1000 < 1000 = 0
                txtresultado = txtresultado.Substring(0, txtresultado.Length - 1);

                if (txtresultado.Length == 1 && txtresultado.Contains("-"))
                {
                    cajaResultado.Text = "0";
                }
                else
                {
                    cajaResultado.Text = txtresultado;
                }
            }
            else
            {
                cajaResultado.Text = "0";
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Contains("."))
            {
                return;
            }
            cajaResultado.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = operacion.raiz;
            obtenervalor("√");
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            operador = operacion.potencia;
            obtenervalor("^2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}