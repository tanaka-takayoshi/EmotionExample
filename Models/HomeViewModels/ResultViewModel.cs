using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.HomeViewModels
{
    public class ResultViewModel
    {
        [Required]
        [Url]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        [Display(Name = "怒り")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Anger { get; set; }
        [Display(Name = "軽蔑")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Contempt { get; set; }
        [Display(Name = "ムカつき")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Disgust { get; set; }
        [Display(Name = "恐れ")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Fear { get; set; }
        [Display(Name = "喜び")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Happiness { get; set; }
        [Display(Name = "無表情")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Neutral { get; set; }
        [Display(Name = "悲しみ")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Sadness { get; set; }
        [Display(Name = "驚き")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Surprise { get; set; }
    }
}