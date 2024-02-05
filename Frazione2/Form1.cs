namespace Frazione2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Fraction f;
            Fraction.TryParse(txt1.Text, out f);
            if (f != null)
            {
                listBox1.Items.Add(f);
            }
            txt1.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Fraction f1= new Fraction(0,1);
            foreach (Fraction item in listBox1.Items)
            {
                f1=f1.Somma(item);
            }
            label1.Text = f1.ToString();
        }

    }
}
