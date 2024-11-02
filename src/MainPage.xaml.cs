using LibVLCSharp.Shared;

namespace src
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            using var libvlc = new LibVLC(enableDebugLogs: true);
            using var media = new Media(libvlc, new Uri(@"C:\Users\Yan\Desktop\Music\2011 summer vibes nostalgia playlist.mp4"));
            using var mediaplayer = new LibVLCSharp.Shared.MediaPlayer(media);

            mediaplayer.Play();

            Console.ReadKey();
        }
    }

}
