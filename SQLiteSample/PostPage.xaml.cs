using SQLiteSample.DataServices;
using SQLiteSample.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SQLiteSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PostPage : Page
    {
        public PostPage()
        {
            this.InitializeComponent();
            ViewModel = new PostViewModel(new SQLiteDataService());
            this.DataContext = ViewModel;
        }
        public PostViewModel ViewModel { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (ViewModel != null)
                ViewModel.OnNavigatedTo(e);
        }
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            if (ViewModel != null)
                ViewModel.OnNavigatingFrom(e);
        }
    }
}
