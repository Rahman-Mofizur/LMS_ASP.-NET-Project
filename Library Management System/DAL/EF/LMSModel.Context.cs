//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Library_ManagementEntities4 : DbContext
    {
        public Library_ManagementEntities4()
            : base("name=Library_ManagementEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BookList_Table> BookList_Table { get; set; }
        public DbSet<Borrowed_Book_Table> Borrowed_Book_Table { get; set; }
        public DbSet<Inventory_Table> Inventory_Table { get; set; }
        public DbSet<Librarian_table> Librarian_table { get; set; }
        public DbSet<Login_Table> Login_Table { get; set; }
        public DbSet<Occasion_Table> Occasion_Table { get; set; }
        public DbSet<Requested_Book_Table> Requested_Book_Table { get; set; }
        public DbSet<Stationary_Table> Stationary_Table { get; set; }
        public DbSet<Student_Table> Student_Table { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}
