using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ (language integrated Query)




            //deleting data kısmı
            //UrunContext db = new UrunContext();

            //var urun = db.Urunler.Find(1);
            //if (urun != null)
            //{
            //    db.Urunler.Remove(urun);
            //}

            //db.SaveChanges();

            //var urunler = db.Urunler.ToList();
            //foreach (var urun in urunler)
            //{
            //    db.Urunler.Remove(urun);
            //}

            //db.SaveChanges();

            //if (db.Urunler.Count() == 0)
            //{
            //    Console.WriteLine("listedeki tüm değerler başarıyla silindi");
            //}
            //else
            //{

            //    var urunler = db.Urunler.ToList();
            //    foreach (var item in db.Urunler)
            //    {
            //        Console.WriteLine("urun id :{0} urun adı : {1}", item.Id, item.UrunAdi);
            //    }
            //}

            ////updating data kısmı
            //UrunContext context = new UrunContext();
            //var urun = context.Urunler.Find(1);
            //Console.WriteLine("urun id : {0} urun adı : {1} fiyat : {2}", urun.Id, urun.UrunAdi, urun.Fiyat);

            //urun.Fiyat *= 1.5;
            //urun.UrunAdi = "Samsung S6";
            //urun.StokAdeti = urun.StokAdeti + 100;

            //context.SaveChanges();

            //urun = context.Urunler.Find(1);
            //Console.WriteLine("urun id : {0} urun adı : {1} fiyat : {2}", urun.Id, urun.UrunAdi, urun.Fiyat);


            //var urunler = context.Urunler.ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("fiyat : {0}", item.Fiyat);
            //}

            //Console.WriteLine("-------------------------------");

            //foreach (var urun in urunler)
            //{
            //    urun.Fiyat *= 1.25;
            //}

            //context.SaveChanges();

            //urunler = context.Urunler.ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("fiyat : {0}", item.Fiyat);
            //}




            //selecting data kısmı
            //UrunContext context = new UrunContext();
            //1.yol
            //List<Kategori> kategoriler = context.Kategoriler.ToList();

            //2.yol
            //var kategoriler = context.Kategoriler.ToList();

            //foreach (var kategori in kategoriler)
            //{
            //    Console.WriteLine("kategori id :{0} kategori adı : {1}", kategori.Id, kategori.KategoriAdi);
            //}

            //var urunler = context.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun adı :{0} urun fiyatı : {1} urun stok adeti : {2}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti);
            //}

            //var urun = context.Urunler.Find(5);
            //Console.WriteLine("urun id : {3} urun adı :{0} urun fiyatı : {1} urun stok adeti : {2}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.Id);




            //inserting data kısmı
            //UrunContext context = new UrunContext();
            //List<Urun> urunler = new List<Urun>()
            //{
            //    new Urun()
            //    {
            //        UrunAdi="Samsung S4",Fiyat=2000, StokAdeti=100
            //    },

            //    new Urun()
            //    {
            //        UrunAdi="Samsung S6",Fiyat=3000, StokAdeti=100
            //    },

            //    new Urun()
            //    {
            //        UrunAdi="Samsung S7",Fiyat=4000, StokAdeti=100
            //    },


            //};

            //foreach (var urunlerim in urunler)
            //{
            //    context.Urunler.Add(urunlerim);
            //}


            //context.SaveChanges();
            //Console.WriteLine("başarıyla eklendi");
            //Console.ReadLine();
            
            
            
            
            
            
            
            
            
            
            
            //List<Kategori> Kategoriler = new List<Kategori>()
            //{
            //    new Kategori()
            //    {
            //        Id=1, KategoriAdi="telefon"
            //    },

            //    new Kategori()
            //    {
            //        Id=1, KategoriAdi="bilgisayar"
            //    },

            //    new Kategori()
            //    {
            //        Id=1, KategoriAdi="tablet"
            //    }
            //};

            //Kategoriler.Add(k);



        }
    }
}
