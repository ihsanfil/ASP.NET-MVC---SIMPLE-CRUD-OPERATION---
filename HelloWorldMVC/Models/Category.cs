using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Context
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Book> Books { get; set; }
    }
}