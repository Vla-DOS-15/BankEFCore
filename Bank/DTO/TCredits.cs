using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DTO
{
    public class TCredits
    {
        [Key]
        public int IDCredit { get; set; }
        //public int ClientID { get; set; }
        public decimal? AmoutCredit { get; set; }
        public DateTime MyDate { get; set; }

        //public float Percentage { get; set; }
        //public DateTime DateOfIssue { get; set; }
        //public DateTime RepaymentDate { get; set; }

        // public List<TClients> CreditTClients { get; set; }  // сотрудники компании

        public virtual ICollection<TClients> CreditTClients { get; set; }

    }
}
