using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFramework.V70.Relationships.OneToOneOptional;

#region OneToOneOptional
public class OneToOneOptional
{
    public static void BuildModels()
    {
        using var context0 = new BlogContext0();
        Console.WriteLine("Optional one-to-one: ");
        var modelDebugString = context0.Model.ToDebugString(indent: 2);
        Console.WriteLine(modelDebugString);
        Console.WriteLine();

        using var context1 = new BlogContext1();
        Debug.Assert(modelDebugString == context1.Model.ToDebugString(indent: 2));

        using var context2 = new BlogContext2();
        Debug.Assert(modelDebugString == context2.Model.ToDebugString(indent: 2));
    }
}

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
    public int? BlogId { get; set; } // Optional foreign key property
    public Blog? Blog { get; set; } // Optional reference navigation to principal
}

public class BlogContext0 : DbContext
{
    public DbSet<Blog> Blogs => Set<Blog>();
    public DbSet<BlogHeader> BlogHeaders => Set<BlogHeader>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"DataSource = ./Sqlite3/Optional{GetType().Name}.db");
}

public class BlogContext1 : BlogContext0
{
    #region OneToOneOptionalFromPrincipal
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>()
            .HasOne(e => e.Header)
            .WithOne(e => e.Blog)
            .HasForeignKey<BlogHeader>(e => e.BlogId)
            .IsRequired(false);
    }
    #endregion
}

public class BlogContext2 : BlogContext0
{
    #region OneToOneOptionalFromDependent
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlogHeader>()
            .HasOne(e => e.Blog)
            .WithOne(e => e.Header)
            .HasForeignKey<BlogHeader>(e => e.BlogId)
            .IsRequired(false);
    }
    #endregion
}
#endregion