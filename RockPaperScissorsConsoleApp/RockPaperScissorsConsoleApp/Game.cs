using System;

namespace RockPaperScissorsConsoleApp
{
    public class Game
    {
        private bool keepPlaying = true;

        public Game()
        {
            StartGame();
        }

        private void StartGame()
        {
            Player player = new Player();
            Player computer = new Player
            {
                name = "Computer"
            };

            Welcome(computer, player);

            while (keepPlaying)
            {
                Console.WriteLine("Do you choose (1) ROCK, (2) PAPER or (3) SCISSORS");
                string entry = Console.ReadLine();
                Int32.TryParse(entry, out player.chosenMove);

                Random r = new Random();
                computer.chosenMove = r.Next(1, 4);

                CheckWin(computer, player);
                ChooseToReplay();
            }
        }

        private void Welcome(Player computer, Player player)
        {
            Console.WriteLine("Welcome to RockPaperScissors: The Ultimate Console Edition! \nWhat is your name?");
            player.name = Console.ReadLine();
            Console.WriteLine("\nAhh thank you " + player.name + ", let's start the game.");
            Console.WriteLine("\nRULES: You get to choose 1 move from 3 moves - ROCK, PAPER or SCISSORS. \nROCK beats SCISSORS, SCISSORS beats PAPER, PAPER beats ROCK. \nYou (" + player.name + ") vs " + computer.name + "\nType the NUMBER related to the move you want to use and press ENTER. \nGood luck...");
        }

        private void CheckWin(Player computer, Player player)
        {
            if (computer.chosenMove == 1)
            {
                switch (player.chosenMove)
                {
                    case 1:
                        Console.WriteLine("The computer chose ROCK. \nIt is a tie!.");
                        break;

                    case 2:
                        Console.WriteLine("The computer chose ROCK. \nYou win, PAPER beats ROCK!");
                        break;

                    case 3:
                        Console.WriteLine("The computer chose ROCK. \nSorry you lose,ROCK beats SCISSORS!");
                        break;

                    default:
                        Console.WriteLine("You must enter (1) for ROCK, (2) for PAPER or (3) for SCISSORS!");
                        break;
                }

            }

            else if (computer.chosenMove == 2)
            {
                switch (player.chosenMove)
                {
                    case 1:
                        Console.WriteLine("The computer chose PAPER. \nSorry you lose, PAPER beat ROCK!");
                        break;

                    case 2:
                        Console.WriteLine("The computer chose PAPER. \nIt is a tie!.");
                        break;
                    case 3:
                        Console.WriteLine("The computer chose PAPER. \nYou win, SCISSORS beats PAPER!");
                        break;
                    default:
                        Console.WriteLine("You must enter (1) for ROCK, (2) for PAPER or (3) for SCISSORS!");
                        break;
                }
            }
            else if (computer.chosenMove == 3)
            {
                switch (player.chosenMove)
                {
                    case 1:
                        Console.WriteLine("The computer chose SCISSORS. \nYou win, ROCK beats SCISSORS!");
                        break;
                    case 2:
                        Console.WriteLine("The computer chose SCISSORS. \nSorry you lose, SCISSORS beats PAPER!");
                        break;
                    case 3:
                        Console.WriteLine("The computer chose SCISSORS. \nIt is a tie!");
                        break;
                    default:
                        Console.WriteLine("You must enter (1) for ROCK, (2) for PAPER or (3) for SCISSORS!");
                        break;
                }
            }
        }

        private void ChooseToReplay()
        {
            Console.WriteLine("New game? y/n");
            ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
            keepPlaying = cki.KeyChar == 'y'; //returns bool, continue only if y was pressed
        }
    }

}