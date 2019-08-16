using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Data.SQL
{
    class MoviesQueries
    {
        public const string Create = @"
insert into Movies (Id, MovieName)
values (@Id, @MovieName)";

        public const string GetAll = @"select * from Movies";

        public const string GetThis = @"select * from Movies where Id=@Id";

        public const string PostThis= @"
insert into Movies(MovieName, RunTime, DirectorName)
values(@MovieName, @RunTime, @DirectorName);
select* from Movies where MovieName = @MovieName";

       
    }
}
