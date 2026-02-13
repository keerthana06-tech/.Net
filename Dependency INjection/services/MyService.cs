namespace Dependency_Injection.services
{
    public class MyService: IMyService
    {
        public string GetMessage()
        {
            return "Hello from MyService!";
        }
    }
}
