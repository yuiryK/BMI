namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal weight = decimal.Parse(textBox1.Text);
            decimal height = decimal.Parse(textBox2.Text);
            decimal bmi = weight / (height * height) * 703;
            label3.Text = bmi.ToString("n2");
            if (bmi >= 18.5m && bmi <= 25)
            {
                label4.Text = "Status: optimal";
            }
            else if (bmi >= 25)
            {
                label4.Text = "Status: overweight";
            }
            else
            {
                label4.Text = "Status: underweight";
            }

        }
    }
}