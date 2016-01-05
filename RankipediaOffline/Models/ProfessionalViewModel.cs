using System.Collections.Generic;
using System.Web.Mvc;
using RankipediaOffline.Models.Profile.ProfileBrief;

namespace RankipediaOffline.Models
{
    public class ProfessionalViewModel
    {
        public bool IsEditable { get; set; }
        public ProfessionalMenuViewModel MenuViewModel { get; set; }
        public ProfileResources Resources { get; set; }
        public ProfileViewModel ProfileViewModel { get; set; }
        public List<JobStatus> JobStatuses { get; set; }
        public List<ListTypeViewModel> AddressTypes { get; set; }
        public List<ListTypeViewModel> PhoneTypes { get; set; }
        public AddressViewModel DefaultAddressViewModel { get; set; }
        public PhoneViewModel DefaultPhoneViewModel { get; set; }

        public ProfessionalViewModel(UrlHelper url)
        {
            MenuViewModel = new ProfessionalMenuViewModel();
            Resources = new ProfileResources();
            ProfileViewModel = new ProfileViewModel(url);
            JobStatuses = new List<JobStatus>();
            AddressTypes = new List<ListTypeViewModel>();
            PhoneTypes = new List<ListTypeViewModel>();
            DefaultAddressViewModel = new AddressViewModel();
            DefaultPhoneViewModel = new PhoneViewModel();
            IsEditable = true;

            JobStatuses.Add(new JobStatus(1, "Individual"));
            JobStatuses.Add(new JobStatus(2, "Dental Practice"));

            AddressTypes.Add(new ListTypeViewModel(0, "Unknown"));
            AddressTypes.Add(new ListTypeViewModel(1, "Main Office"));
            AddressTypes.Add(new ListTypeViewModel(2, "Secondary Office"));
            AddressTypes.Add(new ListTypeViewModel(3, "Ship-To"));
            AddressTypes.Add(new ListTypeViewModel(4, "Home Office"));
            AddressTypes.Add(new ListTypeViewModel(5, "Residence"));
            AddressTypes.Add(new ListTypeViewModel(6, "Department"));
            AddressTypes.Add(new ListTypeViewModel(7, "Post Office Box"));
            AddressTypes.Add(new ListTypeViewModel(8, "Mail Drop"));

            PhoneTypes.Add(new ListTypeViewModel(0, "Unknown"));
            PhoneTypes.Add(new ListTypeViewModel(1, "Main Phone"));
            PhoneTypes.Add(new ListTypeViewModel(2, "Office Phone"));
            PhoneTypes.Add(new ListTypeViewModel(3, "Residence Phone"));
            PhoneTypes.Add(new ListTypeViewModel(5, "Direct Phone"));
            PhoneTypes.Add(new ListTypeViewModel(6, "Department Phone"));
            PhoneTypes.Add(new ListTypeViewModel(7, "Floor Phone"));
            PhoneTypes.Add(new ListTypeViewModel(8, "Extension"));
            PhoneTypes.Add(new ListTypeViewModel(8, "Assistant&#39;&#39;s Phone"));
            PhoneTypes.Add(new ListTypeViewModel(8, "Facsimile"));
            PhoneTypes.Add(new ListTypeViewModel(8, "Message-Only"));
        }

    }
}