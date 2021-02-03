using HelloWorldMVC.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        [RegularExpression(@"^.{3,}$", ErrorMessage = "Minimum 3 karakter zorunludur !")]
        [Required(ErrorMessage = "Başlık alanı girilmesi zorunludur !")]
        public string Title { get; set; }
    
        [Required(ErrorMessage = "Açıklama alanı girilmesi zorunludur !")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Minumum 3 Maksimum 200 karakter girilmesi zorunludur !")]
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "Fiyat alanı girilmesi zorunludur !")]
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public Category Category { get; set; }

    }
}