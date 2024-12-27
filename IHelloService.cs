namespace Codelearn.Services.AuthAPI
{
    public interface IHelloService
    {
        string SayHello(String name);
    }

    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
