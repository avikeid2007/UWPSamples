using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Abstraction
{
    public interface IDataLayerService
    {
        IEnumerable<Post> GetAllPost();
        void SavePost(Post post);
        Post GetPost(int Id);
        void DeletePost(Post post);
    }
}
