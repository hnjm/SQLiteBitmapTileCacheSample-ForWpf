using System.Windows;
using ThinkGeo.MapSuite;
using ThinkGeo.MapSuite.Layers;
using ThinkGeo.MapSuite.Shapes;
using ThinkGeo.MapSuite.Wpf;

namespace SQLiteBitmapTileCacheSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void map_Loaded(object sender, RoutedEventArgs e)
        {
            map.MapUnit = GeographyUnit.Meter;
            map.ZoomLevelSet = new ThinkGeoCloudMapsZoomLevelSet();

            /*===========================================
               Backgrounds for this sample are powered by ThinkGeo Cloud Maps and require
               a Client ID and Secret. These were sent to you via email when you signed up
               with ThinkGeo, or you can register now at https://cloud.thinkgeo.com.
            ===========================================*/
            ThinkGeoCloudRasterMapsOverlay baseOverlay = new ThinkGeoCloudRasterMapsOverlay();
            baseOverlay.TileCache = new SQLiteBitmapTileCache();
            map.Overlays.Add(baseOverlay);

            map.CurrentExtent = new RectangleShape(-20037508.3427891, 20037508.2314698, 20037508.3427891, -20037508.2314698);
            map.Refresh();
        }
    }
}
