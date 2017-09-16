using Xamarin.Forms;


namespace XFTakeAPic
{
    class ThePage : ContentPage
    {
        public ThePage()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(20, 40, 20, 10);
                    break;
                default:
                    Padding = new Thickness(20);
                    break;
            }

            var theButton = new Button
            {
                Text = "Take Pic"
            };

            theButton.Clicked += (sender, e) =>
            {
                // Take the picture
                var pictureTaker = DependencyService.Get<IPictureTaker>();
                pictureTaker.SnapPic();
            };

            var theImage = new Image
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { theButton, theImage }
            };

        }
    }
}
