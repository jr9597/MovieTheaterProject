//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Dapper;
//using System.Data;
//using System.Data.SqlClient;

//namespace MovieTheater.Models
//{
//    public class MovieTheater
//    {
//        public int Id { get; set; }

//        public int RunTime { get; set; }

//        public string MovieName { get; set; }

//        static string strConnectionString = "Server= DESKTOP - UL3Q9MA\\SQLEXPRESS01; Database = MovieTheaterExercise";

//        public static IEnumerable<MovieTheater> GetMovieTheater()
//        {
//            // get all movietheater details
//            List<MovieTheater> movieTheaterList = new List<MovieTheater>();
//            using (IDbConnection con = new SqlConnection(strConnectionString))
//            {
//                if (con.State == ConnectionState.Closed)
//                    con.Open();

//                movieTheaterList = con.Query<MovieTheater>("GetMovieTheaterDetails").ToList();
//            }
//            return movieTheaterList;
//        }

//        // get movietheater details by groupId
//        public static MovieTheater GetMovieTheaterById(int? Id)
//        {
//            MovieTheater movieTheater = new MovieTheater();
//            if (Id == null)
//                return movieTheater;

//            using (IDbConnection con = new SqlConnection(strConnectionString))
//            {
//                if (con.State == ConnectionState.Closed)
//                    con.Open();

//                DynamicParameters parameter = new DynamicParameters();
//                parameter.Add("@Id", Id);
//                movieTheater = con.Query<MovieTheater>
//                    ("GetMovieTheaterByID", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
//            }
//            return movieTheater;
//        }

//    //insert using dapper
//    public static int AddMovieTheater(MovieTheater movieTheater)
//    {
//        int rowAffected = 0;
//        using (IDbConnection con = new SqlConnection(strConnectionString))
//        {
//            if (con.State == ConnectionState.Closed)
//                con.Open();

//            DynamicParameters parameters = new DynamicParameters();
//            parameters.Add("@MovieName", movieTheater.MovieName);
//            parameters.Add("@MovieRunTime", movieTheater.RunTime);

//            rowAffected = con.Execute("InsertMovieTheater", parameters, commandType: CommandType.StoredProcedure);
//        }
//        return rowAffected;
//    }

//    //update using dapper
//    public static int UpdateMovieTheater(MovieTheater movieTheater)
//    {
//        int rowAffected = 0;
//        using (IDbConnection con = new SqlConnection(strConnectionString))
//        {
//            if (con.State == ConnectionState.Closed)
//                con.Open();
//            DynamicParameters parameters = new DynamicParameters();
//            parameters.Add("@Id", movieTheater.Id);
//            parameters.Add("@MovieName", movieTheater.MovieName);
//            parameters.Add("@MovieRunTime", movieTheater.RunTime);
//            rowAffected = con.Execute("UpdateGroupMeeting", parameters, commandType: CommandType.StoredProcedure);
//        }
//        return rowAffected;
//    }

//    //delete using dapper
//    public static int DeleteMovieTheater(int id)
//    {
//        int rowAffected = 0;
//        using (IDbConnection con = new SqlConnection(strConnectionString))
//        {
//            if (con.State == ConnectionState.Closed)
//                con.Open();
//            DynamicParameters parameters = new DynamicParameters();
//            parameters.Add("@Id", id);
//            rowAffected = con.Execute("DeleteMovieTheater", parameters, commandType: CommandType.StoredProcedure);

//        }
//        return rowAffected;
//    }
//}
//}

