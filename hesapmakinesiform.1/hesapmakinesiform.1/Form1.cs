namespace hesapmakinesiform._1
{
    public partial class Form1 : Form
    {
        private int say�1;
        private int say�2;
        private int sonu�;
        private string i�lem;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "0" || ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "0"|| ekran.Text == "+" || ekran.Text == "-" || ekran.Text == "/" || ekran.Text == "*")
            {
                ekran.Text = "";
            }
            ekran.Text += "9";

        }






        private void btnc_Click_1(object sender, EventArgs e)
        {
            ekran.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            
            ekran.Text += "0";
        }

        private void buttone�it_Click(object sender, EventArgs e)
        {
            say�2=Convert.ToInt32(ekran.Text);
            switch (i�lem)
            {
                case "+":
                    sonu� = say�1+say�2;
                    break;
                case "-":
                    sonu� = say�1-say�2;
                    
                    break;

                case "*":
                    sonu� = say�1*say�2;
                   
                    break;
                case "/":
                    sonu� = say�1/say�2;
                    
                    break;
            }
            ekran.Text = "";
            ekran.Text = Convert.ToString(sonu�);                                 
        }

        private void buttonart�_Click(object sender, EventArgs e)
        {
            say�1 = Convert.ToInt32(ekran.Text);

            ekran.Text = "";
            ekran.Text += "+";
            
            i�lem = "+";
            

        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            say�1 = Convert.ToInt32(ekran.Text);

            ekran.Text = "";
            ekran.Text += "-";
           
            i�lem = "-";
        }

        private void buttoncarp_Click(object sender, EventArgs e)
        {
            say�1 = Convert.ToInt32(ekran.Text);

            ekran.Text = "";
            ekran.Text += "*";
            
            i�lem = "*";
        }

        private void buttonb�l_Click(object sender, EventArgs e)
        {

            say�1 = Convert.ToInt32(ekran.Text);

            ekran.Text = "";
            ekran.Text += "/";
           
            i�lem = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
