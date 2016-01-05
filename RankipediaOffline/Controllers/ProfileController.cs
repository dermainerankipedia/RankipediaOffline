using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RankipediaOffline.Infrastrutcure.Abstracts;
using RankipediaOffline.Models;
using RankipediaOffline.Models.Profile.ProfileBrief;

namespace RankipediaOffline.Controllers
{
    public class ProfileController : BaseController
    {
        public static int AddressId { get; set; }

        public ActionResult Index()
        {
            return View(new ProfessionalViewModel(Url));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProfileMenu()
        {
            var menu = new ProfessionalMenuViewModel();

            return View("_profileMenu", menu);
        }

        public JsonResult CreateAddress(AddressViewModel model)
        {
            model.Format();
            model.Id = AddressId + 4;
            return JsonSuccess(model);
        }

        public JsonResult UpdateAddress(AddressViewModel model)
        {
            model.Format();
            return JsonSuccess(model);
        }

        public JsonResult DeleteAddress(int id)
        {
            return JsonSuccess(id);
        }

        public JsonResult CreatePhone(PhoneViewModel model)
        {
            model.Format();
            model.Id = AddressId + 4;
            return JsonSuccess(model);
        }

        public JsonResult UpdatePhone(PhoneViewModel model)
        {
            model.Format();
            return JsonSuccess(model);
        }

        public JsonResult DeletePhone(int id)
        {
            return JsonSuccess(id);
        }

    }
}