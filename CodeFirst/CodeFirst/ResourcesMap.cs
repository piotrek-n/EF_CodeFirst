using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class ResourcesMap : EntityTypeConfiguration<Resource>
    {
        public ResourcesMap()
        {
            this.ToTable("Resources","dbo");
            this.HasKey(r => new { r.Culture, r.Name });
            this.Property(r=>r.Culture).HasColumnType("VARCHAR").HasMaxLength(10);
            this.Property(r => r.Name).HasColumnType("VARCHAR").HasMaxLength(100);
            this.Property(r => r.Value).HasColumnType("VARCHAR").HasMaxLength(400);

        }
    }
}
