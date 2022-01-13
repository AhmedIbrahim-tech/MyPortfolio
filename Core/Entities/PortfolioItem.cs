using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }

        [Display(Name = "Picture")]
        public string ImageUrl { get; set; }
    }
}
