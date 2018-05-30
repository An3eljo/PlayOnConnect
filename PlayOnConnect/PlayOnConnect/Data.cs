using System;
using System.Collections.Generic;
using System.Text;
using E.Deezer;

namespace PlayOnConnect
{
    public sealed class Data
    {
        #region Singleton

        private static volatile Data _instance;
        private static object locker = new object();

        public static Data Instance
        {
            get
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Data();
                    }
                }
                return _instance;
            }
        }

        #endregion

        #region Public's

        public Deezer Deezer = DeezerSession.CreateNew();

        #endregion
    }
}
