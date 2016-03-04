using System.Reflection;

namespace WordProcessing
{
  public class Client
  { 
    public static void Main(string[] args)
    {
      IControlFactory factory = LoadFactory();

      IControl button = factory.CreateButton();
      IControl panel = factory.CreatePanel();
      IControl textbox = factory.CreateTextBox();

      button.PrintType();
      panel.PrintType();
      textbox.PrintType();
    }

    private static IControlFactory LoadFactory()
    {
      string factoryName;
      using (var file = new System.IO.StreamReader("config.txt"))
      {
        factoryName = file.ReadLine();
      }

      var factoryType = Assembly.GetExecutingAssembly().GetType(factoryName);
      var factoryInitializer = factoryType.GetMethod("CreateInstance");

      return factoryInitializer.Invoke(null, null) as IControlFactory;
    }
  }
}
