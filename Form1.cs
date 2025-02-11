namespace ASSMT_1
{
    public partial class Form1 : Form
    {
        double appleRate = 0.2245;
        double metaRate = 0.3107;
        double teslaRate = 0.3894;
        double nvidiaRate = 0.4572;
        double googleRate = 0.2894;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Title"; // Set the form's title

            appleLabel.Text = Math.Round((appleRate*100),2).ToString() + "%";
            metaLabel.Text = Math.Round((metaRate * 100),2).ToString() + "%";
            teslaLabel.Text = Math.Round((teslaRate*100),2).ToString() + "%";
            nvidiaLabel.Text = Math.Round((nvidiaRate*100),2).ToString() + "%";
            googleLabel.Text = Math.Round((googleRate*100),2).ToString() + "%";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Menu strip setup
        private void InitializeMenu()
        {

        }

        // Load event for the form
        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialize the menu
            InitializeMenu();
        }

        private void lblShimCount_Click(object sender, EventArgs e)
        {
            principal.Text = "";
            tenure.Text = "";
            apple.Text = "";
            nvidia.Text = "";
            meta.Text = "";
            tesla.Text = "";
            google.Text = "";
            total.Text = "";
            invested.Text = "";
            profits.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            //init variables
            double principalVal = 0;
            double tenureVal = 0;
            double appleVal = 0;
            double metaVal = 0;
            double nvidiaVal = 0;
            double teslaVal = 0;
            double googleVal = 0;

            if (principal.Text.Equals(""))
            {
                ErrorMessage("Error: Principal is empty.");
            }
            else
            {
                principalVal = double.Parse(principal.Text);
                if (checkNegative(principalVal))
                {
                    ErrorMessage("Error: Principal is negative. It has been set to 0.");
                    principalVal = 0;
                    principal.Text = "0";
                }
            }

            if (tenure.Text.Equals(""))
            {
                ErrorMessage("Error: Tenure is empty.");
            }
            else
            {
                tenureVal = double.Parse(tenure.Text);
                if (checkNegative(tenureVal))
                {
                    ErrorMessage("Error: Tenure is negative. It has been set to 0.");
                    tenureVal = 0;
                    tenure.Text = "0";
                }
            }

            if (apple.Text.Equals(""))
            {
                //throw error
            }
            else
            {
                appleVal = double.Parse(apple.Text);
                if (checkNegative(appleVal))
                {
                    ErrorMessage("Error: Apple is negative. It has been set to 0.");
                    appleVal = 0;
                    apple.Text = "0";
                }
            }

            if (meta.Text.Equals(""))
            {
                //throw error
            }
            else
            {
                metaVal = double.Parse(meta.Text);
                if (checkNegative(metaVal))
                {
                    ErrorMessage("Error: Meta is negative. It has been set to 0.");
                    metaVal = 0;
                    meta.Text = "0";
                }
            }

            if (nvidia.Text.Equals(""))
            {
                //throw error
            }
            else
            {
                nvidiaVal = double.Parse(nvidia.Text);
                if (checkNegative(nvidiaVal))
                {
                    ErrorMessage("Error: Nvidia is negative. It has been set to 0.");
                    nvidiaVal = 0;
                    nvidia.Text = "0";
                }
            }

            if (tesla.Text.Equals(""))
            {
                //throw error
            }
            else
            {
                teslaVal = double.Parse(tesla.Text);
                if (checkNegative(teslaVal))
                {
                    ErrorMessage("Error: Tesla is negative. It has been set to 0.");
                    teslaVal = 0;
                    tesla.Text = "0";
                }
            }

            if (google.Text.Equals(""))
            {
                //throw error
            }
            else
            {
                googleVal = double.Parse(google.Text);
                if (checkNegative(googleVal))
                {
                    ErrorMessage("Error: Alphabet is negative. It has been set to 0.");
                    googleVal = 0;
                    google.Text = "0";
                }
            }

            double totalSpent = appleVal + metaVal + nvidiaVal + teslaVal;

            if (totalSpent > principalVal)
            {
                ErrorMessage("You can't spend more money than you have.");
            }
            else
            {
                double totalNotSpent = principalVal - totalSpent;


                double appleRateSum = 1 + appleRate;
                double metaRateSum = 1 + metaRate;
                double teslaRateSum = 1 + teslaRate;
                double nvidiaRateSum = 1 + nvidiaRate;
                double googleRateSum = 1 + googleRate;

                double appleProduct = Math.Pow(appleRateSum, tenureVal);
                double metaProduct = Math.Pow(metaRateSum, tenureVal);
                double teslaProduct = Math.Pow(teslaRateSum, tenureVal);
                double nvidiaProduct = Math.Pow(nvidiaRateSum, tenureVal);
                double googleProduct = Math.Pow(googleRateSum, tenureVal);

                double finalValueApple = appleProduct * appleVal;
                double finalValueMeta = metaProduct * metaVal;
                double finalValueTesla = teslaProduct * teslaVal;
                double finalNvidiaProduct = nvidiaProduct * nvidiaVal;
                double finalGoogleProduct = googleProduct * googleVal;

                double totalVal = finalValueApple + finalValueMeta + finalValueTesla + finalNvidiaProduct + finalGoogleProduct;
                total.Text = "$" + Math.Round(totalNotSpent + totalVal, 2).ToString();

                invested.Text = "$" + Math.Round(totalSpent, 2).ToString();

                double profitVal = totalVal - totalSpent;
                profits.Text = "$" + Math.Round(profitVal, 2).ToString();

            }

        }


        private Boolean checkNegative(double val)
        {
            if (val < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ErrorMessage(String errorMessage)
        {

            DialogResult result = MessageBox.Show(errorMessage,
                "User Error Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ratePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
