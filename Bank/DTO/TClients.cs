using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DTO
{
    public class TClients
    {
        [Key]
        public int IDClient { get; set; }
        public string Surname { get; set; }
        //public DateTime MMyDate { get; set; }
        //public string GivenName { get; set; }
        //public string Patronymic { get; set; }
        //public string Passport { get; set; }
        public List<TCredits> Credits { get; set; }
        public List<TDeposits> Deposits { get; set; }

        //     [ForeignKey("TCredits")]
        //      public int? CreditId { get; set; }
        //public TCredits Credit { get; set; }

        //    [ForeignKey("TDeposits")]
        //    public int? DepositId { get; set; }
        // public TDeposits Deposit { get; set; }
        //  [Key]
        //  public int IDClient { get; set; }
        //  public string Surname { get; set; }
        //  //public DateTime MMyDate { get; set; }
        //  //public string GivenName { get; set; }
        //  //public string Patronymic { get; set; }
        //  //public string Passport { get; set; }

        ////  public List<TClients> CreditTClients { get; set; }
        //  //public List<TClients> CreditTClients { get; set; }
        //  public virtual ICollection<TCredits> CreditTClients { get; set; }
        //  public virtual ICollection<TDeposits> DepositsTClients { get; set; }




    }
}