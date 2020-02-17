using System;
using System.Collections.Generic;

namespace BlackJack
{
  class Program
  {

    static void Main(string[] args)
    {
      static List<Card> generateDeck()
      {
        var suits = new List<string>() { "clubs", "spades", "hearts", "diamonds" };
        var ranks = new List<string>() { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
        var deck = new List<Card>();
        deck.Clear();
        for (int i = 0; i < suits.Count; i++)
        {
          for (int j = 0; j < ranks.Count; j++)
          {
            var card = new Card();
            card.Rank = ranks[j];
            card.Suit = suits[i];
            if (card.Suit == "diamonds" || card.Suit == "hearts")
            {
              card.Color = "red";
            }
            else
            {
              card.Color = "black";
            }
            deck.Add(card);

            for (int s = deck.Count - 1; s >= 1; s--)
            {
              var m = new Random().Next(s);
              var temp = deck[m];
              deck[m] = deck[s];
              deck[s] = temp;
            }

            //Console.WriteLine($"{card.Color} - {card.Suit} - {card.Rank}");
          }
        }
        Console.Clear();
        Console.WriteLine("I have shuffled the cards.  Let's get started.");
        return deck;
      }

      static void displayCards(Player playerIn)
      {
        for (int i = 0; i < playerIn.Count; i++)
        {
          Console.WriteLine($"{playerIn[i].Rank} of {playerIn[i].Suit}");
          //Console.WriteLine(cardList);
        }
        //Console.WriteLine($"Your cards total {playerTotal}");

      }

      static string determineWinner(int playerCardTotal, int computerCardTotal)
      {
        if (playerCardTotal > computerCardTotal)
        {
          return "You";
        }

        else
        {
          return "The computer";
        }
      }



      // Start
      int playerCardTotal = 0;
      int computerCardTotal = 0;
      Console.Clear();
      Console.WriteLine("Welcome to Blackjack !!!");
      Console.WriteLine("Would you like to play a  game? (Y) or (N)");
      var input = Console.ReadLine().ToLower();

      if (input == "y")
      {
        var playingGame = true;
        var player = new Player();
        var computer = new Player();
        var deck = new List<Card>();

        while (playingGame == true)
        {
          playingGame = false;
          deck.Clear();
          player.Clear();
          computer.Clear();
          deck = generateDeck();


          int round = 0;
          while (round < 2)
          {
            player.Add(deck[0]);
            Console.WriteLine("Player gets a card");
            deck.RemoveAt(0);
            computer.Add(deck[0]);
            Console.WriteLine("Dealer gets a card");
            deck.RemoveAt(0);
            round++;
          }

          // Work player hand while not busted
          var playerBusted = false;
          var playerStand = false;
          var computerBusted = false;

          while (playerBusted == false && playerStand == false)
          {
            Console.WriteLine("Your cards are..");
            displayCards(player);
            // ace logic
            playerCardTotal = player.TotalOfCards();
            Console.WriteLine($"The total of your cards is {playerCardTotal}");
            Console.WriteLine($"Do you want to Hit or Stand");
            var input2 = Console.ReadLine().ToLower();

            if (input2 == "hit" || input2 == "stand")
            {
              if (input2 == "hit")
              {
                player.Add(deck[0]);
                deck.RemoveAt(0);
                Console.Clear();
                playerCardTotal = player.TotalOfCards();
              }
              if (input2 == "stand")
              {
                playerStand = true;
              }
            }
            else
            {
              Console.Clear();
              Console.WriteLine("Please enter either (Hit) or (Stand)");
            }

            if (playerCardTotal > 21)
            {
              Console.WriteLine("Your cards are..");
              displayCards(player);
              Console.WriteLine($"The total of your cards is {playerCardTotal}");
              Console.WriteLine("You busted. This game is over");
              playerBusted = true;
            }
          }


          if (playerBusted == false && playerStand == true)
          {
            // Work PC hand
            Console.WriteLine("The dealer has...");
            displayCards(computer);
            computerCardTotal = computer.TotalOfCards();


            while (computerCardTotal < 17)
            {
              Console.WriteLine($"The dealer has {computerCardTotal} and must take a card.");
              computer.Add(deck[0]);
              Console.WriteLine($"The dealer drew a {deck[0].Rank} of {deck[0].Suit}");
              deck.RemoveAt(0);
              computerCardTotal = computer.TotalOfCards();
            }

            if (computerCardTotal > 21)
            {
              computerBusted = true;
              Console.WriteLine($"The dealer has {computerCardTotal} and busted. You win.");
            }
          }

          if (playerBusted == false && playerStand == true && computerBusted == false)
          {

            Console.WriteLine($"You have {playerCardTotal} and the dealer has {computerCardTotal}.");
            var winner = determineWinner(playerCardTotal, computerCardTotal);
            Console.WriteLine($"{winner} won the game.");
          }




          Console.WriteLine("Do you want to play another game (Y) or (N)");
          var playAnotherGame = Console.ReadLine().ToLower();

          if (playAnotherGame == "y")
          {
            playingGame = true;
          }

          else if (input == "n")
          {
            Console.WriteLine("Goodbye.");
            playingGame = false;
          }
        }
      }
      Console.Write("Then why did you bother me.");
    }
  }
}


