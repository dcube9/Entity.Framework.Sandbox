// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, EntityFramework 7.0 Relationships Samples");

using (var context = new EntityFramework.V70.Relationships.OneToOneRequired.BlogContext0()) { CreateDatabase(context); }
using (var context = new EntityFramework.V70.Relationships.OneToOneRequired.BlogContext1()) { CreateDatabase(context); }
using (var context = new EntityFramework.V70.Relationships.OneToOneRequired.BlogContext2()) { CreateDatabase(context); }

using (var context = new EntityFramework.V70.Relationships.OneToOneOptional.BlogContext0()) { CreateDatabase(context); }
using (var context = new EntityFramework.V70.Relationships.OneToOneOptional.BlogContext1()) { CreateDatabase(context); }
using (var context = new EntityFramework.V70.Relationships.OneToOneOptional.BlogContext2()) { CreateDatabase(context); }

/*
using (var context = new OneToOne.Required.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.Required.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.Required.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.Optional.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.Optional.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.Optional.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredPkToPk.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredPkToPk.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredPkToPk.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithShadowFk.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFk.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFk.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalWithShadowFk.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFk.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFk.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredNoNavigationToPrincipal.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredNoNavigationToPrincipal.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredNoNavigationToPrincipal.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalNoNavigationToPrincipal.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalNoNavigationToPrincipal.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalNoNavigationToPrincipal.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigationToPrincipal.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigationToPrincipal.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigationToPrincipal.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalWithShadowFkAndNoNavigationToPrincipal.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkAndNoNavigationToPrincipal.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkAndNoNavigationToPrincipal.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredNoNavigationToDependents.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredNoNavigationToDependents.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredNoNavigationToDependents.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalNoNavigationToDependents.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalNoNavigationToDependents.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalNoNavigationToDependents.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigationToDependents.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigationToDependents.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigationToDependents.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalWithShadowFkAndNoNavigationToDependents.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkAndNoNavigationToDependents.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkAndNoNavigationToDependents.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredNoNavigations.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredNoNavigations.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredNoNavigations.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalNoNavigations.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalNoNavigations.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalNoNavigations.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigations.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigations.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigations.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigations.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigations.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkAndNoNavigations.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithAlternateKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithAlternateKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithAlternateKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalWithAlternateKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithAlternateKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithAlternateKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithShadowFkWithAlternateKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkWithAlternateKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkWithAlternateKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalWithShadowFkWithAlternateKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkWithAlternateKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkWithAlternateKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithCompositeKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithCompositeKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithCompositeKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalWithCompositeKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithCompositeKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithCompositeKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithShadowFkWithCompositeKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkWithCompositeKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithShadowFkWithCompositeKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.OptionalWithShadowFkWithCompositeKey.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkWithCompositeKey.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.OptionalWithShadowFkWithCompositeKey.BlogContext2()) { CreateDatabase(context); }

using (var context = new OneToOne.SelfReferencing.PersonContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.SelfReferencing.PersonContext1()) { CreateDatabase(context); }

using (var context = new OneToOne.RequiredWithoutCascadeDelete.BlogContext0()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithoutCascadeDelete.BlogContext1()) { CreateDatabase(context); }
using (var context = new OneToOne.RequiredWithoutCascadeDelete.BlogContext2()) { CreateDatabase(context); }
*/

//
// Con la migrazione preparata crea anche le tabelle del DB
// 
//using (var context = new BlogContext()) { CreateDatabase(context); }

Console.WriteLine("Ended");

static void CreateDatabase(DbContext context)
{
    context.Database.Migrate();
}

/*
#region OneToOneRequired
// Principal (parent)
public class Blog
{
    public int Id { get; set; }
    public BlogHeader? Header { get; set; } // Reference navigation to dependent
}

// Dependent (child)
public class BlogHeader
{
    public int Id { get; set; }
    public int BlogId { get; set; } // Required foreign key property
    public Blog Blog { get; set; } = null!; // Required reference navigation to principal
}
#endregion

public class BlogContext : DbContext
{
    public DbSet<Blog> Blogs => Set<Blog>();
    public DbSet<BlogHeader> BlogHeaders => Set<BlogHeader>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"DataSource = ./Sqlite3/__CURRENT__.db");
}
*/