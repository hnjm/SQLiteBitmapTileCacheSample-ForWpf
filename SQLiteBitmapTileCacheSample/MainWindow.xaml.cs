using System.Windows;
using ThinkGeo.MapSuite;
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
            map.ZoomLevelSet = ThinkGeoCloudMapsOverlay.GetZoomLevelSet();

            ThinkGeoCloudMapsOverlay baseOverlay = new ThinkGeoCloudMapsOverlay();
            baseOverlay.TileCache = new SQLiteBitmapTileCache();
            map.Overlays.Add(baseOverlay);

            map.CurrentExtent = new RectangleShape(-20037508.3427891, 20037508.2314698, 20037508.3427891, -20037508.2314698);
            map.Refresh();
        }
    }
}
