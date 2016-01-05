using System.Web.Mvc;
using RankipediaOffline.Models.Profile.ProfileBrief;

namespace RankipediaOffline.Models
{
    public class ProfileViewModel
    {
        public ProfileBriefViewModel ProfileBriefViewModel { get; set; }

        public ProfileViewModel(UrlHelper url)
        {
            ProfileBriefViewModel = new ProfileBriefViewModel(url);

        }
    }
}