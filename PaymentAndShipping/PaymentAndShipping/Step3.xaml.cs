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
	public partial class Step3 : ContentPage
	{
	    public List<Product> tempdata;

        public Step3 ()
		{
			InitializeComponent ();
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

	    private void TapGestureRecognizer_OnTapped(object sender,EventArgs e)
	    {
            }
	    private void Button_OnBackStep3Clicked(object sender, EventArgs e)
	    {
	    //    Step2Layout.IsVisible = true;
	    //    Step3Layout.IsVisible = false;
	    //    Step1Layout.IsVisible = false;
	    }
	    private void Button_OnNextStep3Clicked(object sender, EventArgs e)
	    {
	      
	    }
    }
	}
