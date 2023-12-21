using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PractikWork23
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OkButton_Clicked(object sender, EventArgs e)
        {
            AnswerEntry.Text = "";
            double x, y;
            if(!double.TryParse(OXEntry.Text, out x))
            {
                OXEntry.Text += "Введите число";
            }
            if (!double.TryParse(OYEntry.Text, out y))
            {
                OYEntry.Text += "Введите число";
            }

            AnswerEntry.Text += y < 23 && x < 0 && y > -x ? "ДА" : "НЕТ";
           
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            OXEntry.Text = "";
            OYEntry.Text = "";
            AnswerEntry.Text = "";
        }

    }
}
