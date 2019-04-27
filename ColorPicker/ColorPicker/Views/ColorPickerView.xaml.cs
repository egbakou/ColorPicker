using ColorPicker.PopupPages;
using ColorPicker.ViewModels;
using Rg.Plugins.Popup.Extensions;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorPicker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorPickerView : ContentPage
    {
        private ColorPickerViewModel viewModel;

        public ColorPickerView()
        {
            InitializeComponent();
            BindingContext = viewModel = new ColorPickerViewModel();
        }

        private async void ShowColorsPopup(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new ColorSelectionPopupView());
        }
    }
}