namespace WordProcessing.Word00
{
  public class Word00ControlFactory : IControlFactory
  {
    private static Word00ControlFactory _instance;

    private Word00ControlFactory()
    {
    }

    public static IControlFactory CreateInstance()
    {
      return _instance ?? (_instance = new Word00ControlFactory());
    }

    public IPanel CreatePanel()
    {
      return new Word00Panel();
    }

    public IButton CreateButton()
    {
      return new Word00Button();
    }

    public ITextBox CreateTextBox()
    {
      return new Word00TextBox();
    }
  }
}
