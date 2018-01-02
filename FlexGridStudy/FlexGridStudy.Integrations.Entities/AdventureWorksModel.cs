namespace FlexGridStudy.Integrations.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdventureWorksModel : DbContext
    {
        public AdventureWorksModel()
            : base("name=AdventureWorksModel")
        {
        }

        public virtual DbSet<ProductOverview> ProductOverviews { get; set; }
        public virtual DbSet<vProductAndDescription> vProductAndDescriptions { get; set; }
        public virtual DbSet<vProductModelCatalogDescription> vProductModelCatalogDescriptions { get; set; }
        public virtual DbSet<vProductModelInstruction> vProductModelInstructions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<ProductOverview>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<vProductAndDescription>()
                .Property(e => e.CultureID)
                .IsFixedLength();

            modelBuilder.Entity<vProductModelInstruction>()
                .Property(e => e.SetupHours)
                .HasPrecision(9, 4);

            modelBuilder.Entity<vProductModelInstruction>()
                .Property(e => e.MachineHours)
                .HasPrecision(9, 4);

            modelBuilder.Entity<vProductModelInstruction>()
                .Property(e => e.LaborHours)
                .HasPrecision(9, 4);
        }
    }
}
