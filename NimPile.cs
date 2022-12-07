using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32.SafeHandles;
using System.Runtime.CompilerServices;

namespace NimPile
{
    public partial class NimPile : MaterialForm
    {
        public static NimPile NimPileAgent;
        public NimPile()
        {
            NimPileAgent = this;
            InitializeComponent();
            function.initialVaribles();
            pileConfig.initialPileConfig();
            playerConfig.initialPlayerConfig();

            gamePileDisplay.initialPileDisplay();
            gamePlayerDisplay.initialPileDisplay();

            nimAlgorithm.initialNimAlgorithm();

            gameDisplay.Visible = false;


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Green200, TextShade.WHITE);
        }







        private void configSave_Click(object sender, EventArgs e)
        {
            string message = function.checkData();
            switch (message)
            {
                case "0":
                    mainTab.SelectedTab = mainTab.TabPages[1];
                    common.parameterVerified = true;
                    break;
                default:
                    MaterialMessageBox.Show("------------------! Parameter ERROR !------------------\n\n\t" + message,true);
                    break;

            }
        }

        private void pileNumEntry_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (pileNumEntry.Text == "")
            {
                num = 0;

            }else if (Convert.ToInt32(pileNumEntry.Text) > common.pileMaxROW)
            {
                pileNumEntry.Text = Convert.ToString(common.pileMaxROW);
                num = common.pileMaxROW;
            }
            else { num = Convert.ToInt32(pileNumEntry.Text); }
            
            pileConfig.pileUpdate(num, pileInfoPanel,0 ,0 , 50);

        }

        private void playerNumEntry_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (playerNumEntry.Text == "")
            {
                num = 0;

            }
            else if (Convert.ToInt32(playerNumEntry.Text) > common.playerMaxROW)
            {
                playerNumEntry.Text = Convert.ToString(common.playerMaxROW);
                num = common.playerMaxROW;
            }
            else { num = Convert.ToInt32(playerNumEntry.Text); }

            playerConfig.playerUpdate(num, playerInfoPanel, 0, 0, 50);
        }

        private void resetLimit_Click(object sender, EventArgs e)
        {
            pileConfig.limitZero();
        }

        //only recieves numbers
        private void NumEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)

            {
                e.Handled = true;
            }
        }


        //start game click
        private void gameStart_Click(object sender, EventArgs e)
        {
            if (common.parameterVerified == false) { mainTab.SelectedTab = mainTab.TabPages[1]; return; }
            gameDisplay.Visible = true;

            gameStart.Enabled = false;
            gameReset.Enabled = true;


            common.currentPlayer = 0;
            common.gamePileFetch = -1;
            common.gameNumFetch = -1;

            int maxPileNum = 0;
            for(int i = 0; i < common.pileCount; i++)
            {
                common.gamePileNum[i] = common.pileNum[i];
                if (common.pileNum[i] > maxPileNum) { maxPileNum = common.pileNum[i]; }
            }

            gamePileDisplay.pileUpdate(maxPileNum, gamePileDisplayPanel,10,10,80);
            gamePlayerDisplay.playerUpdate(gamePlayerDisplayPanel,10, 10, 30);

            gameOUTPUT.Clear();
            gameOUTPUTUpdateNim();

            gameTimer.Enabled = true;
        }

        private void gameReset_Click(object sender, EventArgs e)
        {
            gameDisplay.Visible = false;

            gameStart.Enabled = true;
            gameReset.Enabled = false;

            gameTimer.Enabled = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (common.playerName[common.currentPlayer] == "%BOT")
            {
                int[] botMove = nimAlgorithm.calculateBestMove();

                common.gamePileNum[botMove[0]] -= botMove[1];

                int old = common.currentPlayer;
                common.currentPlayer++;
                if (common.currentPlayer == common.playerCount)
                {
                    common.currentPlayer = 0;
                }

                //function BOT: calculate WIN
                if (nimAlgorithm.win())
                {
                    string name = common.playerName[old];
                    MaterialMessageBox.Show(name + " wins!");
                    gameTimer.Enabled = false;

                }
                else
                {
                    
                    gamePlayerDisplay.renew(old, common.currentPlayer);

                    gamePileDisplay.pileRefresh();



                    gameOUTPUT.Clear();
                    gameOUTPUT.Text += "Bot move: \r\nPile: " + Convert.ToString(botMove[0] + 1) + "\r\nPicked: " + Convert.ToString(botMove[1] + "\r\n\r\n\r\n");
                    gameOUTPUTUpdateNim();
                }


            }
            if(common.gamePileFetch != -1 && common.gameNumFetch != -1)
            {
                
                //function BOT: calculate current NIMValue

                common.gamePileNum[common.gamePileFetch] -= common.gameNumFetch;

                common.gamePileFetch = -1;
                common.gameNumFetch = -1;

                //function BOT: calculate WIN
                if (nimAlgorithm.win())
                {
                    string name = common.playerName[common.currentPlayer];
                    MaterialMessageBox.Show(name + " wins!");
                    gameTimer.Enabled = false;
                }
                else
                {
                    gamePileDisplay.pileRefresh();

                    int old = common.currentPlayer;
                    common.currentPlayer++;
                    if (common.currentPlayer == common.playerCount)
                    {
                        common.currentPlayer = 0;
                    }
                    gamePlayerDisplay.renew(old, common.currentPlayer);


                    gameOUTPUT.Clear();
                    gameOUTPUTUpdateNim();
                }

            }

        }

        private void gameConfirm_Click(object sender, EventArgs e)
        {
            common.gamePileFetch = Convert.ToInt32(gamePileInput.Text) - 1;
            common.gameNumFetch = Convert.ToInt32(gameNumInput.Text);
        }

        public void gameCommandPost(int origin, int pile, int value)
        {
            switch (origin)
            {
                case 1: //from text
                    common.ID = 1;
                    gamePileDisplay.valueModify(pile, value);
                    common.ID = 0;
                    break;
                case 2://from slider
                    common.ID = 2;
                    gamePileInput.Text = Convert.ToString(pile + 1);
                    gameNumInput.Text = Convert.ToString(value);
                    common.ID = 0;

                    common.ID = 1;
                    gamePileDisplay.resetOther(pile,common.gamePileNum[pile] -  value);
                    common.ID = 0;
                    break;
            }

            gameOUTPUT.Clear();
            nimAlgorithm.customCalculateNimForEachPile(pile, value);
            if (common.switchNimValueView == true)
            {
                for (int i = 0; i < common.pileCount; i++)
                {
                    gameOUTPUT.Text += "Pile " + Convert.ToString(i + 1) + ": " + Convert.ToString(nimAlgorithm.customNimValues[i]) + " \r\n";
                }
                gameOUTPUT.Text += "\r\nAll:   " + Convert.ToString(nimAlgorithm.customCalculateNimForWhole()) + " \r\n";
            }
            
            
            

        }
        private void gamePileInput_TextChanged(object sender, EventArgs e)
        {
            if(common.ID != 2)
            {
                int num = 1;
                if(gamePileInput.Text != "")
                {
                    num = Convert.ToInt32(gamePileInput.Text);
                }
                if (num > common.pileCount)
                {
                    num = common.pileCount;
                }
                if (num == 0)
                {
                    num = 1;
                }
                gamePileInput.Text = Convert.ToString(num);
                gamePileDisplay.resetOther(num - 1, common.gamePileNum[num -1]);

                common.ID = 2;
                gameNumInput.Text = "1";
                common.ID = 0;
            }
        }

        private void gameNumInput_TextChanged(object sender, EventArgs e)
        {
            if (common.ID != 2)
            {
                int num = 1;            //number taken away
                if (gameNumInput.Text != "")
                {
                    num = Convert.ToInt32(gameNumInput.Text);
                }
                if (num == 0)
                {
                    num = 1;
                }

                int pile = Convert.ToInt32(gamePileInput.Text) - 1;
                if (common.pileLimit[pile] != 0)
                {
                    int limit = common.pileLimit[pile];
                    if (num > limit)
                    {
                        num = limit;
                    }
                }
                if (num > common.gamePileNum[pile])
                {
                    num = common.gamePileNum[pile];
                }

                gameNumInput.Text = Convert.ToString(num);
                gameCommandPost(1, pile, num);
            }
        }

        public void gameOUTPUTUpdateNim()
        {
            nimAlgorithm.calculateNimForEachPile();

            if (common.switchNimValueView == true)
            {
                for (int i = 0; i < common.pileCount; i++)
                {
                    gameOUTPUT.Text += "Pile " + Convert.ToString(i + 1) + ": " + Convert.ToString(nimAlgorithm.nimValues[i]) + " \r\n";
                }
                gameOUTPUT.Text += "\r\nAll:   " + Convert.ToString(nimAlgorithm.calculateNimForWhole()) + " \r\n";
            }
            
        }

        private void switchNimView_Click(object sender, EventArgs e)
        {
            MaterialSwitch changed = sender as MaterialSwitch;
            if(changed.CheckState == CheckState.Checked)
            {
                common.switchNimValueView = true;
            }
            else
            {
                common.switchNimValueView = false;
            }
            
        }
    }
}
