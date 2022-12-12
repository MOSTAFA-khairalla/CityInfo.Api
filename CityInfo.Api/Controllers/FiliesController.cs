using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiliesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FiliesController( FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider;
        }

        [HttpGet("{fileid}")]
        public ActionResult GetFile(int fileid)
       {
            var PathtoFile = "MostafaKhairalla.pdf";


            if (!System.IO.File.Exists(PathtoFile))
            {
                return NotFound();
            }
            if (!_fileExtensionContentTypeProvider.TryGetContentType(PathtoFile,out var contenttype))
            {
                contenttype = "application/octet-stream";
            }
            var bytes = System.IO.File.ReadAllText(PathtoFile);

            return File(bytes,contenttype(PathtoFile),Path.GetFileName(PathtoFile));
        }
    }
}
