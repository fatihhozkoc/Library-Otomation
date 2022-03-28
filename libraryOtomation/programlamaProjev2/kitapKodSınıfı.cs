using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programlamaProjev2
{
    class kitapKodSınıfı : Interface1
    {

        // Database bağlantısını kurduğum satır.
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GLBV3R4;Initial Catalog=projeDatabase;Integrated Security=True");

        // Interface1'den implement ettiğim ve database'e veri eklemek için kullanacağım fonksiyon.
        public void add(SqlCommand command, string query)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
