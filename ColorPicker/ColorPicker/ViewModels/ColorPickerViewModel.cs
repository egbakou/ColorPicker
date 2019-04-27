using ColorPicker.PopupPages;
using Xamarin.Forms;

namespace ColorPicker.ViewModels
{
    public class ColorPickerViewModel : BaseViewModel
    {
        public ColorPickerViewModel()
        {
            Title = "Custom ColorPicker";
            RegisterMessages();
        }

        // Get the selected color from PopupPage using MessagingCenter
        private void RegisterMessages()
        {
            MessagingCenter.Subscribe<ColorSelectionPopupViewModel>(this, "_categoryColor", (s) =>
            {
                if (s != null)
                {
                    CategoryBackgroundColor = s.SelectedColor?.HexValue;
                }
            });
        }


        private string _categoryBackgroundColor = "#2196F3";
        public string CategoryBackgroundColor
        {
            get { return _categoryBackgroundColor; }
            set { SetProperty(ref _categoryBackgroundColor, value); }
        }
    }
}
