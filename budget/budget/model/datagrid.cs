using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace budget.model
{
    internal class datagrid
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Money { get; set; }

        public bool isDone { get; set; }

        public DateTime Date { get; set; }

       
    }
}
