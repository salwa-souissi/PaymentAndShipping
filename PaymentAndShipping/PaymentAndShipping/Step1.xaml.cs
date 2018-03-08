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
	public partial class Step1 : ContentPage
	{
	    private double Subtotal , Shipping, Vat, Total;

	    public Step1()
	    {
	        InitializeComponent();
	        Subtotal = 9000.00;
	        Shipping = 35.00;
	        Vat = 456.00;
	        Total = Subtotal + Shipping + Vat;
	        //OutlineColor = Color.Silver,
	    }

	}
}