using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VisualElement : ContentPage
	{
		public VisualElement ()
		{
			InitializeComponent ();
		}

        private void mySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //myLabel.Text = string.Format("Slider = {0}", e.NewValue);
            myLabel.Text = mySlider.Value.ToString();
        }
    }
}