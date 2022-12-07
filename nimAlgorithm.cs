using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimPile
{
    internal class nimAlgorithm
    {
        public static int[] nimValues;
        public static int[] customNimValues;

        public static int[] possibleSolutionPileNo;
        public static int[] possibleSolutionPileNum;

        public static void initialNimAlgorithm()
        {
            nimValues = new int[common.pileMaxROW];
            customNimValues = new int[common.pileMaxROW];
            possibleSolutionPileNo = new int[common.pileMaxROW];
            possibleSolutionPileNum = new int[common.pileMaxROW];
    }

        public static void calculateNimForEachPile()    //this function updates the nimValue in the array nimValues[]
        {
            for (int i = 0; i < common.pileCount; i++)
            {
                int currentRemainInPile = common.gamePileNum[i];
                int currentLimit = common.pileLimit[i];

                nimValues[i] = currentRemainInPile % (currentLimit + 1);
                if (currentLimit == 0)
                {
                    nimValues[i] = currentRemainInPile;
                }
            }
        }


        public static int calculateNimForWhole()
        {
            int output = nimValues[0];
            for(int i = 1; i < common.pileCount; i++)
            {
                output ^= nimValues[i];
            }

            return output;
        }


        public static void customCalculateNimForEachPile (int pile, int value) //value: minus how many
        {
            for (int i = 0; i < common.pileCount; i++)
            {
                int currentRemainInPile = common.gamePileNum[i];
                if (i == pile)
                {
                    currentRemainInPile = common.gamePileNum[i] - value;
                }
                int currentLimit = common.pileLimit[i];

                customNimValues[i] = currentRemainInPile % (currentLimit + 1);
                if (currentLimit == 0)
                {
                    customNimValues[i] = currentRemainInPile;
                }
            }
        }

        public static int customCalculateNimForWhole()
        {
            int output = customNimValues[0];
            for (int i = 1; i < common.pileCount; i++)
            {
                output ^= customNimValues[i];
            }

            return output;
        }

        public static int[] calculateBestMove()
        {
            int[] str = new int[2];
            calculateNimForEachPile();

            int currentNimValueAll = calculateNimForWhole();
            int target = 0 ^ currentNimValueAll;
            int value = 0;
            int pick = 0;
            int possibleGroups = 0;

            if (currentNimValueAll != 0)
            {
                for (int i = 0; i < common.pileCount; i++)
                {
                    value = nimValues[i] ^ target;
                    pick = nimValues[i] - value;

                    if (pick > 0 && pick <= common.gamePileNum[i])
                    {
                        possibleSolutionPileNo[possibleGroups] = i;
                        possibleSolutionPileNum[possibleGroups] = pick;
                        possibleGroups++;
                    }
                    

                    //if (common.pileLimit[i] == 0)
                    //{
                    //    possibleSolutionPileNo[possibleGroups] = i;
                    //    pick = common.gamePileNum[i] - value;
                    //    possibleSolutionPileNum[possibleGroups] = pick;
                    //    possibleGroups++;
                    //}
                    //if (common.pileLimit[i] != 0)
                    //{
                    //    possibleSolutionPileNo[possibleGroups] = i;
                    //    pick = nimValues[i] - value;
                    //    possibleSolutionPileNum[possibleGroups] = pick;
                    //    possibleGroups++;
                    //}
                }
                Random random = new Random();
                int n;

                n = random.Next(0, possibleGroups - 1);


                str[0] = possibleSolutionPileNo[n];
                str[1] = possibleSolutionPileNum[n];
                return str;

            }
            else
            {
                int p;
                int q;
                Random random = new Random();

                p = random.Next(0, common.pileCount - 1);
                while (common.gamePileNum[p] == 0)
                {
                    p = random.Next(0, common.pileCount - 1);
                }
                q = 1;

                str[0] = p;
                str[1] = q;

                return str;
            }
            
        }


        public static bool win()
        {
            for (int i = 0; i < common.pileCount; i++)
            {
                if (common.gamePileNum[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
