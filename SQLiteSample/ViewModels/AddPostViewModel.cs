using BasicMvvm;
using BasicMvvm.Commands;
using DataAccessLayer.Abstraction;
using DataAccessLayer.Models;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SQLiteSample.ViewModels
{
    public class AddPostViewModel : BindableBase
    {
        private IDataLayerService _dataLayerService;
        private Post _selectedPost;
        public ICommand SaveCommand => new DelegateCommand(OnSaveCommandExecuted);
        public ICommand CancelCommand => new DelegateCommand(OnCancelCommandExecuted);
        public ICommand ResetCommand => new DelegateCommand(OnResetCommandExecuted);
        public AddPostViewModel(IDataLayerService dataLayerService)
        {
            _dataLayerService = dataLayerService;
            SelectedPost = new Post();
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
        private void OnCancelCommandExecuted()
        {
            GetCurrentPage().Frame.Navigate(typeof(MainPage));
        }
        private void OnSaveCommandExecuted()
        {
            _dataLayerService.SavePost(SelectedPost);
            SelectedPost = new Post();
        }
        private void OnResetCommandExecuted()
        {
            SelectedPost = new Post();
        }
        private Page GetCurrentPage()
        {
            var frame = (Frame)Window.Current.Content;
            return (Page)frame.Content;
        }
    }
}
