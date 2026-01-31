using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPK_KSR.controller
{
    internal class CloudinaryService
    {
        Cloudinary cloudinary;
        public CloudinaryService()
        {
            Account account = new Account(
                "duztkrzr4",
                "632837856219947",
                "z6sMJkvcrMmCS0sHzg6YtD30Rj4");

            cloudinary = new Cloudinary(account);
        }

        public string UploadImage(string filepath)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filepath),
                Folder = "SIPK_KSR"
            };

            var uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult.SecureUrl.ToString();
        }
    }
}
