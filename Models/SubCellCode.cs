using System;
using System.Data.Entity;

namespace WebSubCells.Models
{
    public class SubCellCode
    {
        public int ID { get; set; }
        public int SubCellHierarchyID { get; set; }
        public string Name { get; set; }
    }

    public class SubCellCodeDBContext : DbContext
    {
        public DbSet<SubCellCode> SubCellCode { get; set; }
    }
}