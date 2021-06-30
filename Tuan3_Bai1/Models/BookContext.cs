using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Tuan3_Bai1.Models
{
    public partial class BookContext : DbContext
    {
        public BookContext()
            : base("name=BookContext1")
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
