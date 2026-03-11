using System.Xml.Linq;

namespace l13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            Visitor v = new Visitor(name);

            label2.Text += v.PrintInfo() + ", ";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Всего: " + Visitor.totalVisitors;
        }
    }
}
