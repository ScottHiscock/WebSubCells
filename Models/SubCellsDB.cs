using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSubCells.Models
{
    public class SubCellsDB : DbContext
    {
        public DbSet SubCellCode { get; set; }
        public DbSet SubCellHierarchy { get; set; }
    }
}