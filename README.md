# Default Template for SDG .NET Course

This is the default template for a simple .NET Core console app. This template has:

- github integration

## To push to github

To create and push your current code to github, use the task `create-github`.

How?

1. Open your command pallette by using (Mac) `shift + cmd + p` or (Windows) `shift + ctrl + p`
2. Search and Select `Tasks: Run Task`
3. Select `create-github` from the dropdown

This will create a new github repo, locally and up on github and also push your current code.

## To turn in your assignment:

after you have created a github repo, completed your project and pushed your code, follow these instructions: https://suncoast.io/handbook/tools/assignment-turn-in/

## PROTIP:

When you are complete with the project and have turned it in to your instructor, update this read me with details about the assignment.

          // // Start Playing
          // var stand = false;
          // var playingGame = true;
          // var drawCard = true;
          // var thisGame = true;
          // var busted = false;

          // while (playingGame == true)
          // {
          //   // Shuffle and deal
          //   while (thisGame == true)
          //   {
          //     displayCards(player);

          //     while (stand == false)
          //     {

          //       while (drawCard == true)
          //       {

          //         Console.WriteLine($"Do you want to Hit or Stand");
          //         var input = Console.ReadLine().ToLower();

          //         if (input == "hit" || input == "stand")
          //         {

          //           if (input == "hit")
          //           {
          //             player.Add(deck[0]);
          //             deck.RemoveAt(0);
          //             Console.Clear();

          //             displayCards(player);
          //             Console.WriteLine($"The total of your cards is: {player.TotalOfCards()}");

          //             if (player.TotalOfCards() > 21)
          //             {
          //               Console.WriteLine("You busted. This game is over");
          //               drawCard = false;
          //               stand = true;
          //               thisGame = false;
          //               busted = true;
          //             }
          //           }

          //           else
          //           {
          //             stand = true;
          //             drawCard = false;
          //           }
          //         }

          //         else
          //         {
          //           Console.Clear();
          //           Console.WriteLine("Please enter either (Hit) or (Stand)");
          //         }
          //       }
          //       //After Busted
          //     }
          //     if (busted == true)
          //     {
          //       thisGame = false;
          //     }


          //     // place to do computer cards
          //   }

          //   Console.WriteLine("Do you want to play another playingGame? (Yes) or (No)");
          //   var input2 = Console.ReadLine().ToLower();
          //   if (input2 == "no")
          //   {
          //     playingGame = false;
          //   }
          // }
          // Console.WriteLine("Thanks for playing.");




          // // New playingGame





          // // Tell player what his count is
          // // Loop asking if the player if he wants to "Hit" and "Stand."
          // // if player total is > 21 they bust - playingGame over

          // // once player stands..

          // // Computer shows his cards and total
          // // computer must hit if < 17
          // // if the total is < 21 bust playingGame is over

          // // Once both stand compare and highest player is the winner

          // // ask to play again.
          // // if yes - restart everything
          // // if no goodbye message
