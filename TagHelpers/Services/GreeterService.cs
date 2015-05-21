namespace TagHelpers.Services
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

        public string RiggedGreet(int no)
        {
            return "no " + no;
        }

        public string GreetName(string name)
        {
            return "Hello " + name + " from the Greeter tag!";
        }

    }
}
