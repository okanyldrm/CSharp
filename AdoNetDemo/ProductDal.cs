using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        //Veri tabanına ekleme silme güncelleme çekme işlemlerini yapacagımız yer

        //Sql Connection baglantı nesnesi olusturduk
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            

            if (_connection.State==ConnectionState.Closed)
            {
                _connection.Open();
            }

           SqlCommand command = new SqlCommand("Select * from Products",_connection);

           SqlDataReader reader= command.ExecuteReader();

           List<Product> products = new List<Product>();

            //reader gelen verileri tek tek oku
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

           

            reader.Close();
            _connection.Close();

            return products;
          

        }


        public void Add(Product product)
        {
            

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }




        }



    }
}
