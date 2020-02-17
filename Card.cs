namespace BlackJack
{

  public class Card
  {
    public string Rank { get; set; }

    public string Suit { get; set; }

    public string Color { get; set; }

    public bool Changed { get; set; }

    public int GetCardValue()
    {
      if (Rank == "ace")
      {
        return 11;
      }
      else if (Rank == "queen" || Rank == "king" || Rank == "jack")
      {
        return 10;
      }
      else
      {
        return int.Parse(Rank);
      }
    }

  }
}