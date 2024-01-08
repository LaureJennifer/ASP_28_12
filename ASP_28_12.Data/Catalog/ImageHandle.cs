using Microsoft.AspNetCore.Components.Forms;


namespace ASP_28_12.Application.Catalog
{
    public class ImageHandle
    {
        private readonly string _pathImageFolder;

        public ImageHandle()
        {
            _pathImageFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "image");
        }

        public async Task<string> AddImage(IBrowserFile file, string folder)
        {
            var fileSplit = file.Name.Split('.');
            var fileExtension = "." + fileSplit[fileSplit.Count() - 1];

            var fileName = Guid.NewGuid() + fileExtension;

            var stream = new FileStream(Path.Combine(_pathImageFolder, folder, fileName), FileMode.Create);
            await file.OpenReadStream(5120000).CopyToAsync(stream);
            stream.Close();

            return fileName;
        }
    }
}

