﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach(Player player in players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.deck = new Deck();
            Dealer.deck.Shuffle();

            foreach(Player player in players)
            {
                bool validAnswer = false;
                int bet = 0;
                while(!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if(!validAnswer)
                    {
                        Console.WriteLine("Please only enter whole numbers:");
                    }
                }
                if(bet < 0)
                {
                    throw new FraudException("Security: escort player immediately");
                }

                bool succussfullyBet = player.Bet(bet);
                if(!succussfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing:");
                foreach(Player player in players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if(i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if(blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}! You're balance is {3}", player.Name, Bets[player], player.Balance);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if( i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if(blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Bummer, no payout for anyone...");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach(Player player in players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("You're cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if( answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if(busted)
                    {
                        Dealer.balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. " +
                            "Your balance is now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("You do want to play another round?");
                        answer = Console.ReadLine().ToLower();
                        if(answer == "yes" || answer == "y")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if(Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying...");
            }
            if(Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach(KeyValuePair<Player, int>entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.balance -= entry.Value;
                }
                return;
            }
            foreach(Player player in players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if(playerWon == null)
                {
                    Console.WriteLine("Push!");
                    player.Balance += Bets[player];
                }
                else if(playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}