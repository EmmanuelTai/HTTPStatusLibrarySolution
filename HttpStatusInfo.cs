namespace Apis

{
    public class HttpStatusInfo
    {

        public enum StatusCodesEnum
        {
            Ok = 200,
            NoContent = 204,
            Found = 302,
            BadRequest = 400,
            Forbidden = 403,
            NotFound = 404,
            BadGateway = 502,
            GatewayTimeout = 504
        }
    
    
        public record HttpStatusDto
        {
            public int Code { get; set; }
            public string CodeName { get; set; }
        }
    }
}
