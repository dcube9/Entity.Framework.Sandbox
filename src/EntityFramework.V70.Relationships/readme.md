# Package Manager Console EF Commands

| Command description                       | Commands                                                                                                |
|-------------------------------------------|---------------------------------------------------------------------------------------------------------|
| List migrations                           | `Get-Migration -Context XyzDbContext`                                                                   |
| Add a migration                           | `Add-Migration <name-label> -Context XyzDbContext`                                                      |
| Update database with current migrations   | `Update-database -Context XyzDbContext`                                                                 |
| Downgrade database to previous migrations | `Update-database <nome-migrazione> -Context XyzDbContext`                                               |
| Downgrade database even the 1st migration | `Update-database 0 -Context XyzDbContext`</br>OR</br>`Update-database -TargetMigration:0 -Context XyzDbContext` |
| Delete the latest added migration         | `Remove-Migration -Context XyzDbContext`                                                                |
</br>

```
Add-Migration
  -Name FirstMigration
  -Context EntityFramework.V70.Relationships.OneToOneRequired.BlogContext0
  -Namespace Migrations.OneToOneRequired.BC0

Add-Migration
  -Name FirstMigration
  -Context EntityFramework.V70.Relationships.OneToOneRequired.BlogContext1
  -Namespace Migrations.OneToOneRequired.BC1

Add-Migration
  -Name FirstMigration
  -Context EntityFramework.V70.Relationships.OneToOneRequired.BlogContext2
  -Namespace Migrations.OneToOneRequired.BC2
```
</br>

```
Add-Migration
  -Name FirstMigration
  -Context EntityFramework.V70.Relationships.OneToOneOptional.BlogContext0
  -Namespace Migrations.OneToOneOptional.BC0

Add-Migration
  -Name FirstMigration
  -Context EntityFramework.V70.Relationships.OneToOneOptional.BlogContext1
  -Namespace Migrations.OneToOneOptional.BC1

Add-Migration
  -Name FirstMigration
  -Context EntityFramework.V70.Relationships.OneToOneOptional.BlogContext2
  -Namespace Migrations.OneToOneOptional.BC2
```
</br>

... and so on.
