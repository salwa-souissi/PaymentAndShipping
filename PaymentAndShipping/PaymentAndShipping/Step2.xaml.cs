using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaymentAndShipping
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Step2 : ContentPage
	{
		public Step2 ()
		{
			InitializeComponent ();
		}

        private void Button_OnBackStep2Clicked(object sender, EventArgs e)
        {
            //    Step2Layout.IsVisible = false;
            //    Step3Layout.IsVisible = false;
            //    Step1Layout.IsVisible = true;
             }
            private void Button_OnNextStep2Clicked(object sender, EventArgs e)
            {
            //    Step2Layout.IsVisible = false;
            //    Step3Layout.IsVisible = true;
            //    Step1Layout.IsVisible = false;
            }
        }
}