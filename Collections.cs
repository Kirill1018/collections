using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;
namespace cs
{
    internal class Collections
    {
        class Karta
        {
            public Karta()
            {

            }
            public int peak_six = 6, peak_seven = 7, peak_eight = 8, peak_nine = 9, peak_ten = 10, peak_jack = 11, peak_lady = 12, peak_king = 13, peak_ace = 14, heart_six = 6, heart_seven = 7, heart_eight = 8, heart_nine = 9, heart_ten = 10, heart_jack = 11, heart_lady = 12, heart_king = 13, heart_ace = 14, tamb_six = 6, tamb_seven = 7, tamb_eight = 8, tamb_nine = 9, tamb_ten = 10, tamb_jack = 11, tamb_lady = 12, tamb_king = 13, tamb_ace = 14, club_six = 13, club_seven = 15, club_eight = 16, club_nine = 17, club_ten = 18, club_jack = 19, club_lady = 20, club_king = 21, club_ace = 22;
        }
        class Player : Karta
        {
            public Player()
            {

            }
            public Karta card = new Karta();
            public void output_of_avail_cards()
            {
                WriteLine("card.peak_six, card.peak_seven, card.peak_eight, card.peak_nine, card.peak_ten, card.peak_jack, card.peak_lady, card.peak_king, card.peak_ace, card.heart_six, card.heart_seven, card.heart_eight, card.heart_nine, card.heart_ten, card.heart_jack , card.heart_lady, card.heart_king, card.heart_ace, card.tamb_six, card.tamb_seven, card.tamb_eight, card.tamb_nine, card.tamb_ten, card.tamb_jack, card.tamb_lady, card.tamb_king, card.tamb_ace, card.club_six, card.club_seven, card.club_eight, card.club_nine, card.club_ten, card.club_jack, card.club_lady, card.club_king, card.club_ace");
            }
        }
        class Game : Player
        {
            public Game()
            {

            }
            public void match()
            {
                var rand = new Random();
                Player gamer = new Player();
                gamer.output_of_avail_cards();
                WriteLine();
                List<string> play_list = new List<string>();
                play_list.Add("first player");
                play_list.Add("second player");
                List<int> card_deck = new List<int>();
                card_deck.Add(card.peak_jack);
                card_deck.Add(card.peak_lady);
                card_deck.Add(card.peak_king);
                card_deck.Add(card.peak_ace);
                card_deck.Add(card.heart_jack);
                card_deck.Add(card.heart_lady);
                card_deck.Add(card.heart_king);
                card_deck.Add(card.heart_ace);
                card_deck.Add(card.tamb_jack);
                card_deck.Add(card.tamb_lady);
                card_deck.Add(card.tamb_king);
                card_deck.Add(card.tamb_ace);
                card_deck.Add(card.club_jack);
                card_deck.Add(card.club_lady);
                card_deck.Add(card.club_king);
                card_deck.Add(card.club_ace);
                List<int> card_shuffl = new List<int>();
                card_shuffl.Add(card.club_ace);
                card_shuffl.Add(card.club_king);
                card_shuffl.Add(card.club_lady);
                card_shuffl.Add(card.club_jack);
                card_shuffl.Add(card.tamb_ace);
                card_shuffl.Add(card.tamb_king);
                card_shuffl.Add(card.tamb_lady);
                card_shuffl.Add(card.tamb_jack);
                card_shuffl.Add(card.heart_ace);
                card_shuffl.Add(card.heart_king);
                card_shuffl.Add(card.heart_lady);
                card_shuffl.Add(card.heart_jack);
                card_shuffl.Add(card.peak_ace);
                card_shuffl.Add(card.peak_king);
                card_shuffl.Add(card.peak_lady);
                card_shuffl.Add(card.peak_jack);
                List<int> cards_of_the_first_play = new List<int>();
                cards_of_the_first_play.Add(card.club_ace);
                cards_of_the_first_play.Add(card.club_king);
                cards_of_the_first_play.Add(card.club_lady);
                cards_of_the_first_play.Add(card.club_jack);
                cards_of_the_first_play.Add(card.tamb_ace);
                cards_of_the_first_play.Add(card.tamb_king);
                cards_of_the_first_play.Add(card.tamb_lady);
                cards_of_the_first_play.Add(card.tamb_jack);
                List<int> cards_of_the_sec_play = new List<int>();
                cards_of_the_sec_play.Add(card.heart_ace);
                cards_of_the_sec_play.Add(card.heart_king);
                cards_of_the_sec_play.Add(card.heart_lady);
                cards_of_the_sec_play.Add(card.heart_jack);
                cards_of_the_sec_play.Add(card.peak_ace);
                cards_of_the_sec_play.Add(card.peak_king);
                cards_of_the_sec_play.Add(card.peak_lady);
                cards_of_the_sec_play.Add(card.peak_jack);
                int score_amount_1 = 8, score_amount_2 = 8, turn_1, turn_2;
                bool random = Convert.ToBoolean(rand.Next(2));
                switch (random)
                {
                    case false:
                        turn_1 = card.club_ace;
                        WriteLine("card.club_ace");
                        WriteLine("***");
                        WriteLine("*a*");
                        WriteLine("***");
                        turn_2 = card.club_eight;
                        WriteLine("card.club_eight");
                        WriteLine("***");
                        WriteLine("*8*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.club_jack;
                        WriteLine("card.club_jack");
                        WriteLine("***");
                        WriteLine("*j*");
                        WriteLine("***");
                        turn_2 = card.club_king;
                        WriteLine("card.club_king");
                        WriteLine("***");
                        WriteLine("*k*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.club_lady;
                        WriteLine("card.club_lady");
                        WriteLine("***");
                        WriteLine("*l*");
                        WriteLine("***");
                        turn_2 = card.club_nine;
                        WriteLine("card.club_nine");
                        WriteLine("***");
                        WriteLine("*9*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.club_seven;
                        WriteLine("card.club_seven");
                        WriteLine("***");
                        WriteLine("*7*");
                        WriteLine("***");
                        turn_2 = card.club_six;
                        WriteLine("card.club_six");
                        WriteLine("***");
                        WriteLine("*6*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.club_ten;
                        WriteLine("card.club_ten");
                        WriteLine("****");
                        WriteLine("*10*");
                        WriteLine("****");
                        turn_2 = card.heart_ace;
                        WriteLine("card.heart_ace");
                        WriteLine("***");
                        WriteLine("*a*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.heart_eight;
                        WriteLine("card.heart_eight");
                        WriteLine("***");
                        WriteLine("*8*");
                        WriteLine("***");
                        turn_2 = card.heart_jack;
                        WriteLine("card.heart_jack");
                        WriteLine("***");
                        WriteLine("*j*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.heart_king;
                        WriteLine("card.heart_king");
                        WriteLine("***");
                        WriteLine("*k*");
                        WriteLine("***");
                        turn_2 = card.heart_lady;
                        WriteLine("card.heart_lady");
                        WriteLine("***");
                        WriteLine("*l*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.heart_nine;
                        WriteLine("card.heart_nine");
                        WriteLine("***");
                        WriteLine("*9*");
                        WriteLine("***");
                        turn_2 = card.heart_seven;
                        WriteLine("card.heart_seven");
                        WriteLine("***");
                        WriteLine("*7*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.heart_six;
                        WriteLine("card.heart_six");
                        WriteLine("***");
                        WriteLine("*6*");
                        WriteLine("***");
                        turn_2 = card.heart_ten;
                        WriteLine("card.heart_ten");
                        WriteLine("****");
                        WriteLine("*10*");
                        WriteLine("****");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.peak_ace;
                        WriteLine("card.peak_ace");
                        WriteLine("***");
                        WriteLine("*a*");
                        WriteLine("***");
                        turn_2 = card.peak_eight;
                        WriteLine("card.peak_eight");
                        WriteLine("***");
                        WriteLine("*8*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        if (score_amount_1 > score_amount_2) WriteLine("первый игрок победил");
                        else WriteLine("второй игрок победил");
                        break;
                    case true:
                        turn_1 = card.peak_eight;
                        WriteLine("card.peak_eight");
                        WriteLine("***");
                        WriteLine("*8*");
                        WriteLine("***");
                        turn_2 = card.peak_ace;
                        WriteLine("card.peak_ace");
                        WriteLine("***");
                        WriteLine("*a*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.peak_king;
                        WriteLine("card.peak_king");
                        WriteLine("***");
                        WriteLine("*k*");
                        WriteLine("***");
                        turn_2 = card.peak_jack;
                        WriteLine("card.peak_jack");
                        WriteLine("***");
                        WriteLine("*j*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.peak_nine;
                        WriteLine("card.peak_nine");
                        WriteLine("***");
                        WriteLine("*9*");
                        WriteLine("***");
                        turn_2 = card.peak_lady;
                        WriteLine("card.peak_lady");
                        WriteLine("***");
                        WriteLine("*l*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.peak_six;
                        WriteLine("card.peak_six");
                        WriteLine("***");
                        WriteLine("*6*");
                        WriteLine("***");
                        turn_2 = card.peak_seven;
                        WriteLine("card.peak_seven");
                        WriteLine("***");
                        WriteLine("*7*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.tamb_ace;
                        WriteLine("card.tamb_ace");
                        WriteLine("***");
                        WriteLine("*a*");
                        WriteLine("***");
                        turn_2 = card.peak_ten;
                        WriteLine("card.peak_ten");
                        WriteLine("****");
                        WriteLine("*10*");
                        WriteLine("****");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.tamb_jack;
                        WriteLine("card.tamb_jack");
                        WriteLine("***");
                        WriteLine("*j*");
                        WriteLine("***");
                        turn_2 = card.tamb_eight;
                        WriteLine("card.tamb_eight");
                        WriteLine("***");
                        WriteLine("*8*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.tamb_lady;
                        WriteLine("card.tamb_lady");
                        WriteLine("***");
                        WriteLine("*l*");
                        WriteLine("***");
                        turn_2 = card.tamb_king;
                        WriteLine("card.tamb_king");
                        WriteLine("***");
                        WriteLine("*k*");
                        WriteLine("***");
                        WriteLine();
                        if(turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.tamb_seven;
                        WriteLine("card.tamb_seven");
                        WriteLine("***");
                        WriteLine("*7*");
                        WriteLine("***");
                        turn_2 = card.tamb_nine;
                        WriteLine("card.tamb_nine");
                        WriteLine("***");
                        WriteLine("*9*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.tamb_ten;
                        WriteLine("card.tamb_ten");
                        WriteLine("****");
                        WriteLine("*10*");
                        WriteLine("****");
                        turn_2 = card.tamb_six;
                        WriteLine("card.tamb_six");
                        WriteLine("***");
                        WriteLine("*6*");
                        WriteLine("***");
                        WriteLine();
                        if (turn_1 > turn_2)
                        {
                            score_amount_1++;
                            score_amount_2--;
                        }
                        else
                        {
                            score_amount_1--;
                            score_amount_2++;
                        }
                        turn_1 = card.heart_six;
                        WriteLine("card.heart_six");
                        WriteLine("***");
                        WriteLine("*6*");
                        WriteLine("***");
                        turn_2 = card.heart_ten;
                        WriteLine("card.heart_ten");
                        WriteLine("****");
                        WriteLine("*10*");
                        WriteLine("****");
                        WriteLine();
                        if (score_amount_1 > score_amount_2) WriteLine("первый игрок победил");
                        else WriteLine("второй игрок победил");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Game play = new Game();
            play.match();
        }
    }
}