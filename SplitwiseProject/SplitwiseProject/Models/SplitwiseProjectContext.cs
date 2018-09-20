using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseProject.Models
{
    public class SplitwiseProjectContext:DbContext
    {
        public SplitwiseProjectContext()
        {
        }

        public SplitwiseProjectContext(DbContextOptions<SplitwiseProjectContext> options)
        : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillCatagory> BillCatagories { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Friends> Friends { get; set; }
        public DbSet<Owes> Owes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMode> PaymentModes { get; set; }
        public DbSet<SattleUp> SattleUps { get; set; }
        public DbSet<Repeats> Repeats { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Shared> Shareds { get; set; }
        public DbSet<CatagoryOption> CatagoryOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }

}
