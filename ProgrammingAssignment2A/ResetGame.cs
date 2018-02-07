using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment2A
{
    public sealed class ResetGame
    {
        #region Fields
        private static volatile ResetGame instance;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor,
        /// Call cannot be instantiated
        /// </summary>
        private ResetGame() { }
        #endregion

        #region Properties
        /// <summary>
        /// Singleton implementation
        /// </summary>
        public static ResetGame Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new ResetGame();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Methods
        public bool ResetProgressBar(VerticalProgressBar gameProgressBar)
        {
            try
            {
                gameProgressBar.Value = 0;
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
    }
}
