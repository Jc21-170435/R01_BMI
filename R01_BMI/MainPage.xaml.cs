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
            int a = 0;
            a = int.Parse(s2)/((int.Parse(s1)/100)*(int.Parse(s1)/100));
            lbl.Text = "BMIは"+a+"です。"; 
        }
    }
}
