namespace HTTPStatusLibrary
{
    public class Class1
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
            int Code { get; init; }
            string CodeName
        }
    }
}
