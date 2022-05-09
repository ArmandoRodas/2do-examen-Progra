namespace CALCULADORA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool clik = true;
        bool punto1 = true;
        string operacion;
        string eliminar;
        double no1, no2, result;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uno_Click(object sender, EventArgs e)
        {
            if (clik == true) {
                resultado.Text = "";
                resultado.Text = "1";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "1";
            }
        }

        private void dos_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "2";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "2";
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "3";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "3";
            }
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "4";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "4";
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "5";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "5";
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "6";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "6";
            }
        }

        private void siete_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "7";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "7";
            }
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "8";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "8";
            }
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            if (clik == true)
            {
                resultado.Text = "";
                resultado.Text = "9";
                clik = false;
            }
            else
            {
                resultado.Text = resultado.Text + "9";
            }
        }


        private void cero_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0") 
            {
                return;
            }
            else
            {
                resultado.Text= resultado.Text + "0";
            }
        }

        private void Historial_Click(object sender, EventArgs e)
        {

        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            no1 = double.Parse(resultado.Text);
            clik = true;
            Historial.Text = resultado.Text + " -";
            resultado.Text = "0";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            no1 = double.Parse(resultado.Text);
            clik = true;
            Historial.Text = resultado.Text + " *";
            resultado.Text = "0";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            no1 = double.Parse(resultado.Text);
            clik = true;
            Historial.Text = resultado.Text + " /";
            resultado.Text = "0";
        }


        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            no1 = double.Parse(resultado.Text);
            clik = true;
            Historial.Text = resultado.Text + " + ";
            resultado.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            no1 = 0;
            no2= 0;
            clik = true;
            Historial.Text = "--";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            if (punto1 == true)
            {
                resultado.Text = resultado.Text + ".";
                punto1 = true;
            }
           /* else
            {
                return;
            }*/
        }

        private void igual_Click(object sender, EventArgs e)
        {
            no2= double.Parse(resultado.Text);
            if (operacion == "+")
            {
                result = no1 + no2;
                resultado.Text = result.ToString();
                clik = true;
                Historial.Text = Historial.Text + no2 + " ="+ resultado.Text; 
            }
            if (operacion == "-")
            {
                result = no1 - no2;
                resultado.Text = result.ToString();
                clik = true;
                Historial.Text = Historial.Text + no2 + " =" + resultado.Text;
            }
            if (operacion == "*")
            {
                result = no1 * no2;
                resultado.Text = result.ToString();
                clik = true;
                Historial.Text = Historial.Text + no2 + " ="+ resultado.Text;
            }
            if (operacion == "/")
            {
                result = no1 / no2;
                resultado.Text = result.ToString();
                clik = true;
                Historial.Text = Historial.Text + no2 + " ="+ resultado.Text;
            }
        }
        private void CE_Click(object sender, EventArgs e)
        {
            int x = 0;
            eliminar = resultado.Text;
            x = eliminar.Length -1;
            eliminar = eliminar.Substring(x);
            resultado.Text= eliminar;
            Historial.Text = no1.ToString();
          /*  if (resultado.Text == "")
            {
                resultado.Text = "0";
                clik = true;
               
            }
            if (resultado.Text == "-")
            {
                resultado.Text="0";
                clik = true;
            }*/
        }
    }
}