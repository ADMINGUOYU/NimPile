using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimPile
{
    public class common
    {

        public static int pileCount = 0;    //How many piles?
        public static int playerCount = 0;  //How many players?

        public const int pileMaxROW = 10;   //max pile allowed
        public const int pileMaxNum = 100;  //max stone for each pile allowed
        public const int playerMaxROW = 10; //max player allowed

        public static int[] pileNum;        //the number of stones in each pile
        public static int[] pileLimit;      //limit of each pile

        public static string[] playerName;  //stores player's name

        public static bool parameterVerified = false;   //reflects whether the game is good to go




        public static int[] gamePileNum;    //use when playing (number changes)

        public static int ID = 0;
        
        public static int gamePileFetch = -1;
        public static int gameNumFetch = -1;

        public static int currentPlayer = 0;


        public static bool switchNimValueView = false;


    }
}
