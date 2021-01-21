using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Context
{
    //Eğer database için kullanılan modelde bir değişiklik varsa veritabanını sil ve yeniden oluştur.
    //Initializer ile ilgili ayarlar web.config contexts içerisinde !
    public class BookStoreInitializer : DropCreateDatabaseIfModelChanges<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            //Database'de değişiklik olduğunda silinip tekrar oluşuyor, oluşmadan önce de seed metodu ile database'e test kategorileri yazdırıyoruz.
            List<Category> categorList = new List<Category>()
            {
                new Category(){CategoryName="C# Programlama Dili"},
                new Category(){CategoryName="Asp.net Web Form"},
                new Category(){CategoryName="Asp.net MVC"},
                new Category(){CategoryName="Python Programlama Dili"},
                new Category(){CategoryName="Java Programlama Dili"}
                
            };
            foreach (var category in categorList)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();


            //Database'de değişiklik olduğunda silinip tekrar oluşuyor, oluşmadan önce de seed metodu ile database'e test verileri yazdırıyoruz.
            List<Book> bookList = new List<Book>()
            {
                new Book()
                {
                    Title = "C# Dünyasına Merhaba: Asp.net",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=100,
                    StockQuantity = 50,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 1).FirstOrDefault()

                },
                 new Book()
                {
                    Title = "Asp.net Web Form'a Giriş",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=200,
                    StockQuantity = 70,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 2).FirstOrDefault()


                },
                  new Book()
                {
                    Title = "Asp.net MVC ile Yönetim Panelli Site Yapımı",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=110,
                    StockQuantity = 25,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 3).FirstOrDefault()


                },
                   new Book()
                {
                    Title = "Asp.net MVC ile Katmanlı Mimari",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=110,
                    StockQuantity = 25,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 3).FirstOrDefault()


                },
                     new Book()
                {
                    Title = "Asp.net MVC ile Yönetim Panelli Site Yapımı 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=110,
                    StockQuantity = 25,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 3).FirstOrDefault()


                },
                   new Book()
                {
                    Title = "A'dan Z'ye Python",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=120,
                    StockQuantity = 80,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 4).FirstOrDefault()


                },
                   new Book()
                {
                    Title = "Java ile Mobil Uygulama",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=120,
                    StockQuantity = 80,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 5).FirstOrDefault()


                },   new Book()
                {
                    Title = "Java ile Web Uygulamaları",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=120,
                    StockQuantity = 80,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 5).FirstOrDefault()


                }
            };
            foreach (var book in bookList)
            {
                context.Books.Add(book);
            }
            context.SaveChanges();


        }

    }
}