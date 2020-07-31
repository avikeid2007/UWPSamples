using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataAccessLayer.Models
{
    public partial class Post : INotifyPropertyChanged
    {
        private int _id;
        private string _title;
        private string _content;
        private string _authorName;
        private DateTime _publishDate;
        private string _picture;
#if SQLite
[PrimaryKey, AutoIncrement]
#endif
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Content
        {
            get { return _content; }
            set
            {
                if (_content != value)
                {
                    _content = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string AuthorName
        {
            get { return _authorName; }
            set
            {
                if (_authorName != value)
                {
                    _authorName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public DateTime PublishDate
        {
            get { return _publishDate; }
            set
            {
                if (_publishDate != value)
                {
                    _publishDate = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Picture
        {
            get { return _picture; }
            set
            {
                if (_picture != value)
                {
                    _picture = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
