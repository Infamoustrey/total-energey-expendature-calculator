using System; 
using System.Windows.Forms;

namespace TDEE_Calculator
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected void handleCalculateTDEE()
        {

            double bodyWeight; double.TryParse(BodyWeightInput.Text, out bodyWeight);
            double activityLevel; double.TryParse(ActivityLevelInput.Text, out activityLevel);   

            if (bodyWeight < 100 || bodyWeight > 500) { ErrorMessageLabel.Text = "Please enter a valid body weight"; return; }
 
            if ( Math.Round(activityLevel * (double) 100) % 10 != 0 || activityLevel < 1.1 || activityLevel > 1.90) {
                ErrorMessageLabel.Text = "Please enter a valid activity level"; return;
            }
            ErrorMessageLabel.Text = "";
            TDEEResult.Text = "" + bodyWeight * activityLevel * 10; 

        }

        private void BodyWeightInput_TextChanged(object sender, EventArgs e)
        {
            this.handleCalculateTDEE();
        }

        private void ActivityLevelInput_TextChanged(object sender, EventArgs e)
        {
            this.handleCalculateTDEE();
        }
    }
}
