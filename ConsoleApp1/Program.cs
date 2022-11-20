using Game21.Models;
using Game21.Services;


class Program
{
    static void Main(string[] Args)
    {

        while (true)
        {
            Game.StartGame();

            Console.WriteLine("Игра окончена!");
            Console.WriteLine("Хотите попробовать ещё раз?");
            Console.WriteLine("y - да, n - нет");
            var result = Console.ReadLine();
            if (result == "y")
                Game.StartGame();
            else
                break;




        }

    }
    }

