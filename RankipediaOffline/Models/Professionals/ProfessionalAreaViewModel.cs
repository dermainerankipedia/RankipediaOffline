using System.Collections.Generic;

namespace RankipediaOffline.Models.Professionals
{
    public class ProfessionalAreaViewModel
    {
        public List<IndustryViewModel> IndustryViewModels { get; set; }

        public ProfessionalAreaViewModel()
        {
            IndustryViewModels =new List<IndustryViewModel>();
        }
    }
}