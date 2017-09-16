using Xamarin.Forms;
using Xamarin.Media;

[assembly: Dependency(typeof(XFTakeAPic.iOS.PicureTaker))]

namespace XFTakeAPic.iOS
{
    public class PicureTaker : IPictureTaker
    {
        public async void SnapPic()
        {
            var picker = new MediaPicker();
            var mediafile = await picker.PickPhotoAsync();

            System.Diagnostics.Debug.WriteLine(mediafile.Path);
        }
    }
}
