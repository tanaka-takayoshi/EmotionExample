using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.HomeViewModels
{
    public class ResultViewModel
    {
        [Required]
        [Url]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        [Display(Name = "Anger(怒り)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Anger { get; set; }
        [Display(Name = "Contempt(軽蔑)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Contempt { get; set; }
        [Display(Name = "Disgust(ムカつき)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Disgust { get; set; }
        [Display(Name = "Fear(恐れ)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Fear { get; set; }
        [Display(Name = "Happiness(喜び)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Happiness { get; set; }
        [Display(Name = "Neutral(無表情)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Neutral { get; set; }
        [Display(Name = "Sadness(悲しみ)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Sadness { get; set; }
        [Display(Name = "Surprise(驚き)")]
        [DisplayFormat(DataFormatString = "{0:0.000000}")]
        public double Surprise { get; set; }
    }
}
