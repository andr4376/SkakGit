using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SKAK
{

    class Program
    {

        public const int dimension = 8; // const fordi de ikke skal ændres

        public static string[,] grid = new string[dimension, dimension]; //public static string 2D array, da det bruges i flere metoder


        static void Main(string[] args)
        {
            Console.SetWindowSize(83, 21);
            StartScreen(); //startskærm

            Console.BackgroundColor = ConsoleColor.White; //symboliser at det er "WHITE"'s tur
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetWindowSize(42, 29);
            CreateGrid(); //Den laver det første skakbræt, med brikkernes standard position


            while (true) //da while altid er true, kan jeg opdatere skækbrættet for evigt
            {

                WhiteTurn();
                BlackTurn();

                continue; //Nu startes While loop'et forfra, igen og igen.
            }
        }

        /// <summary>
        /// laver et skakbræt med standard positioner
        /// </summary>
        public static void CreateGrid()
        {
            //Brikkernes start positioner
            //BLACK


            grid[0, 0] = "*8";
            grid[0, 1] = "*7";
            grid[0, 2] = "*3";
            grid[0, 3] = "*5";
            grid[0, 4] = "*6";
            grid[0, 5] = "*3";
            grid[0, 6] = "*7";
            grid[0, 7] = "*8";

            grid[1, 0] = "*1";
            grid[1, 1] = "*1";
            grid[1, 2] = "*1";
            grid[1, 3] = "*1";
            grid[1, 4] = "*1";
            grid[1, 5] = "*1";
            grid[1, 6] = "*1";
            grid[1, 7] = "*1";
            //white spaces - 
            grid[2, 0] = "  ";
            grid[2, 1] = "  ";
            grid[2, 2] = "  ";
            grid[2, 3] = "  ";
            grid[2, 4] = "  ";
            grid[2, 5] = "  ";
            grid[2, 6] = "  ";
            grid[2, 7] = "  ";

            grid[3, 0] = "  ";
            grid[3, 1] = "  ";
            grid[3, 2] = "  ";
            grid[3, 3] = "  ";
            grid[3, 4] = "  ";
            grid[3, 5] = "  ";
            grid[3, 6] = "  ";
            grid[3, 7] = "  ";

            grid[4, 0] = "  ";
            grid[4, 1] = "  ";
            grid[4, 2] = "  ";
            grid[4, 3] = "  ";
            grid[4, 4] = "  ";
            grid[4, 5] = "  ";
            grid[4, 6] = "  ";
            grid[4, 7] = "  ";

            grid[5, 0] = "  ";
            grid[5, 1] = "  ";
            grid[5, 2] = "  ";
            grid[5, 3] = "  ";
            grid[5, 4] = "  ";
            grid[5, 5] = "  ";
            grid[5, 6] = "  ";
            grid[5, 7] = "  ";


            //WHITE
            grid[6, 0] = " 1";
            grid[6, 1] = " 1";
            grid[6, 2] = " 1";
            grid[6, 3] = " 1";
            grid[6, 4] = " 1";
            grid[6, 5] = " 1";
            grid[6, 6] = " 1";
            grid[6, 7] = " 1";


            grid[7, 0] = " 8";
            grid[7, 1] = " 7";
            grid[7, 2] = " 3";
            grid[7, 3] = " 5";
            grid[7, 4] = " 6";
            grid[7, 5] = " 3";
            grid[7, 6] = " 7";
            grid[7, 7] = " 8";



            Console.WriteLine("     0   1   2   3   4   5   6   7  --> X"); //x aksens "grafik"
            Console.WriteLine("   ---------------------------------");



            for (int x = 0; x < dimension; x++)
            {
                Console.Write((x).ToString() + " ¦|"); //y aksens "grafik"
                for (int y = 0; y < dimension; y++)
                {

                    Console.Write(grid[x, y] + " |"); // en "|" imellem hver brik

                }
                Console.WriteLine();// 2x WritLineS, så brættet bliver kvadratisk
                Console.WriteLine("   ---------------------------------");//x aksens "grafik"

            }

        }
        /// <summary>
        /// Her tager applikationen spillerens input, og generer et nyt skakbræt med de valgte koordinater!
        /// </summary>
        public static void WhiteTurn()
        {
            Console.WriteLine("y            WHITE'S TURN");
            Console.WriteLine();

            //flyt fra
            //X koordinat
            Console.WriteLine("move from (x)");
            int moveX = Convert.ToInt32(Console.ReadLine());

            //Y koordinat
            Console.WriteLine("move from (y)");
            int moveY = Convert.ToInt32(Console.ReadLine());


            // flyt til

            //X koordinat
            Console.WriteLine("move to (x)");
            int moveToX = Convert.ToInt32(Console.ReadLine());

            //Y koordinat
            Console.WriteLine("move to (y)");
            int moveToY = Convert.ToInt32(Console.ReadLine());


            // nu opdateres brikkernes position
            grid[moveToY, moveToX] = grid[moveY, moveX];
            grid[moveY, moveX] = "  ";


            Console.Beep(); //et *beep* som repræsentere at turen skifter
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear(); //Jeg sletter det gamle bræt, og opdatere brikkernes position i et nyt grid nedenunder/

            Console.WriteLine("     0   1   2   3   4   5   6   7  --> X");//x aksens "grafik"
            Console.WriteLine("   ---------------------------------");
            for (int x = 0; x < dimension; x++)
            {
                Console.Write((x).ToString() + " ¦|"); //y aksens "grafik"
                for (int y = 0; y < dimension; y++)
                {

                    Console.Write(grid[x, y] + " |"); // en "|" imellem hver brik

                }
                Console.WriteLine();
                Console.WriteLine("   ---------------------------------");

            }
        }
        /// <summary>
        /// Det samme som 'WhiteTurn()', men noget af indmaden er ændret for at den kan loope tilbage til 'WhiteTurn()' 
        /// </summary>
        public static void BlackTurn()
        {
            Console.WriteLine("y            BLACK'S TURN");
            Console.WriteLine();

            //move from
            //X koordinat
            Console.WriteLine("move from (x)");
            int moveXblack = Convert.ToInt32(Console.ReadLine());

            //Y koordinat
            Console.WriteLine("move from (y)");
            int moveYblack = Convert.ToInt32(Console.ReadLine());


            // move to

            //X koordinat
            Console.WriteLine("move to (x)");
            int moveToXblack = Convert.ToInt32(Console.ReadLine());
            //Y koordinat
            Console.WriteLine("move to (y)");
            int moveToYblack = Convert.ToInt32(Console.ReadLine());


            // nu opdateres brikkernes position
            grid[moveToYblack, moveToXblack] = grid[moveYblack, moveXblack];
            grid[moveYblack, moveXblack] = "  ";

            Console.Beep(); //et *beep* som repræsentere at turen skifter
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear(); //Jeg sletter det gamle bræt, og opdatere brikkernes position i et nyt grid nedenunder

            Console.WriteLine("     0   1   2   3   4   5   6   7  --> X");//x aksens "grafik"
            Console.WriteLine("   ---------------------------------");
            for (int x = 0; x < dimension; x++)
            {
                Console.Write((x).ToString() + " ¦|"); //y aksens "grafik"
                for (int y = 0; y < dimension; y++)
                {

                    Console.Write(grid[x, y] + " |"); // en "|" imellem hver brik

                }
                Console.WriteLine();
                Console.WriteLine("   ---------------------------------");//x aksens "grafik"

            }
        }
        /// <summary>
        /// Viser en """grafisk""" startskærm, som er det første spilleren ser.
        /// </summary>
        public static void StartScreen()
        {
            Console.WriteLine("          _______________________________________________________________________");
            Console.WriteLine("        /    @@@@@@@@  @@@    @@@   @@@@@@@@@  @@@@@@@@   @@@@@@@@   @@@ @@@    /");
            Console.WriteLine("       /    @@@@@@@@  @@@    @@@   @@@@@@@@@  @@@@@@@@   @@@@@@@@   @@@ @@@    /");
            Console.WriteLine("      /    @@@       @@@    @@@   @@@        @@@        @@@        @@@ @@@    /");
            Console.WriteLine("     /    @@@       @@@@@@@@@@   @@@@@@@@@  @@@@@@@@   @@@@@@@@   @@@ @@@    /");
            Console.WriteLine("    /    @@@       @@@    @@@   @@@             @@@        @@@   @@@ @@@    /");
            Console.WriteLine("   /    @@@@@@@@  @@@    @@@   @@@@@@@@@  @@@@@@@@   @@@@@@@@              /");
            Console.WriteLine("  /    @@@@@@@@  @@@    @@@   @@@@@@@@@  @@@@@@@@   @@@@@@@@   @@@ @@@    /");
            Console.WriteLine(" /_______________________________________________________________________/");
            Console.WriteLine("                  A VIRTUAL CHESSBOARD MADE BY ANDREAS(TM) ");

            Console.WriteLine();
            Console.WriteLine("                              PAWN   =1");
            Console.WriteLine("                              BISHOP =3");
            Console.WriteLine("                              ROOK   =8");
            Console.WriteLine("                              KNIGHT =7");
            Console.WriteLine("                              KING   =5 ");
            Console.WriteLine("                              QUEEN  =6");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                        PRESS ENTER TO START!");
            Console.ReadLine();
        }



    }
}