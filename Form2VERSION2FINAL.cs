using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace METODOLOGIAS
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] A = new string[] { "CPU", "MONITOR", "TECLADO", "MOUSE",
            "ESCRIT. MELAMINA","SILLA GIRATORIA","BANQUITO DE MADERA","EXTINTOR"};
            string[] B = new string[] { "BUENO", "MALO", "REGULAR", "NO FUNCIONA" };
            string[] C = new string[] { "HETDO98766", "HYWSQ75308", "HSOHAL8990", "HGET77288" };
            string[] D = new string[] { "1 AÑO", "2 AÑOS", "6 MESES", "1 AÑO Y 2 MESES", "10 MESES", "1 AÑO Y MEDIO" };
            string[] E = new string[] { "CODIGO DE PATRIMONIO", "USUARIO" };
            //int B = int.Parse(codig.Text);
            Random rnd = new Random();
            int ra = rnd.Next(0, 2);
            if (ra == 1)
            {
                validar.Text = "PATRIMONIO Y USUARIO EXISTE ";
                //int A = int.Parse(TEXTN1.Text);
                report.Text = "COD.PATRIMONIO =" + codig.Text;
                report1.Text = "USUARIO =" + TEXTN1.Text;
                report2.Text = "DESCRIPCION = " + A[rnd.Next(0, 8)];
                report3.Text = "ESTADO = " + B[rnd.Next(0, 4)];
                report4.Text = "MODELO = " + C[rnd.Next(0, 4)];
                report5.Text = "AÑOS DE USO = " + D[rnd.Next(0, 6)];
            }
            else
            {
                int p = rnd.Next(0, 1);
                validar.Text = E[p] + " NO EXISTE.... VERIFIQUE NUEVAMENTE";
                report.Text = "VACIO";
                report1.Text = "VACIO";
                report2.Text = "VACIO";
                report3.Text = "VACIO";
                report4.Text = "VACIO";
                report5.Text = "VACIO ";
            }
            /*if (A > 10000 || A < 0)
            {
                report.Text = "EN PROCESO....";
            }
            else
                report.Text = "EN PROCESO....!!!!";*/
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TEXTN1.Text = "";
            codig.Text = "";
            report.Text = "";
            report1.Text = "";
            report2.Text = "";
            report3.Text = "";
            report4.Text = "";
            report5.Text = "";
            validar.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TEXTN1_TextChanged(object sender, EventArgs e)
        {

        }
        private void report5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
