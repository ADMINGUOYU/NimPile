using MaterialSkin.Controls;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimPile
{
    public class gamePlayerDisplay
    {
        public static MaterialLabel[] namePlayer;
        public static MaterialCard[] cardPlayer;

        public static void initialPileDisplay()
        {
            namePlayer = new MaterialLabel[common.playerMaxROW];
            cardPlayer = new MaterialCard[common.playerMaxROW];
        }
        public static void playerUpdate(Control control, int x, int y, int pudding)
        {

            //remove old resources
            for (int i = 0; i < common.playerMaxROW; i++)
            {
                control.Controls.Remove(namePlayer[i]);
                control.Controls.Remove(cardPlayer[i]);
            }

            //add new list
            for (int i = 0; i < common.playerCount; i++)
            {
                namePlayer[i] = new MaterialLabel();
                cardPlayer[i] = new MaterialCard();

                if (i == 0)
                {
                    namePlayer[i].FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
                }
                else { namePlayer[i].FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis; }
                namePlayer[i].Name = Convert.ToString(i);
                namePlayer[i].Text = common.playerName[i];
                namePlayer[i].Size = new Size(100, 60);
                namePlayer[i].Location = new Point(x +10 + i * (100 + pudding), y+10);
                namePlayer[i].TextAlign = ContentAlignment.MiddleCenter;


                cardPlayer[i].Name = Convert.ToString(i);
                cardPlayer[i].Size = new Size(120, 80);
                cardPlayer[i].Location = new Point(x + i * (100 + pudding), y);

                control.Controls.Add(namePlayer[i]);
                control.Controls.Add(cardPlayer[i]);

            }

        }

        public static void renew(int old, int following)
        {
            namePlayer[following].FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            namePlayer[old].FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
        }



    }
}
