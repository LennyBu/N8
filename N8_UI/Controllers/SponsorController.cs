using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using N8_UI.Models;

namespace N8_UI.Controllers
{
    public class SponsorController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        public SponsorController(IWebHostEnvironment environment)
        {
            webHostEnvironment = environment;
        }
        public async Task<IActionResult> SponsorList()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UploadPDF(/*string sponsorName*/)
        {
            var PDFUpload = new SponsorViewModel();
            //PDFUpload.sponsorName = sponsorName;
            return View(PDFUpload);
        }
        [HttpPost]
        public async Task<IActionResult> UploadPDF(SponsorViewModel PDFUpload)
        {
            if (PDFUpload.pdfTicket != null && Path.GetExtension(PDFUpload.pdfTicket.FileName) == ".pdf")
            {
                var fileName = /*PDFUpload.sponsorName.ToString()*/ "ABC-Groep" + "sponsorId" + ".pdf";
                var uploadFolder = Path.Combine(webHostEnvironment.WebRootPath,"Tickets");
                var filePath = Path.Combine(uploadFolder, fileName);
                await PDFUpload.pdfTicket.CopyToAsync(new FileStream(filePath, FileMode.Create));
            }
            return View(nameof(SponsorList));
        }
    }
}
