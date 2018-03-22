using FitTv.Models;
using System.Collections.Generic;

namespace FitTv.ViewModels
{
    public class VideoViewModel
    {
        public IEnumerable<Video> Videos { get; set; }
        public string Url { get; set; }

    }
}