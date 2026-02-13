namespace interface_custom_service.service
{
    public class Service: IService
    {
        public string Getmessage(string name)
        {
            return $"hello {name}, welcome to asp.net";
        }
    }
}
