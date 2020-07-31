using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Abstraction
{
    public interface IDataLayerService
    {
        void CreateDatabase();
        IEnumerable<Post> GetAllPost();
        void SavePost(Post post);
        Post GetPost(int Id);
        void DeletePost(Post post);
    }
}
