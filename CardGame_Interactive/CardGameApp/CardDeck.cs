namespace CardGameApp;

public class CardDeck
{
	#region Field Variables
	
	private List<Card> _cardList;

	private static Random s_randomizer;

	private const byte MAX_SUIT_COUNT = 4;
	private const byte MAX_CARD_VALUE = 13;
	
	#endregion
	
	#region Constructors
	/// <summary>
	/// Instance constructor used to intantiate field variables
	/// </summary>
	public CardDeck()
	{
		_cardList = new List<Card>(MAX_SUIT_COUNT * MAX_CARD_VALUE);

		CreateCards();
	}
	
	/// <summary>
	/// Static constructor is used to initialize all static variables,
	/// in the case the randomizer used to shuffle cards
	/// </summary>
	static CardDeck()
	{
		// create randomizer object
		s_randomizer = new Random();
	}
	
	#endregion
	
	#region Properties
	public int CardCount
	{
		get { return _cardList.Count; }
	}
	
	#endregion
	
	#region Methods
	/// <summary>
	/// Create all the cards for each suit
	/// </summary>
	/// <exception cref="NotImplementedException"></exception>
	private void CreateCards()
	{
		// repeat for each of the four suits
		for (byte iSuit = 1; iSuit <= MAX_SUIT_COUNT; iSuit++)
		{
			// repeat for each value in suit
			CardSuit suit = (CardSuit)iSuit; // cast to proper type
			for (byte value = 1; value <= MAX_CARD_VALUE; value++)
			{
				// create a card with current value and suit
				Card card = new Card(value, suit);
				
				// add the card to the list
				_cardList.Add(card);
			}
		}
	}
	
	/// <summary>
	/// Shuffle the card deck using a Fisher-Yates shuffle
	/// </summary>
	/// <exception cref="NotImplementedException"></exception>
	public void ShuffleCards()
	{
		// repeat randomizing the location of each card in the deck
		for (int iCard = 0; iCard < _cardList.Count; iCard++)
		{
			// choose a random card in the deck
			int randPos = s_randomizer.Next(iCard, _cardList.Count); // start randomizer from cards not randomized yet
			
			// swap the random card with the card in current location
			Card randCard = _cardList[randPos];
			Card crtCard = _cardList[iCard];
			_cardList[iCard] = randCard; // current card becomes random card
			_cardList[randPos] = crtCard; // random cards position becomes the current card
		}
	}
	
	#endregion
}
