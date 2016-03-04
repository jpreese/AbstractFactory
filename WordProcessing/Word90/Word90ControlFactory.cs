namespace WordProcessing.Word90
{
  public class Word90ControlFactory : IControlFactory
  {
    private static Word90ControlFactory _instance;

    private Word90ControlFactory()
    {
    }

    public static IControlFactory CreateInstance()
    {
      return _instance ?? (_instance = new Word90ControlFactory());
    }

    public IPanel CreatePanel()
    {
      return new Word90Panel();
    }

    public IButton CreateButton()
    {
      return new Word90Button();
    }

    public ITextBox CreateTextBox()
    {
      return new Word90TextBox();
    }
  }
}
