namespace BlackJack
{
  using System.Collections.Generic;
  public class Player : List<Card>
  {

    private int cardsTotal;
    public void Add(string rank, string suit, string color, bool changed)
    {
      var data = new Card
      {
        Rank = rank,
        Suit = suit,
        Color = color,
        Changed = changed
      };
      this.Add(data);
    }


    public int TotalOfCards()
    {
      cardsTotal = 0;
      for (int i = 0; i < this.Count; i++)
      {
        cardsTotal = cardsTotal + this[i].GetCardValue();
      }
      return cardsTotal;
    }

  }
}