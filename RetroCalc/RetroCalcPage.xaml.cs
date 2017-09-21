using System.Diagnostics;
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
            counterImage.Source = ImageSource.FromResource("RetroCalc.Images.counter.png");
            backpanelImage.Source = ImageSource.FromResource("RetroCalc.Images.backpanel.png");
            //seven.Image = new FileImageSource { File = "Images/7.png" };
        }
    }
}
