using System;
using System.Windows.Forms;

namespace Relógio_Digital
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contador = 0;
            mostrar();
        }

        private void mostrar()
        {
            // Console.Beep();
            int dia = 24 * (int)Math.Pow(60, 2); // 24*3600 
            if (contador < 0) contador += dia;
            if (contador >= dia) contador -= dia;
            label1.Text = TimeSpan.FromSeconds(contador).ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            mostrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void Acerta_Relogio(object sender, MouseEventArgs e)
        {
            int valor = 1;
            if (((Button)sender).Name == "minutos") valor = 60;
            if (((Button)sender).Name == "horas") valor = 3600;
            if (e.Button == MouseButtons.Left) contador += valor;
            if (e.Button == MouseButtons.Right) contador -= valor;
            mostrar();
        }
    }
}
