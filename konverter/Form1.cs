namespace konverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const double ExchangeRate = 92;
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ConvertRubToEuro();
            }
            else if (radioButton2.Checked)
            {
                ConvertEuroToRub();
            }
        }
        private void ConvertRubToEuro()
        {
            if (double.TryParse(textBox1.Text, out double rubles))
            {
                double euros = rubles / ExchangeRate;
                label6.Text = euros.ToString() + "евро";
            }
            else
            {
                label6.Text = "¬ведите корректное значение в рубл€х.";
            }
        }


        private void ConvertEuroToRub()
        {
            if (double.TryParse(textBox1.Text, out double euros))
            {
                double rubles = euros * ExchangeRate;
                label6.Text = rubles.ToString() + " рублей";
            }
            else
            {
                label6.Text = "¬ведите корректное значение в евро.";
            }
        }
    }
}
