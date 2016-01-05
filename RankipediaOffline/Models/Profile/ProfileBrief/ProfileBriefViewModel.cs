using System.Collections.Generic;
using System.Web.Mvc;
using RankipediaOffline.Extensions;
using RankipediaOffline.Models.Professionals;

namespace RankipediaOffline.Models.Profile.ProfileBrief
{
    public class ProfileBriefViewModel
    {
        public string MemberName { get; set; }
        public string ProfilePhoto { get; set; }
        public int JobStatus { get; set; }
        public string BusinessIsCalled { get; set; }
        public decimal YearsInPractice { get; set; }
        public int MonthStarted { get; set; }
        public int YearStarted { get; set; }
        public string Degrees { get; set; }
        public List<AddressViewModel> AddressViewModels { get; set; }
        public List<PhoneViewModel> PhoneViewModels { get; set; }
        public List<SpecialtyViewModel> SpecialtyViewModels { get; set; }


        public ProfileBriefViewModel(UrlHelper urlHelper)
        {
            AddressViewModels = new List<AddressViewModel>();
            PhoneViewModels = new List<PhoneViewModel>();
            SpecialtyViewModels = new List<SpecialtyViewModel>();
            Mock(urlHelper);
        }


        public void Mock(UrlHelper urlHelper)
        {
            MemberName = "Dermaine Peart";
            JobStatus = 0;
            BusinessIsCalled = "Dentist";
            YearsInPractice = 10;
            MonthStarted = 6;
            YearStarted = 1981;
            Degrees = "Masters of Dentistry";
            ProfilePhoto = urlHelper.StaticImage("profone.jpg");
           
            var address = new AddressViewModel
            {
                Id = 1,
                AdressType = 4,
                Address = "109 Brilia Private",
                City = "Ottawa",
                State = "Ontario",
                Country = "Canada",
                ZipCode = "K1J0B7",
                AddressTypeDescription = "Home Office"
            };

            address.Format();
            AddressViewModels.Add(address);

            address = new AddressViewModel
            {
                Id = 2,
                AdressType = 1,
                Address = "1180 Seven Seas Dr",
                City = "Lake Buena Vista",
                State = "Florida",
                Country = "Canada",
                ZipCode = "32830",
                AddressTypeDescription = "Main Office"
            };
            address.Format();
            AddressViewModels.Add(address);

            
            var phone = new PhoneViewModel
            {
                Id = 3,
                PhoneType = 1,
                PhoneNumber = "613-853-7078",
                PhoneTypeDescription = "Main Phone"
            };

            phone.Format();
            PhoneViewModels.Add(phone);

            phone = new PhoneViewModel
            {
                Id = 4,
                PhoneType = 3,
                PhoneNumber = "613-853-8562",
                PhoneTypeDescription = "Residence Phone"
            };
            phone.Format();
            PhoneViewModels.Add(phone);

            var specialtyViewModel = new SpecialtyViewModel
            {
                Id = 1,
                Name = "Dental Public Health",
                ProfessionalAreaLevel = ProfessionalAreaLevel.Specialty
            };

            SpecialtyViewModels.Add(specialtyViewModel);

            specialtyViewModel = new SpecialtyViewModel
            {
                Id = 1,
                Name = "Endodontics",
                ProfessionalAreaLevel = ProfessionalAreaLevel.Specialty
            };
            SpecialtyViewModels.Add(specialtyViewModel);

            specialtyViewModel = new SpecialtyViewModel
            {
                Id = 1,
                Name = "Oral and Maxillofacial Surgery",
                ProfessionalAreaLevel = ProfessionalAreaLevel.Specialty
            };
            SpecialtyViewModels.Add(specialtyViewModel);

            specialtyViewModel = new SpecialtyViewModel
            {
                Id = 1,
                Name = "Oral Medicine and Pathology",
                ProfessionalAreaLevel = ProfessionalAreaLevel.Specialty
            };
            SpecialtyViewModels.Add(specialtyViewModel);

            specialtyViewModel = new SpecialtyViewModel
            {
                Id = 1,
                Name = "Oral & Maxillofacial Radiology ",
                ProfessionalAreaLevel = ProfessionalAreaLevel.Specialty
            };

            SpecialtyViewModels.Add(specialtyViewModel);
        }
    }
}