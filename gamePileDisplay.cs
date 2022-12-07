using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimPile
{
    public class gamePileDisplay
    {
        public static MaterialSlider[] sliderPile;
        public static MaterialCard[] cardPile;

        public static void initialPileDisplay()
        {
            sliderPile = new MaterialSlider[common.pileMaxROW];
            cardPile = new MaterialCard[common.pileMaxROW];
        }
        public static void pileUpdate(int max, Control control, int x, int y, int pudding)
        {

            //remove old resources
            for (int i = 0; i < common.pileMaxROW; i++)
            {
                control.Controls.Remove(sliderPile[i]);
                control.Controls.Remove(cardPile[i]);
            }

            //add new list
            for (int i = 0; i < common.pileCount; i++)
            {
                sliderPile[i] = new MaterialSlider();
                cardPile[i] = new MaterialCard();

                sliderPile[i].Name = Convert.ToString(i);
                sliderPile[i].Text = "Pile " + Convert.ToString(i + 1);
                sliderPile[i].Size = new Size(550, 40);
                sliderPile[i].Location = new Point(x+50, 20 + y + i * (10 + pudding));
                sliderPile[i].ValueMax = common.pileNum[i];
                sliderPile[i].RangeMax = max;
                sliderPile[i].Value = common.pileNum[i];
                sliderPile[i].onValueChanged += slider_onValueChanged;
                sliderPile[i].Enabled = true;

                cardPile[i].Name = Convert.ToString(i);
                cardPile[i].Size = new Size(650, 80);
                cardPile[i].Location = new Point(x, y + i * (10 + pudding));
                
                control.Controls.Add(sliderPile[i]);
                control.Controls.Add(cardPile[i]);

            }

        }

        public static void pileRefresh()
        {
            int maxPileNum = 0;
            for (int i = 0; i < common.pileCount; i++)
            {
                if (common.gamePileNum[i] > maxPileNum) { maxPileNum = common.gamePileNum[i]; }
            }

                for (int i = 0; i < common.pileCount; i++)
            {
                sliderPile[i].ValueMax = common.gamePileNum[i];
                sliderPile[i].RangeMax = maxPileNum;
                sliderPile[i].Value = common.gamePileNum[i];
                if (common.gamePileNum[i] == 0) { sliderPile[i].Enabled = false; }

            }
        }
        private static void slider_onValueChanged(object sender, int newValue)
        {
            if (common.ID != 1)
            {
                MaterialSlider change = sender as MaterialSlider;
                int pile = Convert.ToInt32(change.Name);

                int value = newValue;

                if (value == common.gamePileNum[pile])
                {
                    return;
                }
                int num = common.gamePileNum[pile] - value;
                if (common.pileLimit[pile] != 0)
                {
                    int limit = common.pileLimit[pile];
                    if (num > limit)
                    {
                        num = limit;
                    }
                }

                NimPile.NimPileAgent.gameCommandPost(2,pile,num) ;
            }

        }

        public static void resetOther (int pile ,int num) //including 0
        {
            for (int i = 0; i < common.pileCount; i++)
            {

                sliderPile[i].Value = common.gamePileNum[i];
                if (i == pile)
                {
                    sliderPile[i].Value = num;
                }
            }
            
        }

        public static void valueModify(int pile, int num) //including 0
        {
            sliderPile[pile].Value = common.gamePileNum[pile] - num;

        }

    }
}
