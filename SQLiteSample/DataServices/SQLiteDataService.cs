using DataAccessLayer.Abstraction;
using DataAccessLayer.DummyDataService;
using DataAccessLayer.Models;
using SQLite;
using System.Collections.Generic;
using System.IO;
using Windows.Storage;

namespace SQLiteSample.DataServices
{

    internal class SQLiteDataService : IDataLayerService
    {
        private static string dbPath = string.Empty;
        private static string DbPath
        {
            get
            {
                if (string.IsNullOrEmpty(dbPath))
                {
                    dbPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Blogdb.sqlite");
                }
                return dbPath;
            }
        }
        private static SQLiteConnection DbConnection
        {
            get
            {
                return new SQLiteConnection(new SQLiteConnectionString(DbPath));
            }
        }
        public static void InitializeDatabase()
        {
            using (var db = DbConnection)
            {
                var result = db.CreateTable<Post>();
                if (result == CreateTableResult.Created)
                {
                    DummyData.GetDummyData().ForEach(post => db.InsertOrReplace(post));
                }
            }
        }

        public void DeletePost(Post post)
        {
            using (var db = DbConnection)
            {
                db.Delete(post);
            }
        }

        public IEnumerable<Post> GetAllPost()
        {
            using (var db = DbConnection)
            {
                return db.Table<Post>().ToList();
            }
        }

        public Post GetPost(int Id)
        {
            using (var db = DbConnection)
            {
                return db.Table<Post>().FirstOrDefault(x => x.Id == Id);
            }
        }

        public void SavePost(Post post)
        {
            using (var db = DbConnection)
            {
                db.Insert(post);
            }
        }

    }
}
