using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* What the request will look like
 * when uploading images we will be sending the image title,
 * image tag, and image itself.
 * 
 * */
namespace MemeBank.Models
{
    public class MemeImageItem
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public IFormFile Image { get; set; }
    }
}
