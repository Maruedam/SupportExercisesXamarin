using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await ShowMessage("mensaje iportante", "Al fin me ha salido", "menos mal", async () =>
            {
                await ShowMessage("OK ha sido presionado", "confirmamos que funcina, equipo", "suuuuu", null);
            });
        }
        public async Task ShowMessage(string message, string title, string buttonText, Action afterHideCallback)
        {

            await DisplayAlert(title, message, buttonText);

            afterHideCallback?.Invoke();
        }
    }
}