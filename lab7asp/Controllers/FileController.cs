using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace lab7asp.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DownloadFile(FileModel file)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                TextWriter writer = new StreamWriter(ms);
                writer.WriteLine($"{file.Name} {file.Surname}");
                writer.Flush();
                return File(ms.GetBuffer(), "text/plain", $"{file.Filename}.txt");
            }
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
