using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Data.SQL
{
    class ScreenTimes
    {
        public const string GetScreenTimeInfo = @"select * from ScreenTimes";

        public const string CreateScreenTimeInfo = @"
insert into ScreenTimes (MovieId, )
values (MovieId)";
    }
}
