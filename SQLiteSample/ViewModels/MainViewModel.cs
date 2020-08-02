using BasicMvvm;
using BasicMvvm.Commands;
using DataAccessLayer.Abstraction;
using DataAccessLayer.Models;
using SQLiteSample.DataServices;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SQLiteSample.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private IDataLayerService _dataLayerService;
        private ObservableCollection<Post> _postCollection;
        private Post _selectedPost;
        public ICommand AddCommand => new DelegateCommand(OnAddCommandExecuted);
        public ICommand ResetCommand => new DelegateCommand(OnResetCommandExecuted);
        public MainViewModel(IDataLayerService dataLayerService)
        {
            _dataLayerService = dataLayerService;
            LoadAllPosts();
        }

        private void LoadAllPosts()
        {
            PostCollection = new ObservableCollection<Post>(_dataLayerService.GetAllPost());

        }

        public ObservableCollection<Post> PostCollection
        {
            get { return _postCollection; }
            set
            {
                _postCollection = value;
                OnPropertyChanged();
            }
        }
        public Post SelectedPost
        {
            get { return _selectedPost; }
            set
            {
                _selectedPost = value;
                if (value != null)
                {
                    GetCurrentPage().Frame.Navigate(typeof(PostPage), value);
                }
                OnPropertyChanged();
            }
        }
        private void OnAddCommandExecuted()
        {
            GetCurrentPage().Frame.Navigate(typeof(AddPostPage));
        }

        private void OnResetCommandExecuted()
        {
            SQLiteDataService.InitializeDatabase();
            LoadAllPosts();
        }
        private Page GetCurrentPage()
        {
            var frame = (Frame)Window.Current.Content;
            return (Page)frame.Content;
        }
    }
}
