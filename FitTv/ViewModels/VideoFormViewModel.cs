using FitTv.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitTv.ViewModels
{
    public class VideoFormViewModel
    {
        public int Id { get; set; }


        public IEnumerable<VideoType> Types { get; set; }

        [Required]
        public byte Type { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [YoutubeUrl]
        public string Url { get; set; }


        public string UrlForDb
        {
            get { return Url.Substring(32); }
        }

        
    }
}