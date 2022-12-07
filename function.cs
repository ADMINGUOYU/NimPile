using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NimPile
{
    public class function
    {
        public static void initialVaribles()
        {
            common.pileNum = new int[common.pileMaxROW];
            common.pileLimit = new int[common.pileMaxROW];
            common.gamePileNum = new int[common.pileMaxROW];

            common.playerName = new string[common.playerMaxROW];
            
        }
        public static int RegulateIntBetween(string str, int min, int max)
        {
            if (str == "") { str = "0"; }
            if ( Regex.IsMatch(str, @"^\d+$"))
            {
                int num = Convert.ToInt32(str);
                if (num >= min && num <= max) {return num;}                
                if ( num < min ) {return min;}
                if (num > max ) {return max;}
            }
            
            return max+1 ;
        }

        public static string checkData()
        {   
            if(common.pileCount == 0)
            {
                return "Need At least 1 pile to continue";
            }
            if (common.playerCount < 2)
            {
                return "Need At least 2 players to continue";
            }
            for (int i = 0; i < common.pileCount; i++)
            {
                if (common.pileNum[i] == 0)
                {
                    return "please check pile " + Convert.ToString(i+1) + " entry";
                }
                if (common.pileNum[i] < common.pileLimit[i])
                {
                    return "Critical ERROR";
                }
            }
            return "0";
        }



    }   
}
