namespace WordProcessing.Word10
{
  public class Word10ControlFactory : IControlFactory
  {
    private static Word10ControlFactory _instance;

    private Word10ControlFactory()
    {
    }

    public static IControlFactory CreateInstance()
    {
      return _instance ?? (_instance = new Word10ControlFactory());
    }

    public IPanel CreatePanel()
    {
      return new Word10Panel();
    }

    public IButton CreateButton()
    {
      return new Word10Button();
    }

    public ITextBox CreateTextBox()
    {
      return new Word10TextBox();
    }
  }
}
