
namespace AbstractFactory
{
    public class Program
    {
        static IGUIFactory CreateOsSpecificFactory()
        {
            // Contents of App.Config associated with this C# project
            //<?xml version="1.0" encoding="utf-8" ?>
            //<configuration>
            //  <appSettings>
            //    <!-- Uncomment either Win or OSX OS_TYPE to test -->
            //    <add key="OS_TYPE" value="Win" />
            //    <!-- <add key="OS_TYPE" value="OSX" /> -->
            //  </appSettings>
            //</configuration>

            string sysType = System.Configuration.ConfigurationManager.AppSettings["OS_TYPE"];

            if (sysType == "Win")
            {
                return new WinFactory();
            }
            else
            {
                return new OSXFactory();
            }
        }
        static void Main(string[] args)
        {
            Application application = new Application(CreateOsSpecificFactory());
            System.Console.WriteLine();
        }
    }
}
