using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment2A
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            // Create a vertical progress bar
            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            // Create an instance of class ValidateUserInput
            ValidateUserInput validateUserInput = ValidateUserInput.Instance;
            if (!validateUserInput.ValidateGameSpeed(disppearingSpeedTextBox.Text))
                return;
            // Start the timer
            gameTimer.Start();
            // Set the interval
            gameTimer.Interval = 1000;
            // Create an event handler for the timer tick event
            gameTimer.Tick += GameTimer_Tick;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Move the progressbar
            if (gameProgressBar.Value != gameProgressBar.Maximum)
                gameProgressBar.Value++;
            else
            {
                // Stop the timer
                gameTimer.Stop();
                // Get the user clikced button
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Do you want to stop grabbing marks?", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                {
                    // Create an instance of the class ResetGame
                    ResetGame resetGame = ResetGame.Instance;
                    // Reset the progress bars
                    resetGame.ResetProgressBar(gameProgressBar);
                    gameTimer.Start();
                }
                else
                {
                    // Reset everything
                    // Display a closing form
                    EndProgramForm endProgramForm = new EndProgramForm();
                    GameForm gameForm = new GameForm();
                    endProgramForm.ShowDialog();
                    // Close the form
                    this.Close();

                }
            }

        }
    }
}
