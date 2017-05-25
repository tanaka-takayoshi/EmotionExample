using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.HomeViewModels
{
    public class IndexViewModel
    {
        [Required]
        [Url]
        [DataType(DataType.Url)]
        public string Url { get; set; }
    }
}