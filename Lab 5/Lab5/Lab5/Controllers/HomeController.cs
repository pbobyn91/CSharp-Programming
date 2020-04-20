using Lab5.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Lab5.Controllers
{
    public class HomeController : Controller
    {
        private PhotoDataContext _PhotoContext;

        public HomeController(PhotoDataContext context)
        {
            _PhotoContext = context;
        }

        public IActionResult Index()
        {
            return View(_PhotoContext.Photos.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(ICollection<IFormFile> files)
        {

            // get your storage accounts connection string
            var storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=boby0003lab5;AccountKey=WjpIn8Zctea9tolVBrJehJBEnxrcaqYycGRePMTGtyaJZ8afhwYPbJfM65jI14AdQNYJoIPgdxJbeWt7ZGFBdw==;EndpointSuffix=core.windows.net");

            // create an instance of the blob client
            var blobClient = storageAccount.CreateCloudBlobClient();
                
            // create a container to hold your blob (binary large object.. or something like that)
            var container = blobClient.GetContainerReference("patricksphotostorage");
            await container.CreateIfNotExistsAsync();

            // set the permissions of the container to 'blob' to make them public
            var permissions = new BlobContainerPermissions();
            permissions.PublicAccess = BlobContainerPublicAccessType.Blob;
            await container.SetPermissionsAsync(permissions);

            // for each file that may have been sent to the server from the client
            foreach (var file in files)
            {
                try
                {
                    // create the blob to hold the data
                    var blockBlob = container.GetBlockBlobReference(file.FileName);
                    if (await blockBlob.ExistsAsync())
                        await blockBlob.DeleteAsync();

                    using (var memoryStream = new MemoryStream())
                    {
                        // copy the file data into memory
                        await file.CopyToAsync(memoryStream);

                        // navigate back to the beginning of the memory stream
                        memoryStream.Position = 0;

                        // send the file to the cloud
                        await blockBlob.UploadFromStreamAsync(memoryStream);
                    }

                    // add the photo to the database if it uploaded successfully
                    var photo = new Photo();
                    photo.Url = blockBlob.Uri.AbsoluteUri;
                    photo.FileName = file.FileName;

                    _PhotoContext.Photos.Add(photo);
                    _PhotoContext.SaveChanges();
                }
                catch
                {

                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult DeleteFile(int id)
        {
            var photoToDelete = (from p in _PhotoContext.Photos where p.PhotoId == id select p).FirstOrDefault();

            _PhotoContext.Remove(photoToDelete);
            _PhotoContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
