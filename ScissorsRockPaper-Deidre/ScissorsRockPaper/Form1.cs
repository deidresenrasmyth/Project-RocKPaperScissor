﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScissorsRockPaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            HideUserImages();
            HideSystemImages();
            ShowSelectedImagesBig();
            ResetColors();
            lblPc.Visible = true;
            lblYou.Visible = true;
            lblStart.Visible = false;

            Random random = new Random();
            int num = random.Next(3);
            if (num == 0)
            {
                imgPaperSystem.Show();
            }

            if (num == 1)
            {
                imgSystemRock.Show();
            }

            if (num == 2)
            {
                imgSystemScissors.Show();
            }

            btnPlayAgaing.Show();
            btnPlay.Hide();
            DisableUserOptions();
            AnalizeResults();
        }

        private void DisableUserOptions()
        {
            imgRockUser.Enabled = false;
            imgPaperUser.Enabled = false;
            imgScissorsUser.Enabled = false;
        }

        private void EnableUserOptions()
        {
            imgRockUser.Enabled = true;
            imgPaperUser.Enabled = true;
            imgScissorsUser.Enabled = true;
            lblTitle.Visible = true;
        }

        private void ShowSelectedImagesBig()
        {
            if (imgPaperUser.BackColor == Color.PeachPuff)
            {
                BiggerPicture(imgPaperUser);
            }
            if (imgScissorsUser.BackColor == Color.PeachPuff)
            {
                BiggerPicture(imgScissorsUser);
            }
            if (imgRockUser.BackColor == Color.PeachPuff)
            {
                BiggerPicture(imgRockUser);
            }
        }

        private void BiggerPicture(PictureBox currentPicture)
        {
            currentPicture.Width = 200;
            currentPicture.Height = 200;
            currentPicture.Location = new Point(10, 99);
            currentPicture.Show();
        }

        void HideUserImages()
        {
            imgRockUser.Hide();
            imgPaperUser.Hide();
            imgScissorsUser.Hide();
            lblTitle.Visible = false;
        }

        void HideSystemImages()
        {
            imgPaperSystem.Hide();
            imgSystemRock.Hide();
            imgSystemScissors.Hide();
        }

        private void ImgNameUser_Click(object sender, EventArgs e)
        {
            ResetColors();
            btnPlay.Enabled = true;
            imgRockUser.BackColor = Color.PeachPuff;
            lblYou.Text += " Pick Rock";
        }

        private void ImgPaperUser_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            ResetColors();
            imgPaperUser.BackColor = Color.PeachPuff;
            lblYou.Text += " Pick Paper";
        }

        private void ResetColors()
        {
            imgPaperUser.BackColor = Color.Transparent;
            imgRockUser.BackColor = Color.Transparent;
            imgScissorsUser.BackColor = Color.Transparent;
        }

        private void ImgScissorsUser_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            ResetColors();
            imgScissorsUser.BackColor = Color.PeachPuff;
            lblYou.Text += " Pick Scissors";
        }

        private void BtnPlayAgaing_Click(object sender, EventArgs e)
        {
            ShowUsersImage();
            HideSystemImages();
            ResetInitialPositions();
            EnableUserOptions();
            btnPlay.Show();
            btnPlayAgaing.Hide();
            lblPc.Visible = false;
            lblYou.Visible = false;
            lblResult.Visible = false;
            btnPlay.Enabled = false;
            lblStart.Visible = true;
        }

        private void ResetInitialPositions()
        {
            imgPaperUser.Location = new Point(48, 62);
            imgPaperUser.Height = 103;
            imgPaperUser.Width = 116;

            imgScissorsUser.Location = new Point(48, 325);
            imgScissorsUser.Height = 103;
            imgScissorsUser.Width = 116;

            imgRockUser.Location = new Point(48, 191);
            imgRockUser.Height = 103;
            imgRockUser.Width = 116;

        }

        private void ShowUsersImage()
        {
            imgRockUser.Show();
            imgPaperUser.Show();
            imgScissorsUser.Show();
        }

        private void AnalizeResults()
        {
            string msg="";

            // it is a tie!
            if (imgRockUser.Visible == true && imgSystemRock.Visible == true)
            {
                msg = "It's a tie!";

            }
            if (imgPaperUser.Visible == true && imgPaperSystem.Visible == true)
            {
                msg = "It's a tie!";
            }
            if (imgScissorsUser.Visible == true && imgSystemScissors.Visible == true)
            {
                msg = "It's a tie!";
            }

            // user is the winner 
            if (imgRockUser.Visible == true && imgSystemScissors.Visible == true)
            {
                msg = "You won!";
            }
            if (imgScissorsUser.Visible == true && imgPaperSystem.Visible == true)
            {
                msg = "You won!";
            }
            if (imgPaperUser.Visible == true && imgSystemRock.Visible == true)
            {
                msg = "You won!";
            }

            // system is the winner
            if (imgPaperUser.Visible == true && imgSystemScissors.Visible == true)
            {
                msg = "PC Won!";
            }
            if (imgRockUser.Visible == true && imgPaperSystem.Visible == true)
            {
                msg = "PC Won!";
            }
            if (imgScissorsUser.Visible == true && imgSystemRock.Visible == true)
            {
                msg = "PC Won!";
            }

            lblResult.Text = msg;
            lblResult.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImgSystemScissors_Click(object sender, EventArgs e)
        {

        }
    }
}
