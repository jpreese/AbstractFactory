namespace WordProcessing.Word16
{
  public class Word16ControlFactory : IControlFactory
  {
    private static Word16ControlFactory _instance;

    private Word16ControlFactory()
    {
    }

    public static IControlFactory CreateInstance()
    {
      return _instance ?? (_instance = new Word16ControlFactory());
    }

    public IPanel CreatePanel()
    {
      return new Word16Panel();
    }

    public IButton CreateButton()
    {
      return new Word16Button();
    }

    public ITextBox CreateTextBox()
    {
      return new Word16TextBox();
    }
  }
}
