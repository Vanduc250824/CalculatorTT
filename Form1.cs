namespace FormTest
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed)) 
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button  button1 = (Button) sender;
            textBox1.Text += button1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string cleanedText = textBox1.Text.Replace("\n", "").Replace("\r", "").Trim();
            switch (operation) 
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(textBox1.Text);
            operation = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || operationPressed))
            {
                textBox1.Clear();
            }
            operationPressed = false;
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;  
            value = Double.Parse(textBox1.Text);  
            operationPressed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(textBox1.Text);
            operationPressed = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(textBox1.Text);
            operationPressed = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(textBox1.Text);
            operationPressed = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
