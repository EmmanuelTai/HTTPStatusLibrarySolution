using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apis;

namespace HttpStatusLibrary
{
    internal class HTTPStatusProvider
    {
        public static HttpStatusInfo.HttpStatusDto GetOk(int code, string codeMessage) 
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };    
        }

        public static HttpStatusInfo.HttpStatusDto NoContent(int code, string codeMessage)
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };
        }




        public static HttpStatusInfo.HttpStatusDto Found(int code, string codeMessage)
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };
        }


        public static HttpStatusInfo.HttpStatusDto BadRequest(int code, string codeMessage)
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };
        }


        public static HttpStatusInfo.HttpStatusDto Forbidden(int code, string codeMessage)
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };
        }

        public static HttpStatusInfo.HttpStatusDto NotFound(int code, string codeMessage)
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };
        }


        public static HttpStatusInfo.HttpStatusDto BadGateway(int code, string codeMessage)
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };
        }



        public static HttpStatusInfo.HttpStatusDto GatewayTimeout(int code, string codeMessage)
        {
            return new HttpStatusInfo.HttpStatusDto
            {
                Code = code,
                CodeName = codeMessage


            };
        }






    }

}
