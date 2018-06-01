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
            map.MapUnit = GeographyUnit.DecimalDegree;

            WorldStreetsAndImageryOverlay layerOverlay = new WorldStreetsAndImageryOverlay();
            layerOverlay.TileCache = new SQLiteBitmapTileCache();
            map.Overlays.Add(layerOverlay);

            map.CurrentExtent = new RectangleShape(-180, 180, 180, -180);
            map.Refresh();
        }
    }
}
