using System.Collections.Generic;
using System.Threading.Tasks;
using MediaApp.API.Models;

namespace MediaApp.API.Data
{
    public interface IMediaRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Video> GetVideo(int id);
    }
}