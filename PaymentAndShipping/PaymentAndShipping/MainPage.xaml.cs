using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaymentAndShipping
{
	public partial class MainPage : ContentPage
	{
	    public List<Product> tempdata;

        public MainPage()
		{
			InitializeComponent();
		    Step1Layout.IsVisible = true;
		    Step3Layout.IsVisible = false;
		    Step2Layout.IsVisible = false;
	        data();
	        ListProducts.ItemsSource = tempdata;

	    }
	    void data()
	    {

	        tempdata = new List<Product>
	        {
	            new Product
	            {Id=1,
	                Designation = "BROWNIE HIP SUNGLASSES",
	                Status = "Almost New",
	                Price = "770.00 SAR",
	                Image = "img1.png"
	            },
	            new Product
	            {Id=2,
	                Designation = "BROWNIE GLASSES HOLDER",
	                Status = "Acceptable",
	                Price = "2200 SAR",
	                Image = "img2.png"
	            },
	            new Product
	            {Id=3,
	                Designation = "HANDBAG NATURAL LEATHER",
	                Status = "New",
	                Price = "770.00 SAR",
	                Image = "img3.png"
	            }
	        };
	    }
    
	    private void Button_OnBackStep3Clicked(object sender, EventArgs e)
	    {
	        Step2Layout.IsVisible = true;
	        Step3Layout.IsVisible = false;
	        Step1Layout.IsVisible = false;
	    }
	    private void Button_OnNextStep3Clicked(object sender, EventArgs e)
	    {

	    }
	    private void Button_OnBackStep2Clicked(object sender, EventArgs e)
	    {
	        Step2Layout.IsVisible = false;
	        Step3Layout.IsVisible = false;
	        Step1Layout.IsVisible = true;
	    }
	    private void Button_OnNextStep2Clicked(object sender, EventArgs e)
	    {
	        Step2Layout.IsVisible = false;
	        Step3Layout.IsVisible = true;
	        Step1Layout.IsVisible = false;
	    }
	    private void Button_OnBackStep1Clicked(object sender, EventArgs e)
	    {
	    }
	    private void Button_OnNextStep1Clicked(object sender, EventArgs e)
	    {
	        Step2Layout.IsVisible = true;
	        Step3Layout.IsVisible = false;
	        Step1Layout.IsVisible = false;
	    }

	    private void TapGestureRecognizer_OnCreditCardTapped(object sender, EventArgs e)
	    {
	        CreditCardFrame.BackgroundColor=Color.Black;
	        BankTransferFrame.BackgroundColor = Color.Gainsboro;
	    }
	    private void TapGestureRecognizer_OnBankTransferTapped(object sender, EventArgs e)
	    {
	        CreditCardFrame.BackgroundColor =Color.Gainsboro;
	        BankTransferFrame.BackgroundColor =  Color.Black;
	    }

	    private void TapGestureRecognizer_OnExpressShippingTapped(object sender, EventArgs e)
	    {
	       ExpressShippingFrame.BackgroundColor = Color.Black;
	        NormalShippingFrame.BackgroundColor =  Color.Gainsboro;
	    }
	    private void TapGestureRecognizer_OnNormalShippingTapped(object sender, EventArgs e)
	    {
	        ExpressShippingFrame.BackgroundColor = Color.Gainsboro;
	        NormalShippingFrame.BackgroundColor = Color.Black;
	    }
        



    }
}
