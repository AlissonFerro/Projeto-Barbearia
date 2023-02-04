using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class DBService
    {
        public static SqlConnection conn = new SqlConnection("Server=Alisson\\MSSQLSERVER01; Database=Barbearia; Trusted_Connection = True;");
        public static List<Cliente> FindByName(string name)
        {
            List<Cliente> clientes = new List<Cliente>();
            string statement = "Select * From Cliente WHERE Nome=@NOME";
            SqlCommand find = new SqlCommand(statement, conn);
            conn.Open();
            find.Parameters.AddWithValue("@NOME", name);

            var data = find.ExecuteReader();

            while (data.Read())
            {
                Cliente cliente = new Cliente(Convert.ToString(data[1]),Convert.ToString(data[2]));
                clientes.Add(cliente);
            }

            conn.Close();
            return clientes;
        }

        public static void CreateClient(Cliente cliente)
        {
            string statement = "INSERT INTO Cliente(\"Cliente_id\", \"Nome\", \"Telefone\", \"ValorAPagar\") VALUES(@ID, @NOME, @TELEFONE, @VALOR);";
            SqlCommand create = new SqlCommand(statement, conn);
            
            int id_client = Count();

            try
            {
                conn.Open();
                
                create.Parameters.AddWithValue("@ID", id_client);
                create.Parameters.AddWithValue("@NOME", cliente.Nome);
                create.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
                create.Parameters.AddWithValue("@VALOR", cliente.ValorAPagar);

                create.ExecuteNonQuery();
                
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int Count()
        {
            try
            {
                conn.Open();
                
                string stringCount = "SELECT COUNT(Cliente_id) FROM Cliente";
                SqlCommand command = new SqlCommand(stringCount, conn);
                var dataReaderCount = command.ExecuteScalar();
                Console.WriteLine(dataReaderCount);
                int count = Convert.ToInt32(dataReaderCount);
                
                conn.Close();

                return count;
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
            return 0;
        }
    }
}
