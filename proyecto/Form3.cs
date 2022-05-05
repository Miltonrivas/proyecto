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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 atras1 = new Form1();
            atras1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrar);
        }
        private void cerrar(object sender, EventArgs e)
        {
            this.Hide();
            Form1 regreso = new Form1();
            regreso.Show();

        }


    }
}
