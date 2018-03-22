using System.ComponentModel.DataAnnotations;

namespace FitTv.ViewModels
{
    public class YoutubeUrl : ValidationAttribute
    {
        
        public override bool IsValid(object value)
        {
            var url = value.ToString();
            var isValid = url.StartsWith("https://www.youtube.com/");
            return (isValid);
        }

        
    }
}