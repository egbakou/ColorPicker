using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorPicker.PopupPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorSelectionPopupView : PopupPage
    {
        ColorSelectionPopupViewModel ViewModel;

        public ColorSelectionPopupView()
        {
            InitializeComponent();
            BindingContext = ViewModel = new ColorSelectionPopupViewModel();
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            if (ViewModel.SelectedColor == null)
            {
                await DisplayAlert("Erreur", "Please, youy may choose one color", "OK");
                return;
            }
            //Send a message to notify the selected Color
            MessagingCenter.Send(ViewModel, "_categoryColor");
            //close this
            await PopupNavigation.PopAsync(true);
        }
    }
}