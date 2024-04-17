using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TeachingTipTarget
{
  /// <summary>
  /// An empty window that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainWindow : Window
  {

    private int currentTeachingTip = 0;

    public MainWindow()
    {
      this.InitializeComponent();
    }

    private void ButtonTeachingTips_Click(object sender, RoutedEventArgs e)
    {
      currentTeachingTip = 0;
      ShowTeachingTip();
    }

    private void TeachingTipGuide_ActionButtonClick(TeachingTip sender, object args)
    {
      ShowTeachingTip();
    }

    private void ShowTeachingTip()
    {

      // set the teaching tip
      switch (currentTeachingTip % 3)
      {

        case 0:

          TeachingTipGuide.Target = TextBoxStep1;
          TeachingTipGuide.PreferredPlacement = TeachingTipPlacementMode.Right;
          TeachingTipGuide.ActionButtonContent = "Next";
          TeachingTipGuide.Title = "Text Box";
          TeachingTipGuide.Subtitle = "This is a text box.";
          break;

        case 1:

          TeachingTipGuide.Target = CalendarDatePickerStep2;
          TeachingTipGuide.PreferredPlacement = TeachingTipPlacementMode.Right;
          TeachingTipGuide.ActionButtonContent = "Next";
          TeachingTipGuide.Title = "Date Picker";
          TeachingTipGuide.Subtitle = "This is a calendar date picker.";
          break;

        case 2:

          TeachingTipGuide.Target = RadioButtonsStep3;
          TeachingTipGuide.PreferredPlacement = TeachingTipPlacementMode.Right;
          TeachingTipGuide.ActionButtonContent = "Next";
          TeachingTipGuide.Title = "Radio Buttons";
          TeachingTipGuide.Subtitle = "This is a radio buttons group.";
          break;

      }

      // open the teaching tip
      TeachingTipGuide.IsOpen = true;

      // increment step
      currentTeachingTip++;

    }

  }
}
