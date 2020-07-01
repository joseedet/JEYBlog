
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;



namespace JEYBlog.Data.FileManager
{
   
        public interface IFileManager
        {
            FileStream imageStream(string image);
            string SaveImage(IFormFile file);
            bool RemoveImage(string image);


        }
    
}
