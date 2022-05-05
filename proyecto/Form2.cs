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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
