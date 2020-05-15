using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColoresCambio
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

        private void ChangeColor(object sender, EventArgs e)
        {
            var red = redSlider.Value;
            var green = GreenSlider.Value;
            var blue = BlueSlider .Value;

            Color bgcolor = new Color(red,green,blue);

            boxColor.BackgroundColor = bgcolor;

            lblVH.Text = Colorhexa(bgcolor);//le estoy asignando un metodo
        }

        private string Colorhexa(Color bgcolor)
        {
            int red = (int)(bgcolor.R * 255);
            int green = (int)(bgcolor.G * 255);
            int blue = (int)(bgcolor.B * 255);
            int alpha = (int)(bgcolor.A * 255);
            return $"#{red:X2}{green:X2}{blue:X2}{alpha:X2}";
        }
    }
}
