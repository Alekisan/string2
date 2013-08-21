/* 
 * Name: Alexander D. Martinez
 * Date: 11/17/09
 * Purpose: HANGMAN GAME!
 * forgot to make app restart rather than quit
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangManApp : Form
    {
        string[] wordList = { "abominable", "betwixt", "chuckle", "decadence", "enigma", "equestrian", "facetious", "fantastical", "gargantuan", "hyperbole", "zephyr" };
        string[] wordExploded;
        string[] runningResult;
        Random randomNumber = new Random();
        int pickedWord = 0;
        int chances = 6;

        public HangManApp()
        {
            InitializeComponent();

            pickedWord = randomNumber.Next(12);

            wordExploded = new string[wordList[pickedWord].Length];
            runningResult = new string[wordList[pickedWord].Length];

            for (int i = 0; i < wordExploded.Length; i++)
            {
                wordExploded[i] = wordList[pickedWord].Substring(i, 1);

                lblTheWord.Text += "_ ";
            }

            lblTheWord.Visible = true;
            lblGuessesLeft.Visible = true;
            
        }



        //button event handler
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //check if already guessed
            if (checkGuessed(txtInput.Text))
            {
                //check if chances still available
                if (chances > 0)
                {
                    //check to see if submitted leter exists in word and update word progress
                    //if comes back true then letter was not in the word and chances are decremented
                    if (checkWordList(txtInput.Text))
                    {
                        chances--;

                        if (chances == 0)
                        {
                            youLost();
                        }
                    }

                    //you won!
                    if (lblTheWord.Text == wordList[pickedWord])
                    {
                        MessageBox.Show("YOU WON!", "WINNER!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        Application.Restart();
                    }


                    //update list of leters already used
                    lblGuessedLetters.Text += txtInput.Text + " ";
                    lblGuessedLetters.Visible = true;

                }
                else
                {
                    youLost();
                }
            }
            else
            {
                MessageBox.Show("That letter was already used.", "Previously used letter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //update chances left and clear/set focus to txt box for more input
            lblGuessesLeft.Text = Convert.ToString(chances);
            txtInput.Text = "";
            txtInput.Focus();
        }

        //fills runningResult array with letters guessed correctly and updates the word progress
        private bool checkWordList(string letter)
        {
            bool result = true;
            string fillTheWord = "";

            for (int i = 0; i < wordExploded.Length; i++)
            {
                if (letter == wordExploded[i])
                {
                    runningResult[i] = wordExploded[i];
                    result = false;
                }
                else if (runningResult[i] == null)
                {
                    runningResult[i] = "_ ";
                }

                fillTheWord += runningResult[i];
            }

            lblTheWord.Text = fillTheWord;

            return result;
        }


        //checks to see if you already guessed a letter.
        private bool checkGuessed(string letter)
        {
            //todo: make it check to see if guess was part of incorrect letters.
            
            bool result = true;

            for (int i = 0; i < runningResult.Length; i++)
            {
                if (letter == runningResult[i])
                {
                    result = false;
                }
            }

            for (int i = 0; i < lblGuessedLetters.Text.Length; i++)
            {
                if (letter == lblGuessedLetters.Text.Substring(i, 1))
                {
                    result = false;
                }
            }

            return result;
        }

        //run when loosing condition is met
        private void youLost()
        {
            string msgOut;
            msgOut = "You just lost the game.\nThe word was " + wordList[pickedWord];

            picDead.Visible = true;

            MessageBox.Show(msgOut, "LOST!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            Application.Restart();
        }

    }
}
