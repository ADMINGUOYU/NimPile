using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimPile
{
    public class pileConfig
    {   
        public static MaterialLabel[] labelPileNo;

        public static MaterialTextBox[] textPileNum;
        public static MaterialTextBox[] textPileLimit;

        public static MaterialDivider[] divPile;

        public static MaterialLabel[] labelDescription1;
        public static MaterialLabel[] labelDescription2;

        public static void initialPileConfig()
        {
            labelPileNo = new MaterialLabel[common.pileMaxROW];
            textPileNum = new MaterialTextBox[common.pileMaxROW];
            textPileLimit = new MaterialTextBox[common.pileMaxROW];
            divPile = new MaterialDivider[common.pileMaxROW];

            labelDescription1 = new MaterialLabel[common.playerMaxROW];
            labelDescription2 = new MaterialLabel[common.playerMaxROW];

            for (int i = 0; i < common.pileMaxROW; i++)
            {
                common.pileNum[i] = 0;
                common.pileLimit[i] = 0;
            }
        }
        public static void pileUpdate(int num, Control control, int x, int y, int pudding)
        {
            //indicated data has changed
            common.parameterVerified = false;
            //reset array
            for (int i = 0; i < common.pileMaxROW; i++)
            {
                common.pileNum[i] = 0;
                common.pileLimit[i] = 0;
            }

            int old = common.pileCount;

            //remove old resources
            for (int i = 0; i < old; i++)
            {
                control.Controls.Remove(labelPileNo[i]);
                control.Controls.Remove(textPileNum[i]);
                control.Controls.Remove(textPileLimit[i]);
                control.Controls.Remove(divPile[i]);

                control.Controls.Remove(labelDescription1[i]);
                control.Controls.Remove(labelDescription2[i]);
            }

            //add new list
            for (int i = 0; i < num; i++)
            {
                labelPileNo[i] = new MaterialLabel();
                textPileNum[i] = new MaterialTextBox();
                textPileLimit[i] = new MaterialTextBox();
                divPile[i] = new MaterialDivider();
                labelDescription1[i] = new MaterialLabel();
                labelDescription2[i] = new MaterialLabel();

                divPile[i].Name = i.ToString();
                divPile[i].Size = new Size(600, 3);
                divPile[i].Location = new Point(x, y + i * (10 + pudding));

                labelPileNo[i].Name = Convert.ToString(i);
                labelPileNo[i].Text = Convert.ToString(i + 1);
                labelPileNo[i].Size = new Size(40, 40);
                labelPileNo[i].Location = new Point(x, 9 + y + i * (10 + pudding));
                labelPileNo[i].TextAlign = ContentAlignment.MiddleCenter;
                labelPileNo[i].FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
                labelPileNo[i].HighEmphasis = true;

                labelDescription1[i].Name = Convert.ToString(i);
                labelDescription1[i].Text = "? How Much ->";
                labelDescription1[i].Size = new Size(120, 20);
                labelDescription1[i].Location = new Point(x + 50, 20 + y + i * (10 + pudding));
                labelDescription1[i].TextAlign = ContentAlignment.MiddleCenter;
                labelDescription1[i].FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
                labelDescription1[i].HighEmphasis = true;

                textPileNum[i].Name = Convert.ToString(i);
                textPileNum[i].Text = "";
                textPileNum[i].Size = new Size(100, 10);
                textPileNum[i].Location = new Point(x + 210, 8 + y + i * (10 + pudding));
                //textPileNum[i].PrefixSuffix = MaterialTextBox.PrefixSuffixTypes.Prefix;
                //textPileNum[i].PrefixSuffixText = "How Much?";
                //textPileNum[i].SelectionAlignment = HorizontalAlignment.Right;
                textPileNum[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumKeyPress);
                textPileNum[i].TextChanged += new EventHandler(PileNumChanged);

                labelDescription2[i].Name = Convert.ToString(i);
                labelDescription2[i].Text = "? Limitation ->";
                labelDescription2[i].Size = new Size(120, 20);
                labelDescription2[i].Location = new Point(x + 340, 20 + y + i * (10 + pudding));
                labelDescription2[i].TextAlign = ContentAlignment.MiddleCenter;
                labelDescription2[i].FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
                labelDescription2[i].HighEmphasis = true;

                textPileLimit[i].Name = Convert.ToString(i);
                textPileLimit[i].Text = "";
                textPileLimit[i].Size = new Size(100, 10);
                textPileLimit[i].Location = new Point(x + 500, 8 + y + i * (10 + pudding));
                textPileLimit[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumKeyPress);
                textPileLimit[i].TextChanged += new EventHandler(PileLimitChanged);


                control.Controls.Add(divPile[i]);
                control.Controls.Add(labelPileNo[i]);
                control.Controls.Add(textPileNum[i]);
                control.Controls.Add(textPileLimit[i]);
                control.Controls.Add(labelDescription1[i]);
                control.Controls.Add(labelDescription2[i]);

            }
            common.pileCount = num;

        }

        public static void limitZero()
        {
            //indicated data has changed
            common.parameterVerified = false;

            for (int i = 0; i < common.pileCount; i++)
            {
                textPileLimit[i].Text = "";
            }
            for (int i = 0; i < common.pileMaxROW; i++)
            {
                common.pileLimit[i] = 0;
            }
        }


        public static void NumKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)

            {
                e.Handled = true;
            }
        }

        public static void PileLimitChanged(object sender, EventArgs e)
        {
            //indicated data has changed
            common.parameterVerified = false;

            MaterialTextBox changed = sender as MaterialTextBox;
            int updateValue;
            if (changed.Text == "")
            {
                updateValue = 0;

            }
            else if (Convert.ToInt32(changed.Text) > common.pileNum[Convert.ToInt32(changed.Name)])
            {
                updateValue = common.pileNum[Convert.ToInt32(changed.Name)];
                changed.Text = Convert.ToString(updateValue);

            }
            else { updateValue = Convert.ToInt32(changed.Text); }

            
            common.pileLimit[Convert.ToInt32(changed.Name)] = updateValue;
           
        }
        public static void PileNumChanged(object sender, EventArgs e)
        {
            //indicated data has changed
            common.parameterVerified = false;

            MaterialTextBox changed = sender as MaterialTextBox;
            string name = changed.Name;

            int updateValue;
            if (changed.Text == "")
            {
                updateValue = 0;

            }
            else if (Convert.ToInt32(changed.Text) > common.pileMaxNum)
            {
                updateValue = common.pileMaxNum;
                changed.Text = Convert.ToString(updateValue);

            }
            else { updateValue = Convert.ToInt32(changed.Text); }


            common.pileNum[Convert.ToInt32(changed.Name)] = updateValue;
        }
    }
}
