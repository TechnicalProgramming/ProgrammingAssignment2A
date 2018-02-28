using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2A
{
    public sealed class Player
    {
        #region Fields

        private int scoreMark = 0;
        private int inFavour = 0;
        private int against = 0;
        private int average = 0;
        private static volatile Player instance;
        private static object syncRoot = new object();

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// Singleton implemetation
        /// </summary>
        private Player() { }
        #endregion

        #region Properties
        /// <summary>
        /// Singleton property
        /// </summary>
        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Player();
                        }
                    }
                }
                return instance;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ScoreMark { get { return scoreMark; } set { scoreMark = value; } }
        /// <summary>
        /// 
        /// </summary>
        public int InFavour { get { return inFavour; } set { inFavour = value; } }
        /// <summary>
        /// 
        /// </summary>
        public int Against { get { return against; } set { against = value; } }
        /// <summary>
        /// 
        /// </summary>
        public int Average { get { return average; } set { average = value; } }
        #endregion

        #region Methods
        #endregion 
    }
}
