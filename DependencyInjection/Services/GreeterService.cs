namespace DependencyInjection.Services
{
    public class GreeterService
    {
        static int counter;

        public GreeterService()
        {
            counter = 5;
        }

        public string Greet()
        {
            return "no " + counter++;
        }
    }
}
