using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_DB.Classes
{
    internal class AllZvitStatics
    {
        public int Id;
        public string ZvitId;
        public double Income;
        public double NetIncome;

        public AllZvitStatics(int id, string zvitId, double income, double netIncome)
        {
            Id = id;
            ZvitId = zvitId;
            Income = income;
            NetIncome = netIncome;
        }
    }
}
