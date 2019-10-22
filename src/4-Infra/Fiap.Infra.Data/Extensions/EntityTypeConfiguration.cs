using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Infra.Data.Extensions
{
    public abstract class EntityTypeConfiguration<T> where T : class
    {
        public abstract void Map(EntityTypeBuilder<T> builder);
    }
}
