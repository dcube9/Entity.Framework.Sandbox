// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Scaffold-DbContext 
    'Server=localhost;Port=5432;Database=XYZ;Integrated Security=true;Pooling=true;'
    Npgsql.EntityFrameworkCore.PostgreSQL
    -ContextDir DataAccessLayer
    -OutputDir DataAccessLayer/Entities
*/

/*
Scaffold-DbContext 
    'Data Source=localhost;Initial Catalog=CamlabDatabaseToScaffold;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False'
    Microsoft.EntityFrameworkCore.SqlServer
    -ContextDir DataAccessLayer
    -OutputDir DataAccessLayer/Entities
*/

/*
Scaffold-DbContext 'Server=localhost;Port=5432;Database=CAMLAB;Integrated Security=true;Pooling=true;User ID=postgres;Password=postgres;' Npgsql.EntityFrameworkCore.PostgreSQL -ContextDir DataAccessLayer -OutputDir DataAccessLayer/Entities
*/