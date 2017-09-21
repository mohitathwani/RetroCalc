using Xamarin.Forms;

namespace RetroCalc
{
    public partial class RetroCalcPage : ContentPage
    {
        public RetroCalcPage()
        {
            InitializeComponent();
            mainBanckgroundImage.Source = ImageSource.FromResource("RetroCalc.Images.space-bg.png");
            backPanelImage.Source = ImageSource.FromResource("RetroCalc.Images.ground.png");
        }
    }
}
