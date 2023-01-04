namespace windows_calculator
{
    public partial class Form1 : Form
    {
        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }
     
        private void button14_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void n1_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            receiveNumber(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            receiveOperators(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            receiveOperators(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            receiveOperators(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            receiveOperators(sender);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            equalSoln(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CLEAR ENTRY BUTTON
            textBox_Result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON
            textBox_Result.Text = "0";
            Result_Value = 0;
            label_Show_Op.Text = " ";
        }
        void receiveOperators(Object sender)
        {
        
            Button button = (Button)sender;

            if (Result_Value != 0)
            {
                equals.PerformClick();
                Operator_Performed = button.Text;
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
            else
            {

                Operator_Performed = button.Text;
                Result_Value = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
        }
        void equalSoln(Object sender)
        {
            // EQUALS BUTTON
            switch (Operator_Performed)
            {
                case "+":
                    textBox_Result.Text = (Result_Value + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Result_Value - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (Result_Value * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (Result_Value / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
            Result_Value = Double.Parse(textBox_Result.Text);
            label_Show_Op.Text = " ";

        }
        void receiveNumber(Object sender)
        {
            // numbers button and point
            if (textBox_Result.Text == "0" || PerformedOp)
                textBox_Result.Clear();

            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }

            else
                textBox_Result.Text += button.Text;
        }

    }
}