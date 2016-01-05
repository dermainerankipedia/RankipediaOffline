using System.Collections.Generic;

namespace RankipediaOffline.Models.Professionals
{
    public class IndustryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SpecialtyViewModel> SpecialtyViewModels { get; set; }

        public IndustryViewModel()
        {
            SpecialtyViewModels =new List<SpecialtyViewModel>();
        }
    }
}