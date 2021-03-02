using DatingAPI.DTOS;
using DatingAPI.Entities;
using DatingAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Data
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly DataContext context;

        public PhotoRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Photo> GetPhotoById(int id)
        {
            return await context.Photos
                .IgnoreQueryFilters()
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<PhotoForApprovalDTO>> GetUnapprovedPhotos()
        {
            return await context.Photos
                 .IgnoreQueryFilters()
                 .Where(p => p.IsApproved == false)
                 .Select(u => new PhotoForApprovalDTO
                 {
                     Id = u.Id,
                     IsApproved = u.IsApproved,
                     Url = u.Url,
                     Username = u.AppUser.UserName
                 }).ToListAsync();
        }

        public void RemovePhoto(Photo photo)
        {
            context.Remove(photo);
        }
    }
}
