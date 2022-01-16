// See https://aka.ms/new-console-template for more information
using HelperLibrary;

#if Dotnet6
Greet.SayHello();
#else
namespace ConsoleApplicationTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Greet.SayHello();
        }
    }
}
#endif