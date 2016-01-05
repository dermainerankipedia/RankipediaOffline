using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace RankipediaOffline.Infrastrutcure.ActionResults
{
    /// <summary>
    /// Standardized Json result class for sending information to the client.
    /// </summary>
    public class StandardJsonResult: JsonResult
    {
        #region Property
        public List<string> ErrorMessages { get; private set; }
        #endregion

        #region Ctor

        public StandardJsonResult()
        {
            ErrorMessages = new List<string>();
        }

        #endregion


        #region Overide Members

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (JsonRequestBehavior == JsonRequestBehavior.DenyGet &&
                String.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("Get access is not allowed");
            }

            HttpResponseBase response = context.HttpContext.Response;

            response.ContentType = !String.IsNullOrEmpty(ContentType) ? ContentType : "application/json";
            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            SerializeData(response);
        }


        #endregion


        #region Public Members

        public void AddError(string errorMessage)
        {
            ErrorMessages.Add(errorMessage);
        }

        #endregion


        #region Private Members
        /// <summary>
        /// Serialize response to send to the client. Method is overrideable
        /// </summary>
        /// <param name="response"></param>
        protected virtual void SerializeData(HttpResponseBase response)
        {
            if (ErrorMessages.Any())
            {
                var orignalData = Data;
                Data = new
                {
                    Success = false,
                    OriginalData = orignalData,
                    ErrorMessage = string.Join("\n", ErrorMessages),
                    ErrorMessages = ErrorMessages.ToArray()
                };

                response.StatusCode = 400;
            }

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new JsonConverter[]
                {
                    new StringEnumConverter(),
                }

            };

            response.Write(JsonConvert.SerializeObject(Data,settings));
        }

        #endregion
    }

    /// <summary>
    /// Strong typed standard Jsonresult.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StandardJsonResult<T> : StandardJsonResult
    {
        public new T Data
        {
            get { return (T) base.Data; }
            set { base.Data = value; }
        }
    }
}