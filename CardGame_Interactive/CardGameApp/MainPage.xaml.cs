namespace CardGameApp;

public partial class MainPage : ContentPage
{
    private CardGame _cardGame; // HAS-A relationship
    public MainPage()
    {
        InitializeComponent();
        
        // create the card game
        _cardGame = new CardGame();
    }
}