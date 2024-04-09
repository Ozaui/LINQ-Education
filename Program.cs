using System;
using LINQ_Education.Data.EfCore;
using Microsoft.EntityFrameworkCore;
//Database First
//dotnet ef dbcontext scaffold "server=localhost;port=3306;database=northwind;user=root;password=!YorickPass102030!;" "Pomelo.EntityFrameworkCore.MySql" --output-dir "Data/EfCore" --context NorthwindContext

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using (var db = new NorthwindContext())
			{
				//------------------------- Tek tablo ile calisma ------------------------


				//Tum musterti katirlarini getiriniz
				// var customers = db.Customers.ToList();
				// foreach (var customer in customers)
				// {
				// 	Console.WriteLine(customer.FirstName + " " + customer.LastName);
				// }

				//-------------------------------------------------------------------

				//Tum misteri kayitlarini sadece firtname ve lastname bilgilerini getiriniz
				// var customers = db.Customers.Select(c => new
				// {
				// 	c.FirstName,
				// 	c.LastName
				// });
				// foreach (var customer in customers)
				// {
				// 	Console.WriteLine(customer);
				// }

				//-------------------------------------------------------------------

				//NewYorkda yasayan musterileri isim sirasina gore getiriniz
				// var customers = db.Customers
				// 				.Where(i => i.City == "New York")
				// 				.Select(i => new { i.FirstName, i.LastName })
				// 				.ToList();
				// foreach (var customer in customers)
				// {
				// 	Console.WriteLine(customer.FirstName + " " + customer.LastName);
				// }

				//-------------------------------------------------------------------

				//beverages kategorisine ait urunLerin isimlerini getiriniz
				// var productNames = db.Products
				// 				.Where(i => i.Category == "Beverages")
				// 				.ToList();
				// foreach (var product in productNames)
				// {
				// 	Console.WriteLine(product.ProductName);
				// }

				//-------------------------------------------------------------------

				//En son eklenen 5 urun bilgisini aliniz.
				//var products = db.Products.Take(5); //Bastan 5 urun getirdi
				// var products = db.Products.OrderByDescending(i => i.Id).Take(5);//Idye gore ters cevirip son 5 kayiti aldik
				// foreach (var product in products)
				// {
				// 	Console.WriteLine(product.ProductName);
				// }

				//-------------------------------------------------------------------

				//Fiyati 10 ile 30 arasindaki urunleri isim ver fiyat bilgileri ile getiriniz.
				// var products = db.Products
				// 				.Where(x => x.ListPrice > 10 && x.ListPrice < 30)
				// 				.Select(x => new { x.ProductName, x.ListPrice })
				// 				.ToList();

				// foreach (var product in products)
				// {
				// 	Console.WriteLine(product);
				// }

				//-------------------------------------------------------------------

				//Beverages kategorisindeki urrunlerin ortalama fiyati nedir?
				// var average = db.Products
				// 			.Where(p => p.Category == "Beverages")
				// 			.Average(i => i.ListPrice);

				// Console.WriteLine("Average = " + average);

				//-------------------------------------------------------------------

				//Beverages kategorisindeki kac adet urun vardir?
				// var count = db.Products
				// 			.Count(p => p.Category == "Beverages");
				// Console.WriteLine("Count = " + count);

				//-------------------------------------------------------------------

				//Beverages ve Condiments kategorilerindeki urunlerin toplam fiyati nedir?
				// var sum = db.Products
				// 		.Where(p => p.Category == "Beverages" || p.Category == "Condiments")
				// 		.Sum(p => p.ListPrice);
				// Console.WriteLine("Sum = " + sum);

				//-------------------------------------------------------------------

				//Icerisinde tea kelimesi gecen urunleri aliniz.
				// var teas = db.Products
				// 				.Where(p => p.ProductName.ToLower().Contains("tea"))
				// 				.ToList();

				// foreach (var tea in teas)
				// {
				// 	Console.WriteLine(tea.ProductName);
				// }

				//-------------------------------------------------------------------

				//En pahali urun ve en ucuz urunler nelerdir.
				// var minPrice = db.Products.Min(i => i.ListPrice);
				// var maxPrice = db.Products.Max(i => i.ListPrice);//Bunlar da olur 

				// Console.WriteLine($"min = {minPrice}, max = {maxPrice}");

				// var product = db.Products
				// 				.Where(i => i.ListPrice == (db.Products.Min(p => p.ListPrice)))
				// 				.FirstOrDefault();
				// Console.WriteLine($"min = {minPrice}, Name = {product.ProductName}");


				//------------------------- Cok tablo ile calisma ------------------------

			}
		}
	}
}