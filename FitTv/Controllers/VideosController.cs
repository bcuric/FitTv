using FitTv.Models;
using FitTv.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace FitTv.Controllers
{
    public class VideosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VideosController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var types = _context.Types.ToList();

            var viewModel = new VideoFormViewModel
            {
                Types = types

            };
            return View(viewModel);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VideoFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Types = _context.Types.ToList();
                return View("Create", viewModel);
            }

            WebClient cli = new WebClient();
            //var thumbnail = cli.DownloadData("http://img.youtube.com/vi/"+viewModel.UrlForDb.ToString()+"/2.jpg");
            var publisherId = User.Identity.GetUserId();
            var video = new Video
            {
                PublisherId= publisherId,
                Description = viewModel.Description,
                Url = viewModel.UrlForDb,
                DateTime = DateTime.Now,
                TypeId = viewModel.Type,
                
            };
            _context.Videos.Add(video);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}