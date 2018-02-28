using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment2A
{
    public sealed class PanelTracker
    {
        #region Fields

        private static volatile PanelTracker instance;
        private static object syncRoot = new object();
        private Dictionary<int, int> panelPosition = new Dictionary<int, int>();
        private Dictionary<int, int> panelInitialScore = new Dictionary<int, int>();
        private List<Panel> gamePanels = new List<Panel>();
        private List<Label> panelLabelsList = new List<Label>();
        private List<int> tags = new List<int>();

        private enum PanelColour { Red, Blue, Green };
        private int panelCount = 0;
        private int x = 0;
        private int y = 0;
        private int lastX = 0;
        private int lastY = 0;
        // Create an instance of the class Player
        Player player = Player.Instance;
        // Create an instance of the class form
        
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private PanelTracker() { }
        #endregion

        #region Properties
        public static PanelTracker Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new PanelTracker();
                    }
                }
                return instance;
            }
        }
        public Dictionary<int, int> PanelPosition { get {return panelPosition; } set { panelPosition = value; } }
        public Dictionary<int, int> PanelInitialScore { get {return panelInitialScore; } set {panelInitialScore = value; } }
        public int PanelCount { get {return panelCount; } set {panelCount = value; } }
        public List<Label> PanelLabelsList { get {return panelLabelsList; } set {panelLabelsList = value; } }

        #endregion

        #region Methods
        public Panel CreatePanels(int i)
        {
            try
            {
                Panel panel;
                // for (int i = gamePanels.Count; i < 3; i++)
                // {
                panel = new Panel
                {
                    Width = GeneratePanelSize(i),
                    Height = GeneratePanelSize(i),
                    BackColor = GeneratePanelColour(i),
                    Location = GenerateRandomPosition(),
                    Tag = i.ToString()
                };
                // Add the tag to the list
                tags.Add(i);
                panel.Controls.Add(GeneratePanelLabel(i, panel));
                // }
                return panel;
            }catch(Exception ex)
            {
                return null;
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
            player.InFavour += int.Parse(label.Text);
            MessageBox.Show(player.InFavour.ToString());
        }

        /// <summary>
        /// Generates random positions of the panel
        /// </summary>
        /// <returns></returns>
        public Point GenerateRandomPosition()
        {
            // Generate a random number between 520 and 200
            int loopController;
            do
            {
                Random random = new Random();
                loopController = 0;
                lastX = x;
                lastY = y;
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                        x = random.Next(80, 500);
                    else
                        y = random.Next(80, 200);
                }
                ++loopController;

            } while (x == lastX || y == lastY);


            return new Point(x, y);
        }
        /// <summary>
        /// Generates random sizes between 40 and 80
        /// </summary>
        /// <returns></returns>
        public int GeneratePanelSize(int size)
        {
            try
            {
                ++size;
                // Generate a random number

                switch (size)
                {
                    case 1:
                        size = 40;
                        break;
                    case 2:
                        size = 60;
                        break;
                    default:
                        size = 80;
                        break;
                }
                return size;
            }catch(Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// Generates a random background colour for the pane;
        /// Between green,blue & red
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Color GeneratePanelColour(int i)
        {
            Color panelColour = new Color();
            try
            {
                ++i;
                switch (i)
                {
                    case 1:
                        panelColour = Color.Red;
                        break;
                    case 2:
                        panelColour = Color.Blue;
                        break;
                    case 3:
                        panelColour = Color.Green;
                        break;
                    default:
                        break;
                }
                return panelColour;
            }
            catch (Exception)
            {
                return new Color();
            }
        }
        /// <summary>
        /// Generate a label inside the panel
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Label GeneratePanelLabel(int i, Panel panel)
        {
            try
            {
                Random labelRandomValue = new Random();
                // 
                Label panelLabel = new Label();
                panelLabel.Text = labelRandomValue.Next(80, 101).ToString();
                panelLabel.Height = 13;
                panelLabel.Width = 20;
                panelLabel.Tag = i;
                panelLabel.Location = new Point((panel.Width / 2) - (panelLabel.Width / 2), (panel.Height / 2) - (panelLabel.Height / 2));
                // Add the label to the list
                panelLabelsList.Add(panelLabel);

                return panelLabel;
            }catch(Exception ex)
            {
                Console.WriteLine("Error: {0}",ex.Message);
                return null;
            }
        }
        #endregion
    }
}
