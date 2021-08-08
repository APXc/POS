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
        public DateTime dateTime { get; set; }
        public costumer costumer { get; set; }
        public Decimal count { get; set; }
        public Discount discount { get; set; }
        public Payment payment { get; set; }
        public List<RecepitRow> row { get; set; }

        public void Add()
        {

        }

        public void Update()
        {

        }
 
    }

    class RecepitRow
    {
        public int id { get; set; }
        public int fatherID { get; set; }
        public article article { get; set; }
        public int qta { get; set; }
        public Invectory Invectory { get; set; }
        public decimal value { get; set; }
        public decimal valuetotax { get; set; }

        public void Add()
        {

        }

        public void Update()
        {

        }
    }
}
