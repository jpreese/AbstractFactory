using System.IO;
using System.Reflection;

namespace WordProcessing
{
  public class Client
  { 
    public static void Main(string[] args)
    {
      using (var file = new StreamReader("config.txt"))
      {
        string factoryName;
        while ((factoryName = file.ReadLine()) != null)
        {
          var factory = LoadFactory(factoryName);
          RunTest(factory);
        }
      }
    }

    private static void RunTest(IControlFactory factory)
    {
      IControl button = factory.CreateButton();
      IControl panel = factory.CreatePanel();
      IControl textbox = factory.CreateTextBox();

      button.PrintType();
      panel.PrintType();
      textbox.PrintType();
    }

    private static IControlFactory LoadFactory(string factoryName)
    {
      var factoryAssemblyName = GetFactoryAssemblyName(factoryName);
      var factoryType = Assembly.GetExecutingAssembly().GetType(factoryAssemblyName);
      var factoryInitializer = factoryType.GetMethod("CreateInstance");

      return factoryInitializer.Invoke(null, null) as IControlFactory;
    }

    private static string GetFactoryAssemblyName(string factoryName)
    {
      return string.Format("{0}.{1}.{2}", "WordProcessing", factoryName, string.Concat(factoryName, "ControlFactory"));
    }
  }
}
