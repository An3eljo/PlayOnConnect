using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using E.Deezer;
using PlayOnConnect.Droid;
using Xamarin.Forms;

namespace PlayOnConnect
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
		    InitializeComponent();
		}

	    private void WebView_OnNavigating(object sender, WebNavigatingEventArgs e)
	    {
	        if (e.Url.Contains("http://fsgfiewsgidgisgdhgodgsohdogugdhsodgdenchiuehwiugiushdgusdghoudgouewioughosough.com"))
	        {
	            var code = e.Url.Split('?')[1].Replace("code=", "");

                var client = new HttpClient();
	            var token = client
	                .GetStringAsync(
	                    "https://connect.deezer.com/oauth/access_token.php?app_id=281382&secret=6f28a656c988817cdd03b8781c5f8d1b&code=" +
	                    code).Result.Split('&')[0].Split('=')[1];

	            Data.Instance.Deezer.Login(token);
	            var g = Data.Instance.Deezer.Search.Tracks("Mit dä homies").Result;
	            var f = Data.Instance.Deezer.IsAuthenticated;
	            var t = Data.Instance.Deezer.Browse.CurrentUser.User;
	            e.Cancel = true;
	            GridAuth.IsVisible = false;
	            //var flow = Data.Instance.Deezer.Browse.CurrentUser.User.GetFlow();
	        }
        }

	    private void OnWlanConnection(object sender, EventArgs e)
	    {
	        var view = new WebView();
	        view.Navigating += WebView_OnNavigating;
	        view.Source = "https://connect.deezer.com/oauth/auth.php?" +
	                      "app_id = 281382 & amp; redirect_uri = http://fsgfiewsgidgisgdhgodgsohdogugdhsodgdenchiuehwiugiushdgusdghoudgouewioughosough.com&amp;" +
	                      "perms = basic_access,email,offline_access,manage_library,manage_community,delete_library," +
	                      "listening_history";


	    }

	    private void ButtonPlay_OnClicked(object sender, EventArgs e)
	    {
	        
	    }

	    private void ButtonPause_OnClicked(object sender, EventArgs e)
	    {
	        
	    }
	}
}
