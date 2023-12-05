using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_EndProject1
{
    internal class Program
    {
        static void AddPlayer(OneDayTeam team)
        {
            Console.WriteLine("Enter Player Id: ");
            int playerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter Player Age: ");
            int playerAge = int.Parse(Console.ReadLine());
            team.Add(new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge });

        }
        static void RemovePlayer(OneDayTeam team)
        {
            Console.WriteLine("Enter Player id to remove");
            int playerId = int.Parse(Console.ReadLine());
            team.Remove(playerId);
        }

        static void GetPlayerById(OneDayTeam team)
        {
            Console.WriteLine("Enter player id: ");
            int playerId = int.Parse(Console.ReadLine());
            Player player = team.GetPlayerById(playerId);
            if (player != null)
            {
                Console.WriteLine($"Id: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
        }
        static void GetPlayerByName(OneDayTeam team)
        {
            Console.WriteLine("Enter Player name: ");
            string playerName = Console.ReadLine();
            Player player = team.GetPlayerByName(playerName);
            if (player != null)
            {
                Console.WriteLine($"Id: {player.PlayerId}, Name: {player.PlayerName} Age: {player.PlayerAge}");

            }
            else
            {
                Console.WriteLine("Player not found");
            }

        }
        static void GetAllPlayers(OneDayTeam team)
        {
            List<Player> player = team.GetAllPlayers();
            foreach (Player p in player)
            {
                Console.WriteLine($" Id: {p.PlayerId}, Name: {p.PlayerName}, Age: {p.PlayerAge}");
            }
        }
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            while (true)
            {
                Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3:Get Player By Id 4:Get Player by Name 5:Get All Players:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPlayer(team);
                        break;

                    case 2:
                        RemovePlayer(team);
                        break;

                    case 3:
                        GetPlayerById(team);
                        break;

                    case 4:
                        GetPlayerByName(team);
                        break;

                    case 5:
                        GetAllPlayers(team);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue(yes/no)?:");
                string Cchoice = Console.ReadLine().ToLower();

                if (Cchoice != "yes")
                {
                    break;
                }

            }
            Console.ReadKey();

        }
    }
}

