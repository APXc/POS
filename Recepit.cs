using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Data.Common;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Pos_PointOfSales
{
    class Recepit
    {
        public int id { get; set; }
        public List<article> articles { get; set; }
        public DateTime dateTime { get; set; }
        public costumer costumer { get; set; }
        public Decimal count { get; set; }
        public Discount discount { get; set; }

    }
}
