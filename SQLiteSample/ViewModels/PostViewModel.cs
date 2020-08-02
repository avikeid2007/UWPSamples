using BasicMvvm;
using BasicMvvm.Commands;
using DataAccessLayer.Abstraction;
using DataAccessLayer.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SQLiteSample.ViewModels
{
    public class PostViewModel : BindableBase
    {
        private IDataLayerService _dataLayerService;
        private Post _selectedPost;
        public ICommand DeleteCommand => new AsyncCommand(OnDeleteCommandExecutedAsync);
        public ICommand CancelCommand => new DelegateCommand(OnCancelCommandExecuted);

        public PostViewModel(IDataLayerService dataLayerService)
        {
            _dataLayerService = dataLayerService;
            //SelectedPost = new Post();
        }
        private async Task OnDeleteCommandExecutedAsync()
        {
            if (SelectedPost != null)
            {
                _dataLayerService.DeletePost(SelectedPost);
                GetCurrentPage().Frame.Navigate(typeof(MainPage));
            }
            else
            {
                await new MessageDialog("Please select the post", "Sqlite Sample").ShowAsync();
            }
        }
        private void OnCancelCommandExecuted()
        {
            GetCurrentPage().Frame.Navigate(typeof(MainPage));
        }
        public void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Post post)
            {
                SelectedPost = post;
            }
        }
        public void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
        }
        public Post SelectedPost
        {
            get { return _selectedPost; }
            set
            {
                _selectedPost = value;
                OnPropertyChanged();
            }
        }

        private Page GetCurrentPage()
        {
            var frame = (Frame)Window.Current.Content;
            return (Page)frame.Content;
        }



    }
}
