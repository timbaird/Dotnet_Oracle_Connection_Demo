using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Dotnet_Oracle_Connection
{
    class Program
    {
        static void Main(string[] args)
        {

            // connection
            using (OracleConnection conn = new OracleConnection(Secret.GetConnString()))
            {
                using (OracleCommand comm = new OracleCommand())
                {
                    try
                    {
                        comm.Connection = conn;

                        // double check you have data in the customer table
                        // or change the query to look at a test table you have with data
                        comm.CommandText = "Select * from customer";
                        conn.Open();

                        using( OracleDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //make sure the data types are correct here
                                Console.WriteLine(reader.GetInt32(0) + " " +  reader.GetString(1));
                            }
                        }
                    } 
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }





            }
            // command
            // command paremeter / types / 
            // execute - execute non query / execute reader / 

            // loop through the reader to 'use' the data (e.g. print to console)

            // close the connection

            // clean up / exception handling








            Console.ReadKey();
        }
    }
}
