using ColorPicker.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ColorPicker.PopupPages
{
    public class ColorSelectionPopupViewModel: BaseViewModel
    {
        private ObservableCollection<ColorExtended> _categoriesColors;
        public ObservableCollection<ColorExtended> CategoriesColors
        {
            get { return _categoriesColors; }
            set { SetProperty(ref _categoriesColors, value); }
        }

        private ColorExtended _selectedColor;
        public ColorExtended SelectedColor
        {
            get { return _selectedColor; }
            set { SetProperty(ref _selectedColor, value); }
        }

        public ICommand ColorTappedCommand { get; set; }


        public ColorSelectionPopupViewModel()
        {
            InitColor();
            ColorTappedCommand = new Command(() => ColorTapped());
            SelectedColor = null;
        }


        private void ColorTapped()
        {
            if (SelectedColor == null) return;
            CategoriesColors.ForEach(i => i.Selected = (i.HexValue == SelectedColor.HexValue));
        }


        public void InitColor()
        {

            CategoriesColors = new ObservableCollection<ColorExtended>
            {
                new ColorExtended { HexValue = "#FFB900" },
                new ColorExtended { HexValue = "#F7630C" },
                new ColorExtended { HexValue = "#DA3B01" },
                new ColorExtended { HexValue = "#E3008C" },
                new ColorExtended { HexValue = "#9A0089" },
                new ColorExtended { HexValue = "#881798" },
                new ColorExtended { HexValue = "#0063B1" },
                new ColorExtended { HexValue = "#0078D7" },
                new ColorExtended { HexValue = "#498205" },

                new ColorExtended { HexValue = "#107C10" },
                new ColorExtended { HexValue = "#4C4A48" },
                new ColorExtended { HexValue = "#4A5459" },
                new ColorExtended { HexValue = "#525E54" },
                new ColorExtended { HexValue = "#847545" },
                new ColorExtended { HexValue = "#724F2F" },

                new ColorExtended { HexValue = "#A21025" },
                new ColorExtended { HexValue = "#193E91" },
                new ColorExtended { HexValue = "#54A81B" },

                new ColorExtended { HexValue = "#EA005E" },
                new ColorExtended { HexValue = "#00B7C3" },
                new ColorExtended { HexValue = "#E74856" },

                new ColorExtended { HexValue = "#525ABB" },
                new ColorExtended { HexValue = "#00CCFF" },
                new ColorExtended { HexValue = "#333366" },
                new ColorExtended { HexValue = "#6666FF" },
                new ColorExtended { HexValue = "#7298A5" },
                new ColorExtended { HexValue = "#1C2641" },
            };

        }
    }



    public class ColorExtended : BaseViewModel
    {
        private string _hexValue;
        public string HexValue
        {
            get { return _hexValue; }
            set { SetProperty(ref _hexValue, value); }
        }


        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
