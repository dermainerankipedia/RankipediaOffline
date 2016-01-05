namespace RankipediaOffline.Models
{
    public class ProfessionalMenuViewModel
    {

        public ProfessionalMenuViewModel()
        {
            HasProfileBriefMenu = true;
            HasAboutMenu = true;
            HasBusinessDetailMenu = true;
            HasPortfolioMenu = true;
            HasSpecialOffersMenu = true;
            HasReviewsMenu = true;
            HasTestimonialsMenu = true;
            HasContactMenu = true;
        }

        public bool HasProfileBriefMenu { get; set; }

        public bool HasAboutMenu { get; set; }

        public bool HasBusinessDetailMenu { get; set; }

        public bool HasPortfolioMenu { get; set; }

        public bool HasSpecialOffersMenu { get; set; }

        public bool HasReviewsMenu { get; set; }

        public bool HasTestimonialsMenu { get; set; }

        public bool HasContactMenu { get; set; }

    }
}