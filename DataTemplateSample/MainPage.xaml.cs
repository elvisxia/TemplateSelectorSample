using DataTemplateSample.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataTemplateSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<StreamCollection> list;
        public MainPage()
        {
            this.InitializeComponent();
            list = new List<StreamCollection>
            {
                new StreamCollection(new Playlist("MyPlayList 1",1),new Track("TrackName 1")),
                new StreamCollection(new Playlist("MyPlayList 2",2),new Track("TrackName 2")),
                new StreamCollection(new Playlist("MyPlayList 2",2),null),
                new StreamCollection(new Playlist("MyPlayList 4",4),null),
                new StreamCollection(null,new Track("TrackName 5")),
                new StreamCollection(new Playlist("MyPlayList 6",6),new Track("TrackName 6")),
                new StreamCollection(new Playlist("MyPlayList 7",7),new Track("TrackName 7")),
                new StreamCollection(null,new Track("TrackName 8")),
                new StreamCollection(new Playlist("MyPlayList 9",9),new Track("TrackName 9")),
                new StreamCollection(new Playlist("MyPlayList 10",10),new Track("TrackName 10"))
            };

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            myGridView.ItemsSource = list;
        }

    }
}
