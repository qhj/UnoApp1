namespace UnoApp1.Presentation;

public partial class MainPage : Page
{
    public MainPage()
    {
        this
            .Background(Theme.Brushes.Background.Default)
            .StatusBar(foreground: StatusBarForegroundTheme.Auto)
            .Content
            (
                new AutoLayout()
                    .Background(Theme.Brushes.Background.Default)
                    .Children
                    (
                        new AutoLayout()
                            .Spacing(16)
                            .Padding(32, 48, 32, 8)
                            .Children
                            (
                                new TextBlock()
                                    .Text("Welcome.")
                                    .Foreground(Theme.Brushes.OnSurface.Default)
                                    .Style(Theme.TextBlock.Styles.HeadlineMedium)
                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                                new TextBlock()
                                    .Text("Log in to your account")
                                    .Foreground(Theme.Brushes.OnSurface.Default)
                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                            ),
                        new AutoLayout()
                            .Spacing(16)
                            .Padding(32, 8, 32, 32)
                            .Children
                            (
                                new TextBox()
                                    .Text("test")
                                    .Height(60)
                                    .PlaceholderText("账号")
                                    .Style(Theme.TextBox.Styles.Filled),
                                new PasswordBox()
                                    .PlaceholderText("密码")
                                    .Password("password")
                                    .Height(60)
                                    .Style(Theme.PasswordBox.Styles.Filled),
                                new HyperlinkButton()
                                    .Content("Forgot password?")
                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                                new Button()
                                    .Content("Login")
                            ),
                        new AutoLayout()
                            .PrimaryAxisAlignment(AutoLayoutAlignment.End)
                            .Padding(32)
                            .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                            .Children
                            (
                                new TextBlock()
                                    .TextAlignment(Microsoft.UI.Xaml.TextAlignment.Center)
                                    .TextWrapping(TextWrapping.Wrap)
                                    .Text("Legal mentions")
                                    .Foreground(Theme.Brushes.OnBackground.Default)
                                    .Style(Theme.TextBlock.Styles.BodySmall)
                            )
                    )
            );
    }
}
