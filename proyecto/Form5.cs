using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 atras2 = new Form4();
            atras2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string text = "Tú compra ha sido realizada con éxito, en los próximos minutos te estaría llegando la factura a tu correo electrónico";
            MessageBox.Show(text);
            string message = "¿deseas seguir navengado en el sitio? presiona *si* para continuar o *No* para salir";
            string caption = "accion finalizada";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                Form1 nice = new Form1();
                nice.Show();
            }
        }
    }
}
