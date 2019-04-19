namespace MVCFunLearn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieWithGenreId : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Sholay', 2 , 05/01/2019, 05/01/1975, 10)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Titanic', 5 , 05/02/2019, 05/01/1999, 20)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Andaj Apna Apna', 1 , 06/02/2019, 05/01/1995, 2)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Die Hard', 2 , 06/04/2019, 05/01/2010, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Hulk', 2 , 17/02/2019, 05/01/2015, 12)");
        }
        
        public override void Down()
        {
        }
    }
}
