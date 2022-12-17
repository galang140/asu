namespace LibraryManagementSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using MySql.Data.MySqlClient;

    namespace LibraryManagementSystem
    { 

    public class MYDB : DbContext
    {

        public MYDB()
            : base("name=mybd")
        {
        }
            private MySqlConnection connection = new MySqlConnection(
                "server=localhost;port=3306;username=root;password=;database=LibraryManagementSystem")

            public void openConnection()
            {

            } 
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}