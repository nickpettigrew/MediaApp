using System.Collections.Generic;
using System.Threading.Tasks;
using MediaApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.API.Data
{
    public class MediaRepository : IMediaRepository
    {
        private readonly DataContext _context;
        public MediaRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            return photo;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Videos).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.Videos).ToListAsync();
            return users;
        }

        public async Task<Video> GetVideo(int id)
        {
            var video = await _context.Videos.FirstOrDefaultAsync(v => v.Id == id);
            return video;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}