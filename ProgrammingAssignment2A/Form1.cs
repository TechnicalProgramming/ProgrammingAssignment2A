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
        private PanelTracker panelTracker = PanelTracker.Instance;
        private Player player = Player.Instance;
        private List<Panel> panels = new List<Panel>();
        private List<Label> labels = new List<Label>();

        public GameForm()
        {
            InitializeComponent();
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            // Create an instance of class ValidateUserInput
            ValidateUserInput validateUserInput = ValidateUserInput.Instance;
            if (!validateUserInput.ValidateGameSpeed(disappearingSpeedTextBox.Text))
                return;
            // Start the timer game timer
            gameTimer.Start();
            // start the panels timer
            panelsTimer.Start();

            // Set the interval
            panelsTimer.Interval = int.Parse(disappearingSpeedTextBox.Text);
            // Create an event handler for the timer tick event
            gameTimer.Tick += GameTimer_Tick;
            // Create an event handler for the panels timer tick event
            panelsTimer.Tick += PanelsTimer_Tick;
        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Move the progressbar
            if (gameProgressBar.Value != gameProgressBar.Maximum)
            {
                gameProgressBar.Value++;
            }
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
        /// <summary>
        /// Panel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_Click(object sender, EventArgs e)
        {
            // Grab the content of the panel
            Panel panel = (Panel)sender;
            Label label = new Label();
            label = (Label)panel.GetChildAtPoint(new Point((panel.Width / 2) - (20 / 2), (panel.Height / 2) - (13 / 2)));
            
            int tag = int.Parse(panel.Tag.ToString());
            player.InFavour += int.Parse(panelTracker.PanelLabelsList[tag].Text);
            inFavourTextBox.Text = player.InFavour.ToString();
            // Call a method to destroy the panel
            DestroyPanel(panel);

            // Call the method that creates a new panel
            CreatePanels(tag);
        }
        /// <summary>
        /// Destroys the created panel
        /// </summary>
        /// <param name="panel"></param>
        private void DestroyPanel(Panel panel)
        {
            gamePanel.Controls.Remove(panel);
        }
        /// <summary>
        /// Creates a new game panels
        /// </summary>
        /// <param name="tag"></param>
        private void CreatePanels(int tag)
        {
            //Panel panel = panelTracker.CreatePanels(tag);
            //panel.Parent = gamePanel;
            //panel.Click += Panel_Click;
            panelTracker.CreatePanels(tag);
        }

        private void scoreMarkLabel_Click(object sender, EventArgs e)
        {
            // panelTracker.CreatePanels(gamePanel);
        }

        private void gamePanel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Cursor.Position.X + ":" + Cursor.Position.Y);
        }

        private void panelsTimer_Tick(object sender, EventArgs e)
        {
            

        }
        /// <summary>
        /// Reduces the size of the panels
        /// </summary>
        /// <param name="panel"></param>
        private void ReducePanelSize(List<Panel> panels)
        {
            
            foreach (Panel panel in panels)
            {

                if (panel.Width > 21 && panel.Height > 14)
                {
                    panel.Width--;
                    panel.Height--;
                }
            }

            foreach (Label label in panelTracker.PanelLabelsList)
            {
                int value  = int.Parse(label.Text);
                label.Text = (value - 1).ToString();
            }
        }

        private void PanelsTimer_Tick(object sender, EventArgs e)
        {
            for (int i = gamePanel.Controls.Count - 1; i < 3; i++)
            {
                Panel panel = panelTracker.CreatePanels(i);
                panel.Parent = gamePanel;
                panel.Click += Panel_Click;

                panels.Add(panel);
            }
            // Call method to reduce the size of the panels
            ReducePanelSize(panels);
        }
    }
}
