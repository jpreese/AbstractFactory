namespace WordProcessing
{
  public interface IControlFactory
  {
    IPanel CreatePanel();
    IButton CreateButton();
    ITextBox CreateTextBox();
  }
}
