using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_EndProject1
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < oneDayTeam.Capacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player added successfully.");
            }
            else
            {
                Console.WriteLine("Team is full. Cant add more players.");
            }

        }

        public void Remove(int playerId)
        {
            Player player = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (player != null)
            {
                oneDayTeam.Remove(player);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("Player id not found");

            }
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(p => playerName.ToLower() == playerName.ToLower());
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

        
    }
}
