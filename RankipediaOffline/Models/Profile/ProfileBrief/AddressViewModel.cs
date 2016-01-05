using System;

namespace RankipediaOffline.Models.Profile.ProfileBrief
{
    public class AddressViewModel : EntityViewModel, IListItemViewModel
    {
        public bool AddressMain { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Notes { get; set; }
        public int AdressType { get; set; }
        public string AddressTypeDescription { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool Deleted { get; set; }
        public string LeftSectionFontAwesomeIconClass { get; set; }
        public bool IsEditing { get; set; }

        public AddressViewModel()
        {
            LeftSectionFontAwesomeIconClass = "fa-map-marker";
        }

        public void Format()
        {
            DisplayText = string.Format("{0} {1}, {2} {3}", Address, City, State, ZipCode);
            Description = AddressTypeDescription;
        }
    }

}