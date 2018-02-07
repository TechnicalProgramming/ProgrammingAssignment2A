using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment2A
{
    public sealed class ValidateUserInput
    {
        #region Fields
        private static volatile ValidateUserInput instance;
        private static object synRoot = new object();
        private int gameSpeed = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// Implement the singleton 
        /// </summary>
        private ValidateUserInput() { }
        #endregion

        #region Properties
        public static ValidateUserInput Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synRoot)
                    {
                        if (instance == null)
                            instance = new ValidateUserInput();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Methods
        public bool ValidateGameSpeed(string gameSpeed)
        {
            try
            {

                // Check that the user entered something
                if (gameSpeed.ToString().Length < 1)
                {
                    MessageBox.Show("Enter a value number between 50 and 200"); return false;
                }
                if (int.TryParse(gameSpeed, out this.gameSpeed))
                {
                    // Ensure the value is between 50 and 200
                    if (this.gameSpeed > 49 && this.gameSpeed < 201)
                        return true;
                    else
                        return false;
                }
                else
                {
                    MessageBox.Show("Enter a number between 50 and 200");
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
    }
}
