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
    public class playerConfig
    {
        public static MaterialLabel[] labelPlayerNo;

        public static MaterialTextBox[] textPlayerName;
        public static MaterialSwitch[] switchPlayerBotEnable;

        public static MaterialDivider[] divPlayer;

        public static MaterialLabel[] labelDescription3;

        public static void initialPlayerConfig()
        {
            labelPlayerNo = new MaterialLabel[common.playerMaxROW];
            textPlayerName = new MaterialTextBox[common.playerMaxROW];
            switchPlayerBotEnable = new MaterialSwitch[common.playerMaxROW];
            divPlayer = new MaterialDivider[common.playerMaxROW];

            labelDescription3 = new MaterialLabel[common.playerMaxROW];


            for (int i = 0; i < common.playerMaxROW; i++)
            {
                common.playerName[i] = "";
            }
        }
        public static void playerUpdate(int num, Control control, int x, int y, int pudding)
        {   
            //indicated data has changed
            common.parameterVerified = false;
            //reset array
            //for (int i = 0; i < common.playerMaxROW; i++)
            //{
            //    common.playerName[i] = "";
            //}

            int old = common.playerCount;

            //remove old resources
            for (int i = 0; i < old; i++)
            {
                control.Controls.Remove(labelPlayerNo[i]);
                control.Controls.Remove(textPlayerName[i]);
                control.Controls.Remove(switchPlayerBotEnable[i]);
                control.Controls.Remove(divPlayer[i]);

                control.Controls.Remove(labelDescription3[i]);
            }

            //add new list
            for (int i = 0; i < num; i++)
            {
                labelPlayerNo[i] = new MaterialLabel();
                textPlayerName[i] = new MaterialTextBox();
                switchPlayerBotEnable[i] = new MaterialSwitch();
                divPlayer[i] = new MaterialDivider();
                labelDescription3[i] = new MaterialLabel();

                divPlayer[i].Name = i.ToString();
                divPlayer[i].Size = new Size(600, 3);
                divPlayer[i].Location = new Point(x, y + i * (10 + pudding));

                labelPlayerNo[i].Name = Convert.ToString(i);
                labelPlayerNo[i].Text = Convert.ToString(i + 1);
                labelPlayerNo[i].Size = new Size(40, 40);
                labelPlayerNo[i].Location = new Point(x, 9 + y + i * (10 + pudding));
                labelPlayerNo[i].TextAlign = ContentAlignment.MiddleCenter;
                labelPlayerNo[i].FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
                labelPlayerNo[i].HighEmphasis = true;

                labelDescription3[i].Name = Convert.ToString(i);
                labelDescription3[i].Text = "? Name ->";
                labelDescription3[i].Size = new Size(120, 20);
                labelDescription3[i].Location = new Point(x + 50, 20 + y + i * (10 + pudding));
                labelDescription3[i].TextAlign = ContentAlignment.MiddleCenter;
                labelDescription3[i].FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
                labelDescription3[i].HighEmphasis = true;

                textPlayerName[i].Name = Convert.ToString(i);
                if (common.playerName[i] == "%BOT")
                {
                    textPlayerName[i].Text = "BOT";
                    textPlayerName[i].Enabled = false;
                }
                else
                {
                    textPlayerName[i].Text = common.playerName[i];
                }
                textPlayerName[i].Size = new Size(100, 10);
                textPlayerName[i].Location = new Point(x + 210, 8 + y + i * (10 + pudding));
                textPlayerName[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumCharKeyPress);
                textPlayerName[i].TextChanged += new EventHandler(PlayerNameChanged);

                switchPlayerBotEnable[i].Name = Convert.ToString(i);
                if (common.playerName[i] == "%BOT")
                {
                    switchPlayerBotEnable[i].CheckState = CheckState.Checked;
                }
                switchPlayerBotEnable[i].Text = "<- ?Use Bot";
                switchPlayerBotEnable[i].Size = new Size(200, 40);
                switchPlayerBotEnable[i].Location = new Point(x + 400, 8 + y + i * (10 + pudding));
                switchPlayerBotEnable[i].Click += new EventHandler(switchBotChanged);


                control.Controls.Add(divPlayer[i]);
                control.Controls.Add(labelPlayerNo[i]);
                control.Controls.Add(textPlayerName[i]);
                control.Controls.Add(switchPlayerBotEnable[i]);
                control.Controls.Add(labelDescription3[i]);

                common.playerCount = num;
            }
            common.playerCount = num;
        }



        public static void NumCharKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
        || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;//这可以输入
            }
            else
            {
                e.Handled = true;//不能输入
            }
        }

        public static void PlayerNameChanged(object sender, EventArgs e)
        {
            //indicated data has changed
            common.parameterVerified = false;

            MaterialTextBox changed = sender as MaterialTextBox;
            string name = changed.Name;
            int num = Convert.ToInt32(changed.Name);
            if (common.playerName[num] != "%BOT")
            {
                common.playerName[Convert.ToInt32(changed.Name)] = changed.Text;
            }
            
        }

        public static void switchBotChanged(object sender, EventArgs e)
        {
            //indicated data has changed
            common.parameterVerified = false;

            MaterialSwitch changed = sender as MaterialSwitch;
            int num = Convert.ToInt32(changed.Name);

            if (changed.CheckState == CheckState.Checked) 
            {
                textPlayerName[num].Text = "BOT";
                textPlayerName[num].Enabled = false;

                common.playerName[num] = "%BOT";
            }
            else
            {
                textPlayerName[num].Text = "";
                textPlayerName[num].Enabled = true;

                common.playerName[num] = "";
            }
        }
    }
}
