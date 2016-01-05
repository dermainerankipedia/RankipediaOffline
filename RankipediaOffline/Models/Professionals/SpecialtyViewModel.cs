using System.Collections.Generic;

namespace RankipediaOffline.Models.Professionals
{
    public class SpecialtyViewModel
    {
        public int Id { get; set; }
        public int SpecialtyId { get; set; }
        public int SubSpecialtyId { get; set; }
        public string Name { get; set; }
        public ProfessionalAreaLevel ProfessionalAreaLevel { get; set; }
    }
}