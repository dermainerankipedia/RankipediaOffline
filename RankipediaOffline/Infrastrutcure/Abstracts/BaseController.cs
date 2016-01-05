using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using RankipediaOffline.Infrastrutcure.ActionResults;

namespace RankipediaOffline.Infrastrutcure.Abstracts
{
    public abstract class BaseController: Controller
    {

        #region Properties
        //public int MemberId
        //{
        //    get { return Request.GetOwinContext().Authentication.User.Identity.GetUserIdInt(); }
        //}

        //public int MemberType
        //{
        //    get { return Request.GetOwinContext().Authentication.User.Identity.GetMemberType(); }
        //}

        //public int OwnerType
        //{
        //    get { return Request.GetOwinContext().Authentication.User.Identity.GetOwnerType(); }
        //}

        #endregion

        #region Members
        protected ActionResult RedirectToAction<TController>(Expression<Action<TController>> action)
            where TController : Controller
        {
            return null;
        }

        [Obsolete("Do not use the standard Json helper to return JSON data to the client. User either JSonError or JsonSuccess")]
        protected JsonResult Json<T>(T data)
        {
            throw new InvalidOperationException("Do not use the standard Json helper to return JSON data to the client.");
        }

        /// <summary>
        /// Copies errors from model errors into a <see cref="StandardJsonResult"/> and return the result.
        /// </summary>
        /// <returns></returns>
        protected StandardJsonResult JsonValidationError()
        {
            var result = new StandardJsonResult();
            foreach (var validationError in ModelState.Values.SelectMany(v => v.Errors))
            {
                result.AddError(validationError.ErrorMessage);
            }

            return result;
        }

        /// <summary>
        /// retturns a <see cref="StandardJsonResult"/> with error message
        /// </summary>
        /// <returns></returns>
        protected StandardJsonResult JSonError(string error)
        {
            var result = new StandardJsonResult();
            result.AddError(error);
            return result;
        }

        /// <summary>
        /// retturns a <see cref="StandardJsonResult"/> with data;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        protected StandardJsonResult<T> JsonSuccess<T>(T data)
        {
            return new StandardJsonResult<T>() {Data = data};
        }
        #endregion

    }
}