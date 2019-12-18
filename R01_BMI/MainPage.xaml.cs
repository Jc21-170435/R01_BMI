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
            string s1 = tBox.Text1;
            string s2 = tBox.Text2;
            int a = int.Parse(s1)/100;
            int b = int.Parse(s2)/(a*a);
            lbl.Text = "BMIは"+b+"です。"; 
        }
    }
}
