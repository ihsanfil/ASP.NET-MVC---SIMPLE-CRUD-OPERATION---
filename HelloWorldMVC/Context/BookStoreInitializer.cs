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
    }
}