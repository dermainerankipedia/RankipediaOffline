using System;

namespace RankipediaOffline.Models.Profile.ProfileBrief
{
    public class PhoneViewModel :EntityViewModel, IListItemViewModel
    {
        public string PhoneNumber { get; set; }
        public bool Phonemain { get; set; }
        public int PhoneType { get; set; }
        public string PhoneTypeDescription { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool Deleted { get; set; }
        public string LeftSectionFontAwesomeIconClass { get; set; }
        public bool IsEditing { get; set; }

        public PhoneViewModel()
        {
            LeftSectionFontAwesomeIconClass = "fa-phone";
        }

        public void Format()
        {
            DisplayText = PhoneNumber;
            Description = PhoneTypeDescription;
        }
    }
}