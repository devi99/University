using University.DAL;
using System.Web.Mvc;

namespace University.Controllers
{
    public class FileController : Controller
    {
        private SchoolContext db = new SchoolContext();
        //
        // GET: /File/
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }

    }
}