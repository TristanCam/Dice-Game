﻿#region using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace WindowsGame
{
    public partial class Form1 : Form
    {
        #region Declaration

        Image[] diceImages;

        Player player1, player2;


        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player1 = new Player("Player 1");
            player2 = new Player("Player 2");

            lbl_p1Name.Text = player1.Name;
            lbl_p2Name.Text = player2.Name;

            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice_blank;
            diceImages[1] = Properties.Resources.dice_1;
            diceImages[2] = Properties.Resources.dice_2;
            diceImages[3] = Properties.Resources.dice_3;
            diceImages[4] = Properties.Resources.dice_4;
            diceImages[5] = Properties.Resources.dice_5;
            diceImages[6] = Properties.Resources.dice_6;

            
        }

        #endregion

        #region Private Methods

        private void btn_p1rolldice_Click(object sender, EventArgs e)
        {
            if (!player1.Played)
            {
                player1.RollDice();

                lbl_p1Dice1.Image = diceImages[player1.Dice[0]];
                lbl_p1Dice2.Image = diceImages[player1.Dice[1]];
                lbl_p1Dice3.Image = diceImages[player1.Dice[2]];
                lbl_p1Dice4.Image = diceImages[player1.Dice[3]];
                lbl_p1Dice5.Image = diceImages[player1.Dice[4]];
                lbl_p1displayResults.Text = player1.Result;

                player1.Played = true;

                CheckWinner();

            }
        }

        private void btn_p2rolldice_Click(object sender, EventArgs e)
        {
            if (!player2.Played)
            {
                player2.RollDice();

                lbl_p2Dice1.Image = diceImages[player2.Dice[0]];
                lbl_p2Dice2.Image = diceImages[player2.Dice[1]];
                lbl_p2Dice3.Image = diceImages[player2.Dice[2]];
                lbl_p2Dice4.Image = diceImages[player2.Dice[3]];
                lbl_p2Dice5.Image = diceImages[player2.Dice[4]];
                lbl_p2displayResults.Text = player2.Result;

                player2.Played = true;

                CheckWinner();
            }
        }

        private void CheckWinner()
        {
            if (player1.Played && player2.Played)
            {
                if (player1.HandRank > player2.HandRank)
                {
                    lbl_winnerResult.Text = player1.Name + " wins!";
                }
                else if (player2.HandRank > player1.HandRank)
                {
                    lbl_winnerResult.Text = player2.Name + " wins!";
                }
                else if (player1.HandRank == 8 && player2.HandRank == 8)
                {
                    if (player1.Mod1 > player2.Mod1 &&
                        player1.Mod2 > player2.Mod2)
                    {
                        lbl_winnerResult.Text = player1.Name + " wins!";
                    }
                    else if (player1.Mod2 > player2.Mod1 &&
                             player1.Mod2 > player2.Mod2)
                    {
                        lbl_winnerResult.Text = player1.Name + " wins!";
                    }
                    else if (player1.Mod1 == player2.Mod1 &&
                             player1.Mod2 == player2.Mod2 ||
                             player1.Mod2 == player2.Mod1 &&
                             player1.Mod1 == player2.Mod2)
                    {
                        if (player1.Mod3 > player2.Mod3)
                        {
                            lbl_winnerResult.Text = player1.Name + " wins!";
                        }
                        else if (player2.Mod3 > player1.Mod3)
                        {
                            lbl_winnerResult.Text = player2.Name + " wins!";
                        }
                        else
                        {
                            lbl_winnerResult.Text = player1.Name + " and " + player2.Name + " TIE!";
                        }
                    }
                }
                else if (player1.HandRank == player2.HandRank)
                {
                    if (player1.Mod1 > player2.Mod1)
                        lbl_winnerResult.Text = player1.Name + " wins!";
                    else if (player2.Mod1 > player1.Mod1)
                        lbl_winnerResult.Text = player2.Name + " wins!";
                    else if (player1.Mod1 == player2.Mod1)
                    {
                        if (player1.Mod2 > player2.Mod2)
                            lbl_winnerResult.Text = player1.Name + " wins!";
                        else if (player2.Mod2 > player1.Mod2)
                            lbl_winnerResult.Text = player2.Name + " wins!";
                        else if (player1.Mod1 == player2.Mod1)
                        {
                            if (player1.Mod2 > player2.Mod2)
                                lbl_winnerResult.Text = player1.Name + " wins!";
                            else if (player2.Mod2 > player1.Mod2)
                                lbl_winnerResult.Text = player2.Name + " wins!";
                            else if (player1.Mod1 == player2.Mod2)
                                lbl_winnerResult.Text = player1.Name + " and " + player2.Name + " TIE!";
                        }
                    }
                }
                player1.resetPlayer();
                player2.resetPlayer();
            }
            else if (player1.Played && !player2.Played)
                lbl_winnerResult.Text = "Waiting for " + player2.Name + " to roll";
            else if (player2.Played && !player1.Played)
                lbl_winnerResult.Text = "Waiting for " + player1.Name + " to roll";
        }

        #endregion
    }
}