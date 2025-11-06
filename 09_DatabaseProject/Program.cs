using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        //NYP da 3 temel yapı vardır : Sınıf, Nesne, Property-Nitelik
        // Sınıf, property dediğimiz nitelikleri içerisinde barındıran yapılardır.
        // Sınıflara erişim sağlamam için önce o sınıftan bir tane nesne örneği türetmem gerekir.
        // Bu işlemi SqlConnection connection = new SqlConnection(""); satırı ile yaptık.
        // SqlConnection bir sınıftır, türetmiş olduğumuz connection bir nesne, connection'un altında kullandığımız şeyler iste property-nitelik tir.
        static void Main(string[] args)
        {
            //Ado.net : C#da SQL yapılarını kullanmamıza olanak sağlayan bir çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğin tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-27ISNGQ;initial Catalog=EgitimDB;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);//C# sorgusu ile sql veritabanı arasında köprü görevi görür
            DataTable dataTable = new DataTable(); //Verileri geçici(ram) belleğe almamızı sağlar
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)  //var değişkeni tüm değişken türlerini aldığı için bunu kullandık
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            } 

            connection.Close();


            Console.Read();
        }


    }
}
