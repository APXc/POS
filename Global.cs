using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_PointOfSales
{

    static class Global
    {
        private static bool _isLoged = false;
        private static getSettings _settings = null;
        private static user _user = null;
        private static Company _company = null;

        public static bool Loged
        {
            get { return _isLoged; }
            set { _isLoged = value; }
        }

        public static getSettings settings
        {
            get { return _settings; }
            set { _settings = value; }
        }
        public static user user
        {
            get { return _user; }
            set { _user = value; }
        }

        public static Company company
        {
            get { return _company; }
            set { _company = value; }
        }
    }


}
