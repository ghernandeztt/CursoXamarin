using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPasswordPage : ContentPage
	{
        private Label email_Label;
        private Entry email_Entry;
        private Label code_Label;
        private Entry code_Entry;

        public ForgotPasswordPage ()
		{
			InitializeComponent ();
            email_Label = this.FindByName<Label>("emailLabel");
            email_Entry = this.FindByName<Entry>("emailEntry");
            code_Label = this.FindByName<Label>("codeLabel");
            code_Entry = this.FindByName<Entry>("codeEntry");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => {
                email_Label.IsVisible = false;
                email_Entry.IsVisible = false;
                code_Label.IsVisible = true;
                code_Entry.IsVisible = true;
            });
        }
    }
}