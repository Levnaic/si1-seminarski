using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace prodavnicaElektroOpreme
{
    internal class Dobavljac
    {
        private int id;
        private string ime;
        private string email;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; }
            set
            {
                if (ime == "") throw new Exception("Morate uneti ime proizvoda!");
                ime = value;
            }
        }

        public string Email 
        {
            get { return email; }
            set 
            {
                if (email == "") throw new Exception("Morate uneti email!");
                email = value;  
            }
        }

        public List<Dobavljac> Dobavljaci
        {
            get { return Dobavljaci; }
            set { Dobavljaci = value; }
        }

        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\L\\source\\repos\\Levnaic\\Prodavnica Elektro Opreme\\prodavnicaElektroOpreme\\prodavnicaElektroOpreme\\ProdavnicaDB.mdf\";Integrated Security=True";

        public void dodajDobavljaca()
        {
            string insertSql = "INSERT INTO DOBAVLJACI_T" +
                "(Ime, Email) VALUES" +
                "(@Ime, @Email)";

            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                SqlCommand command = connection.CreateCommand();
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Email", Email));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void azurirajDobavljaca()
        {
            string updateSql = "UPDATE DOBAVLJACI_T" +
                "(Ime, Email) VALUES" +
                "(@Ime, @Email)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.Parameters.Add(new SqlParameter("@DobavljacId", ID));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Email", Email));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void obrisiDobavljaca()
        {
            string deleteSql = "DELETE FORM DOBAVLJACI_T WHERE IdDobavljaca = @DobavljacId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@DobavljacId", ID));
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public List<Dobavljac> ucitajDobavljace()
        {
            List<Dobavljac> dobavljaci = new List<Dobavljac>();
            string queryString = "SELECT * FROM DOBAVLJACI_T";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Dobavljac dob;
                    while (reader.Read())
                    {
                        dob = new Dobavljac();
                        dob.ID = Int32.Parse(reader["ProizvodId"].ToString());
                        dob.Ime = reader["Ime"].ToString();
                        dob.Email = reader["Email"].ToString();
                    }
                }
            }
            return dobavljaci;
        }
    }
}
