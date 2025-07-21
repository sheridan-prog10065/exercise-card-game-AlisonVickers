namespace CardGameApp;

public class CardDeck
{
	private List<Card> _cardList;

	private const byte MAX_SUIT_COUNT = 4;
	private const byte MAX_CARD_VALUE = 13;

	public CardDeck()
	{
		_cardList = new List<Card>(MAX_SUIT_COUNT * MAX_CARD_VALUE);

		CreateCards();
	}
	
	public int CardCount
	{
		get { return _cardList.Count; }
	}
	
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
}
