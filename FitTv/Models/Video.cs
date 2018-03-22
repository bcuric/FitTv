using System;
using System.ComponentModel.DataAnnotations;

namespace FitTv.Models
{
    public class Video
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        [Required]
        public string PublisherId { get; set; }

        public DateTime DateTime { get; set; }

        public VideoType Type { get; set; }

        [Required]
        public byte TypeId { get; set; }

        public byte[] Thumbnail { get; set; }

    }
}