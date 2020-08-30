using DataAccessLayer.DummyDataService;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExpanderSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var list = DummyData.GetDummyData().GroupBy(x => x.Category).OrderBy(x => x.Key)
                .Select(g => new { Key = g.Key, PostCollection = g.OrderBy(x => x.Title).ToList() });
            ExpenderList.ItemsSource = list;
        }
    }
}
