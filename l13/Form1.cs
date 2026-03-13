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
            Visitor v1 = new Visitor("Анна");
            Visitor v2 = new Visitor("Борис");
            Visitor v3 = new Visitor("Виктор");

            label2.Text += v1.PrintInfo() + ", " + v2.PrintInfo() + ", " + v3.PrintInfo();

            label3.Text = "Всего: " + Visitor.ShowTotalVisitors();
        }
    }
}
