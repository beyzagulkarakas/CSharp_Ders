using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud: Create-Read-Update-Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-27ISNGQ;initial catalog=EgitimDB;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery(); //Koşulsuz bir şekilde sorguyu çalıştır.İstisna olmadan.
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-27ISNGQ;initial catalog=EgitimDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery(); //değişiklikleri kaydet ve veritabanına yansıt.
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-27ISNGQ;initial catalog=EgitimDB;integrated security=true");

            //connection.Open(); //bağlantı açma
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection); //sorgu okundu
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //data adaptor oluşturuldu
            //DataTable dataTable = new DataTable(); //data table oluşturuldu
            //adapter.Fill(dataTable); //içini doldurma işlemi

            //foreach (DataRow row in dataTable.Rows) //her satırdaki sütunları ayrı ayrı yazdırmamız gerekiyo bir döngü daha kullanacağız. Bu satır içindi.
            //{ 
            //    foreach (var item in row.ItemArray)//ilgili satırın sütunları için.
            //    {
            //        Console.Write(item.ToString() + " "); //her sütunu yazdırdıktan sonra bir boşluk bıraktık
            //    }
            //    Console.WriteLine(); //Her satır bittikten sonra bir boşluk bırak
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-27ISNGQ;initial catalog=EgitimDB;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı. ");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName=Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-27ISNGQ;initial catalog=EgitimDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı. ");
            #endregion

            Console.Read();

        }
    }
}
