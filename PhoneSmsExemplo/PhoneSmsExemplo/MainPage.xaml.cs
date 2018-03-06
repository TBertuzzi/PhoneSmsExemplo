using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhoneSmsExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnSms.Clicked += (sender, e) => {

                if (CrossMessaging.Current.SmsMessenger.CanSendSms)
                {
                   CrossMessaging.Current.SmsMessenger.SendSms("SEU NUMERO", "SENHOR JOÃO SUA DIVIDA VENCE HOJE!");
                }

            };

            btnLigar.Clicked += (sender, e) => {

                if (CrossMessaging.Current.PhoneDialer.CanMakePhoneCall)
                {
                    CrossMessaging.Current.PhoneDialer.MakePhoneCall("seu numero", "Aguinaldo Timoteo");
                }

            };
        }
	}
}
