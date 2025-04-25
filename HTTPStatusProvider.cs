using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apis;

namespace HttpStatusLibrary
{
    public class HTTPStatusProvider
    {
        public static HttpStatusInfo.HttpStatusDto GetOk() 
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.Ok;
            

            var httpsstatusinfo = new HttpStatusInfo.HttpStatusDto
            {
                Code = (int) statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }

        public static HttpStatusInfo.HttpStatusDto NoContent()
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.NoContent;
            var httpsstatusinfo = new HttpStatusInfo.HttpStatusDto
            {
                Code = (int)statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }




        public static HttpStatusInfo.HttpStatusDto Found()
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.Found;
            var httpsstatusinfo = new HttpStatusInfo.HttpStatusDto
            {
                Code = (int)statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }


        public static HttpStatusInfo.HttpStatusDto BadRequest()
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.BadRequest;
            var httpsstatusinfo = new HttpStatusInfo.HttpStatusDto
            {
                Code = (int)statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }


        public static HttpStatusInfo.HttpStatusDto Forbidden()
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.Forbidden;
            var httpsstatusinfo = new HttpStatusInfo.HttpStatusDto
            {
                Code = (int)statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }

        public static HttpStatusInfo.HttpStatusDto NotFound()
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.NotFound;
            var httpsstatusinfo = new HttpStatusInfo.HttpStatusDto
            {
                Code = (int)statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }


        public static HttpStatusInfo.HttpStatusDto BadGateway()
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.BadGateway;
            var httpsstatusinfo = new HttpStatusInfo.HttpStatusDto
            {
                Code = (int)statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }



        public static HttpStatusInfo.HttpStatusDto GatewayTimeout()
        {
            StatusCodesEnum statusCodesEnum = StatusCodesEnum.GatewayTimeout;
            var httpsstatusinfo =  new HttpStatusInfo.HttpStatusDto
            {
                Code = (int)statusCodesEnum,
                CodeName = statusCodesEnum.ToString(),


            };

            return httpsstatusinfo;
        }






    }

}
