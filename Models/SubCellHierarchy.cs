using System;
using System.Data.Entity;

namespace WebSubCells.Models
{
    public class SubCellHierarchy
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Order { get; set; }
    }

    public class SubCellHierarchyDBContext : DbContext
    {
        public DbSet<SubCellHierarchy> SubCellHierarchy { get; set; }
    }
}