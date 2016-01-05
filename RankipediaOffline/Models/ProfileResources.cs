namespace RankipediaOffline.Models
{
    public class ProfileResources
    {
        public string ProfileBriefText { get; set; }
        public string AboutText { get; set; }
        public string BusinessDetailText { get; set; }
        public string PortfolioText { get; set; }
        public string SpecialOffersText { get; set; }
        public string ReviewsText { get; set; }
        public string TestimonialsText { get; set; }
        public string RankipediaShieldText { get; set; }
        public string UpgradeNowText { get; set; }
        public string ContactText { get; set; }

        public ProfileResources()
        {
            ProfileBriefText = "Profile Brief";
            AboutText = "About";
            BusinessDetailText = "Business Detail";
            PortfolioText = "Portfolio";
            SpecialOffersText = "SpecialOffers";
            ReviewsText = "Reviews";
            TestimonialsText = "Testimonials";
            RankipediaShieldText = "Rankipedia Shield";
            UpgradeNowText = "Upgrade Now";
            ContactText = "Contact";
        }
    }
}