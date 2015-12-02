using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Game
    {
        const int mapWidth = 20;
        const int mapHeight = 10;
        Room[,] rooms = new Room[mapWidth, mapHeight];
        Player player = new Player();
       
        public void Start()
        {
            CreateMap();

            do
            {
                Console.Clear();
                DisplayPlayerInfo();
                DisplayMap();
                AskForCommand();
                player.Health -= 10; //Spelaren blöder
            } while (player.Health > 0); // Så länge spelaren lever

        }

        private void CreateMap()
        {
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    //Room room = new Room();
                    //rooms[x, y] = room;
                    rooms[x, y] = new Room();

                    // Lägg till monster
                    //if (x == 1 && y == 1)
                    //    room.MonsterInRoom = new Monster("Ogre", 40, 20);
                }
            }
            rooms[1, 1].MonsterInRoom = new Monster("Ogre", 40, 20);
        }

        private void DisplayPlayerInfo()
        {
            Console.WriteLine("Health:" + player.Health);
        }

        private void DisplayMap()
        {
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    Room room = rooms[x, y];

                    if(player.X == x && player.Y == y)
                        Console.Write("P");
                    else if (room.MonsterInRoom != null)
                        Console.Write("M");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void AskForCommand()
        {
            Console.WriteLine("Enter movement");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            //int x = player.X;
            //int y = player.Y;
            switch (keyInfo.Key)
            {
                //case ConsoleKey.LeftArrow: x--; break;
                //case ConsoleKey.RightArrow: x++; break;
                //case ConsoleKey.UpArrow: y--; break;
                //case ConsoleKey.DownArrow: y++; break;
                case ConsoleKey.LeftArrow: player.X--; break;
                case ConsoleKey.RightArrow: player.X++; break;
                case ConsoleKey.UpArrow: player.Y--; break;
                case ConsoleKey.DownArrow: player.Y++; break;

            }

            //player.X = x;
            //player.Y = y;

        }
    }
}
