using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlayOnConnect
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
		    var user = E.Deezer.DeezerSession.CreateNew();
            //user.Login().RunSynchronously();
			InitializeComponent();
		}

	    private void WebView_OnNavigating(object sender, WebNavigatingEventArgs e)
	    {
	       if (e.Url.Contains("http://deezerauth.maneu.net"))
	        {
	            e.Cancel = true;
	        }
        }
	}
}
