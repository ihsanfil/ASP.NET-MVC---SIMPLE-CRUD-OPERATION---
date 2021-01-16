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
        public DbSet<Book> Books { get; set; } //Database de oluşmasını istediğimiz tablo
        public DbSet<Category> Categories { get; set; }  //Database de oluşmasını istediğimiz tablo
    }
}