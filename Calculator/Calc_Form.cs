using System;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Calculator : Form
    {
        public float value = 0;
        public float logical_value = 0;
        public float memory = 0;

        public bool ariph_state = false;
        public bool zero_state = true;
        public string label = null;
        public string last_ariph = null;

        public Calculator()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state | zero_state)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15)
            {
                if (ariph_state == true | zero_state == true)
                {
                    TextBox.Clear();
                    ariph_state = false;
                    zero_state = false;
                }
                TextBox.Text += "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15 != TextBox.Text.Equals("0"))
            {
                if (ariph_state)
                {
                    ariph_state = false;
                    TextBox.Clear();
                }
                TextBox.Text += "0";
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            switch (last_ariph)
            {
                case "+":
                    {
                        if (!ariph_state)
                        {
                            logical_value = Convert.ToSingle(TextBox.Text);
                            ariph_state = true;
                        }
                        value += logical_value;
                        TextBox.Text = value.ToString();
                        last_ariph = "+";
                        break;
                    }
                case "-":
                    {
                        if (ariph_state)
                        {
                            value -= logical_value;
                            TextBox.Text = value.ToString();

                        }

                        if (value == 0)
                        {
                            value = Convert.ToSingle(TextBox.Text);
                        }
                        else if (!ariph_state)
                        {
                            logical_value = Convert.ToSingle(TextBox.Text);
                            value -= logical_value;
                            TextBox.Text = value.ToString();
                        }

                        last_ariph = "-";
                        ariph_state = true;
                        break;
                    }
                case "*":
                    {
                        if (ariph_state)
                        {
                            value *= logical_value;
                            TextBox.Text = value.ToString();
                        }

                        if (value == 0)
                            value = Convert.ToSingle(TextBox.Text);
                        else if (logical_value == 0)
                        {
                            logical_value = Convert.ToSingle(TextBox.Text);
                            value *= logical_value;
                            TextBox.Text = value.ToString();
                        }

                        last_ariph = "*";
                        ariph_state = true;
                        break;
                    }
                case "/":
                    {
                        if (ariph_state)
                        {
                            value /= logical_value;
                            TextBox.Text = value.ToString();
                        }

                        if (value == 0)
                            value = Convert.ToSingle(TextBox.Text);
                        else if (logical_value == 0)
                        {
                            logical_value = Convert.ToSingle(TextBox.Text);
                            value /= logical_value;
                            TextBox.Text = value.ToString();
                        }

                        last_ariph = "/";
                        ariph_state = true;
                        break;
                    }
                default:
                    break;
            }
            TextBox.Text = value.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length - 1 >= 0)
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);

            if(TextBox.Text.EndsWith(",") | TextBox.Text.EndsWith("-"))
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);

            if (TextBox.Text == "")
            {
                TextBox.Text = "0";
                zero_state = true;
            }
        }

        private void Pls_Mns_Click(object sender, EventArgs e)
        {
            if (zero_state)
                TextBox.Clear();

            if (!TextBox.Text.Contains("-"))
            {
                TextBox.Text = "-" + TextBox.Text;
            }
            else
            {
                TextBox.Text = TextBox.Text.Substring(1, TextBox.Text.Length-1);
            }

            ariph_state = false;
            zero_state = false;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void divi_Click(object sender, EventArgs e)
        {
            if (ariph_state)
            {
                value /= logical_value;
                TextBox.Text = value.ToString();
            }

            if (value == 0)
                value = Convert.ToSingle(TextBox.Text);
            else if (logical_value == 0)
            {
                logical_value = Convert.ToSingle(TextBox.Text);
                value /= logical_value;
                TextBox.Text = value.ToString();
            }

            last_ariph = "/";
            ariph_state = true;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length < 15 != TextBox.Text.Contains(","))
            {
                TextBox.Text += ",";
                zero_state = false;
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (ariph_state)
            {
                value *= logical_value;
                TextBox.Text = value.ToString();
            }

            if (value == 0)
                value = Convert.ToSingle(TextBox.Text);
            else if(logical_value == 0)
            {
                logical_value = Convert.ToSingle(TextBox.Text);
                value *= logical_value;
                TextBox.Text = value.ToString();
            }

            last_ariph = "*";
            ariph_state = true;
        }

        private void plass_Click(object sender, EventArgs e)
        {
            if (!ariph_state)
            {
                logical_value = Convert.ToSingle(TextBox.Text);
                ariph_state = true;
            }
            value += logical_value;
            TextBox.Text = value.ToString();
            last_ariph = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (ariph_state)
            {
                value -= logical_value;
                TextBox.Text = value.ToString();

            }      
              
            if (value == 0)
            {
                value = Convert.ToSingle(TextBox.Text);
            }
            else if (!ariph_state)
                {
                    logical_value = Convert.ToSingle(TextBox.Text);
                    value -= logical_value;
                    TextBox.Text = value.ToString();
                }

            last_ariph = "-";
            ariph_state = true;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            logical_value = 0;
            value = 0;
            zero_state = true;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void prot_Click(object sender, EventArgs e)
        {
            if (last_ariph == "*")
            {
                if(!ariph_state)
                    logical_value = Convert.ToSingle(TextBox.Text) / 100;
                value *= logical_value;
                TextBox.Text = value.ToString();
                ariph_state = true;
            }
        }

        private void Mem_Pls_Click(object sender, EventArgs e)
        {
            memory += Convert.ToSingle(TextBox.Text);
            ariph_state = true;
        }

        private void Mem_Mns_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToSingle(TextBox.Text);
            ariph_state = true;
        }

        private void Mem_Cur_Click(object sender, EventArgs e)
        {
            TextBox.Text = memory.ToString();
            if (memory == 0)
                zero_state = true;
        }

        private void Mem_Clr_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void one_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
