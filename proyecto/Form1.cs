namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
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
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 dato = new Form3();
            dato.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }
        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 vinotinto = new Form4();
            vinotinto.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 credito = new Form6();
            credito.Show();
        }
    }
}