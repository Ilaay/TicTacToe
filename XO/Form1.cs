using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        string Turn = "X";
        bool somebodyAlreadyWon = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void TurnSwap()
        {
            if (Turn == "X")
            {
                Turn = "O";
            }
            else
                Turn = "X";
        }
        private void ButtonPressed()
        {
            TurnSwap();

            if (boxTurn.Text == "First player's turn")
            {
                boxTurn.Text = "Second player's turn";
            }
            else
                boxTurn.Text = "First player's turn";
        }

        private void SomebodyWon()
        {
            if (b11.Text != "" && b11.Text == b22.Text && b22.Text == b33.Text )
            {
                ButtonPressed();
                boxError.Text = "Player "+Turn+" won!";
                somebodyAlreadyWon = true;
            }
            else if (b31.Text != "" && b31.Text == b22.Text && b22.Text == b13.Text)
            {
                ButtonPressed();
                boxError.Text = "Player " + Turn + " won!";
                somebodyAlreadyWon = true;
            }
            else if(b11.Text != "" && b11.Text == b12.Text && b12.Text == b13.Text)
            {
                ButtonPressed();
                boxError.Text = "Player " + Turn + " won!";
                somebodyAlreadyWon = true;
            }
            else if (b21.Text != "" && b21.Text == b22.Text && b22.Text == b23.Text)
            {
                ButtonPressed();
                boxError.Text = "Player " + Turn + " won!";
                somebodyAlreadyWon = true;
            }
            else if (b13.Text != "" && b13.Text == b23.Text && b23.Text == b33.Text)
            {
                ButtonPressed();
                boxError.Text = "Player " + Turn + " won!";
                somebodyAlreadyWon = true;
            }
            else if (b31.Text != "" && b31.Text == b32.Text && b32.Text == b33.Text)
            {
                ButtonPressed();
                boxError.Text = "Player " + Turn + " won!";
                somebodyAlreadyWon = true;
            }
            else if (b11.Text != "" && b11.Text == b21.Text && b21.Text == b31.Text)
            {
                ButtonPressed();
                boxError.Text = "Player " + Turn + " won!";
                somebodyAlreadyWon = true;
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (b11.Text == "" && somebodyAlreadyWon == false)
            {
                b11.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.Text == "" && somebodyAlreadyWon == false)
            {
                b12.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (b13.Text == "" && somebodyAlreadyWon == false)
            {
                b13.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (b21.Text == "" && somebodyAlreadyWon == false)
            {
                b21.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (b22.Text == "" && somebodyAlreadyWon == false)
            {
                b22.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b23_Click(object sender, EventArgs e)
        {
            if (b23.Text == "" && somebodyAlreadyWon == false)
            {
                b23.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b31_Click(object sender, EventArgs e)
        {
            if (b31.Text == "" && somebodyAlreadyWon == false)
            {
                b31.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b32_Click(object sender, EventArgs e)
        {
            if (b32.Text == "" && somebodyAlreadyWon == false)
            {
                b32.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void b33_Click(object sender, EventArgs e)
        {
            if (b33.Text == "" && somebodyAlreadyWon == false)
            {
                b33.Text = Turn;
                ButtonPressed();
                SomebodyWon();
            }
        }

        private void bRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
