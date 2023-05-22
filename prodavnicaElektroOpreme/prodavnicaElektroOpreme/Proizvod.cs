using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace prodavnicaElektroOpreme
{
    internal class Proizvod
    {
        private int id;
        private string ime;
        private int cena;
        private int naStanju;
        private int idDobavljaca;
        private List<Proizvod> proizvodi;

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

        public int Cena
        {
            get { return cena; }
            set 
            {
                if (cena < 0) throw new Exception("Cena ne moze biti manja od 0!");
                cena = value; 
            }
        }

        public int NaStanju
        {
            get { return naStanju; }
            set { naStanju = value; }
        }

        public int IdDobavljaca
        {
            get { return idDobavljaca; }
            set { idDobavljaca = value; }
        }

        public List<Proizvod> Proizvodi
        {
            get { return proizvodi; }
            set { proizvodi = value;}
        }

        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\L\\source\\repos\\Levnaic\\Prodavnica Elektro Opreme\\prodavnicaElektroOpreme\\prodavnicaElektroOpreme\\ProdavnicaDB.mdf\";Integrated Security=True";
    
        public void dodajProizvod() 
        {
            string insertSql = "INSERT INTO PROIZVODI_T" +
                "(Ime, Cena, IdDobavljaca) VALUES" +
                "(@Ime, @Cena, @IdDobavljaca)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Cena", Cena));
                command.Parameters.Add(new SqlParameter("@IdDobavljaca", IdDobavljaca));
                connection.Open();
                command.ExecuteNonQuery();
            
            }
        }

        public void azurirajProizvod()
        {
            string updateSql = "UPDATE PROIZVODI_T"+
               "(Ime, Cena, IdDobavljaca) VALUES" +
               "(@Ime, @Cena, @IdDobavljaca)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@ProizvodId", ID));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Cena", Cena));
                command.Parameters.Add(new SqlParameter("@IdDobavljaca", IdDobavljaca));
                command.Parameters.Add(new SqlParameter("@NaStanju", NaStanju));
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void obrisiProizvod()
        {
            string deleteSql = "DELETE FORM PROIZVODI_T WHERE IdProizvoda = @ProizvodId"; 

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@ProizvodId", ID));
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public List<Proizvod> ucitajProizvode()
        {
            List<Proizvod> proizovdi= new List<Proizvod>();
            string queryString = "SELECT * FROM PROIZVODI_T";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()) 
                {
                    Proizvod proi;
                    while (reader.Read()) 
                    {
                        proi= new Proizvod();
                        proi.ID = Int32.Parse(reader["ProizvodId"].ToString());
                        proi.Ime = reader["Ime"].ToString();
                        proi.Cena = Int32.Parse(reader["Cena"].ToString());
                        proi.NaStanju = Int32.Parse(reader["NaStanju"].ToString());
                        proi.IdDobavljaca = Int32.Parse(reader["IdDobavljaca"].ToString());
                    }
                }
            }
            return proizovdi;
        }
    }
}
