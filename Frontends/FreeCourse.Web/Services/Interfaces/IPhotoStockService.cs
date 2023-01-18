using FreeCourse.Web.Models.PhotoStocks;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IPhotoStockService
    {
        Task<PhotoViewModel> UploadPhoto(FormFile photo);
        Task<bool> DeletePhoto(string photoUrl);
    }
}
