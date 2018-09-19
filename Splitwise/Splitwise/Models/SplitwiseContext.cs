using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.Models
{
    public class SplitwiseContext:DbContext
    {
        public SplitwiseContext(DbContextOptions<SplitwiseContext> options)
        : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Balance> balances { get; set; }
        public DbSet<Bill> bills { get; set; }
        public DbSet<BillCatagory> BillCatagories { get; set; }
        public DbSet<Activity> activities { get; set; }
        public DbSet<Friends> friends { get; set; }
        public DbSet<Owes> owes { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<PaymentMode> paymentModes { get; set; }
        public DbSet<SattleUp> sattleUps { get; set; }
        public DbSet<Repeats> repeats { get; set; }
        public DbSet<Reminder> reminders { get; set; }
        public DbSet<Shared> shareds { get; set; }
        public DbSet<CatagoryOption> catagoryOptions { get; set; }
    }
}
