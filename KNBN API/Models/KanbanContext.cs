using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KNBN_API.Models
{
    public class KanbanContext : DbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            //Unique Email Required
            modelbuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // many to many

            modelbuilder.Entity<Group_Boards>().HasKey(gb => new { gb.GroupId, gb.BoardId });
            modelbuilder.Entity<Card_labels>().HasKey(cl => new { cl.CardId, cl.LabelId});
            modelbuilder.Entity<Group_Member>().HasKey(gm => new {gm.GropId, gm.UserId });

        }

        //DBSets
        public DbSet<User> Users { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Labels> Labels { get; set; }
        public DbSet<Board_Members> Board_Members { get; set; }
        public DbSet<Permission_Members> Permission_Members { get; set; }
        public DbSet<Group_Member> Group_Members { get; set; }



        // DbSets many to many
        public DbSet<Group_Boards> Group_Boards { get; set; }
        public DbSet<Card_labels> Card_Labels { get; set; }

    }
}
