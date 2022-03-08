using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DTO
{
    public class TDeposits
    {
        [Key]
        public int IDDeposit { get; set; }
        public int AccountNumber { get; set; }
        public decimal AmountDeposit { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
      //  [ForeignKey("TClients")]
      //  public int ClientID { get; set; }
      //  public TDeposits Deposits { get; set; }
        //  public int ClientID { get; set; }
        // public TClients ClientRef { get; set; }
        // public List<TClients> DepositsTClients { get; set; } // сотрудники компании

      //  public virtual ICollection<TClients> DepositsTClients { get; set; }
        // [Key]
        // public int IDDeposit { get; set; }
        //// public int ClientID { get; set; }
        // public int AccountNumber { get; set; }
        // public decimal AmountDeposit { get; set; }

        // [ForeignKey("TClients")]
        // public int? ClientId { get; set; }
        // public TDeposits Deposit { get; set; }
        // //public DateTime StartDate { get; set; }
        // //public DateTime EndDate { get; set; }

        // //  public int ClientID { get; set; }
        // // public TClients ClientRef { get; set; }
        // // public List<TClients> DepositsTClients { get; set; } // сотрудники компании

        // // public virtual ICollection<TClients> DepositsTClients { get; set; }

    }
}
