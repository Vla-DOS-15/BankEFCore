using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bank.DTO;

namespace Bank
{
    public partial class Form1 : Form
    {
        public static ApplicationContext db;
        public static DbContextOptionsBuilder<ApplicationContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>(); 
        
        public Form1()
        {
            InitializeComponent();
            //textBox1.Text = dateTimePicker1.Value.ToString();
            

        }
        public static DbContextOptions<ApplicationContext> UseSQLServerString()
        {
            DbContextOptions<ApplicationContext> options = optionsBuilder
                    .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;")
                    .Options;
            return options;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // try
           // {
                using (db = new ApplicationContext(UseSQLServerString()))
                {

                    MessageBox.Show("Connected good!1");
                    TCredits creditDTO = new TCredits
                    {
                        AmoutCredit = 55,
                        MyDate = dateTimePicker1.Value
                    };
                db.Credits.Add(creditDTO);
                db.SaveChanges();
                TClients clientDTO = new TClients
                    {
                        Surname = "Кім",
                        CreditId = creditDTO.IDCredit
                        //MyDate = dateTimePicker1.Value
                    };
                    db.Clients.Add(clientDTO);
                    db.SaveChanges();

                    MessageBox.Show("Connected good!");
                    var result = db.Clients.Include(x => x.Credit).FirstOrDefault();

                    textBox1.Text = result.Credit.MyDate.ToString();
                    MessageBox.Show("Connected good!1");

                   // textBox1.Text = result.ToString();


                }
           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.Message.ToString());
           // }
        }
    }
}
