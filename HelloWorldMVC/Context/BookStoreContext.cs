using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Context
{
    public class BookStoreContext : DbContext //context class'ının entity framework özelliklerine sahip olması için DbContext'ten miras aldık.
    {
        //web config'e bak BookStore isminde bir connectionStrings var bunun sana gösterdiği isimde ve yolda veritabanını oluştur dedik.
        public BookStoreContext():base("name=BookStore") 
        {
            // Initialize'ı devreye sokmak için 1. Yöntem 
            // Database.SetInitializer<BookStoreContext>(new DropCreateDatabaseIfModelChanges<BookStoreContext>());         
        }
        public DbSet<Book> Books { get; set; } //Database de oluşmasını istediğimiz tablo
        public DbSet<Category> Categories { get; set; }  //Database de oluşmasını istediğimiz tablo
    }
}