namespace DependencyInjection.Services
{
    public class GreeterService
    {
        static int counter;

        public GreeterService()
        {
            counter = 1;
        }

        public string Greet()
        {
            return "no " + counter++;
        }
    }
}
