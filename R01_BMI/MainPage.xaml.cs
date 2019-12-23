using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e){
            string s1 = tBox1.Text;
            string s2 = tBox2.Text;
            float height = float.Parse(s1);
            float weight = float.Parse(s2);
            float result = (weight/(height*height)) * 10000;
            // double bmi = (double.Parse(s2)/(double.Parse(s1)*(double.Parse(s1));
            lbl.Text = "BMIは"+result+"です。"; 
        }
    }
}
