using FitTv.Models;
using FitTv.ViewModels;
using System.Web.Mvc;

namespace FitTv.Controllers
{
    public class PlayerController : Controller
    {
        private ApplicationDbContext _context;

        public PlayerController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Player
        public ActionResult Index(string requestedVideo)
        {
            var videos = _context.Videos;
            var viewModel = new VideoViewModel
            {
                Videos = videos,
                Url = requestedVideo
            };
            return View(viewModel);
        }
    }
}