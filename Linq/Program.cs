using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using L2O___D09;
using Linq;
using static L2O___D09.ListGenerators;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region how linq work

            //int x = 123456;
            //int y = int32Extintions.mirror(x);
            //y = x.mirror();
            //var E1 = new { name = "a7md", id = 123, salary = 12345m };
            //Console.WriteLine(E1.name);

            #endregion

            #region Defferd_execution

            //List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
            //var x = lst.Where(i => i % 2 == 0);
            //lst.Remove(2);
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region imidiatly exceution
            //List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
            //var x = lst.Where(i => i % 2 == 0).ToList();
            //x.Remove(2);

            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region quary expration

            //List<int> lst = new List<int>() { 1 , 2 ,3 ,4 ,5 ,6 ,7, 8, 9};
            //var res = from i in lst.ToList()
            //          where i%2 == 0
            //          select i;
            //lst.Remove(2);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> lst = new List<int>() { 1 , 2 ,3 ,4 ,5 ,6 ,7, 8, 9};
            //var res = from i in lst.ToList()
            //          where i%2 == 0
            //          select i;
            //lst.Remove(2);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region where and indexed where

            //var res = ProductList.Where((p, i) => p.UnitsInStock == 0 && i < 60);


            //res = ProductList.Where(p => (p.UnitsInStock == 0) && (p.Category == "Meat/Poultry"));

            //res = ProductList.Where(p => (p.UnitsInStock == 0))
            //                 .Where(p => p.Category == "Meat/Poultry");



            #endregion

            #region select
            //   var res = ProductList.Where((p,i)=>i<5).Select((p) => p.ProductName);


            //var res = ProductList.Select(p => new { name = p.ProductName, Id = p.ProductID });

            // res = ProductList.Select(p => new {  p.ProductName,  p.ProductID });

            //var res = from p in ProductList
            //          //                    array                val
            //          where Array.IndexOf(ProductList.ToArray(),   p   ) < 5
            //          select new { name = p.ProductName, Id = p.ProductID };



            //var discount = ProductList.Select(p => new
            //{
            //    ID = p.ProductID,
            //    cat = p.Category,
            //    name = p.ProductName,
            //    inStock = p.UnitsInStock,
            //    NewPrice = 0.9m * p.UnitPrice

            //}
            //);



            //var discount = from p in ProductList
            //               select new
            //               {
            //                   ID = p.ProductID,
            //                   cat = p.Category,
            //                   name = p.ProductName,
            //                   inStock = p.UnitsInStock,
            //                   NewPrice = 0.9m * p.UnitPrice

            //               };


            //select and where index here as enumrator


            //var res = ProductList.Where(p => p.UnitsInStock == 0)
            //    .Select((p, i) => new { index = i, name = p.ProductName });

            //select where and into 

            //var res = ProductList.Select(p => new { name = p.ProductName, newPrice = p.UnitPrice * 1.1m })
            //    .Where(p => p.newPrice > 100);

            //var R01 = ProductList.Select(p => new { name = p.ProductName, newPrice = p.UnitPrice * 1.1m });
            //var R02 = R01.Where(p => p.newPrice > 100);

            //var R01 = from p in ProductList
            //          select new { name = p.ProductName, newPrice = p.UnitPrice * 1.1m };
            //var R02 = from p in R01
            //          where p.newPrice > 100
            //          select p;

            //var R01 = from p in ProductList
            //          select new { name = p.ProductName, newPrice = p.UnitPrice * 1.1m }
            //          into TexedProduct
            //          where TexedProduct.newPrice > 100
            //          select TexedProduct;



            #endregion

            #region OrderBy
            var res = ProductList.OrderByDescending(x => x.UnitPrice).ThenByDescending(x=>x.UnitsInStock);

            //var res = ProductList.OrderByDescending(p => p.UnitsInStock)
            //    .ThenByDescending(p => p.UnitPrice);

            foreach (var item in res)
            {
                Console.WriteLine(item.ProductName +" "+ item.UnitPrice +" " + item.UnitsInStock);
            }

            //var res = ProductList.OrderByDescending(p=> p.UnitsInStock)
            //    .ThenBy(p => p.UnitPrice);  

            //var res = ProductList.OrderBy(p=> p.UnitsInStock)
            //    .ThenByDescending(p => p.UnitPrice);

            //var res = from p in ProductList
            //          orderby p.UnitsInStock descending , p.UnitPrice
            //          select p;

            #endregion

            #region Imediatly singel value first last 

            //var res = ProductList.First();

            //res = ProductList.First(p => p.ProductID == 2);

            //res = ProductList.FirstOrDefault(p => p.ProductID == 777);


            //res = ProductList.Last();

            //res = ProductList.Last(p => p.ProductID == 2);

            //res = ProductList.LastOrDefault(p => p.ProductID == 777);

            //Console.WriteLine(res?.ProductName ?? "NA");

            //// hybrid syntex = (quary expration).fluent syntex

            //    res= (from p in ProductList
            //         where p.ProductID==2
            //         select p).First();



            #endregion

            #region Imediatly execution

            //var res = ProductList.ElementAt(8);

            //res = ProductList.ElementAtOrDefault(777);


            //single => use it in primay key

            //res = ProductList.Single(p=> p.ProductName=="Chai");

            ////  res = ProductList.Single(p => p.UnitsInStock == 0); // exeption multy result match

            //var lst = ProductList;

            //lst.Clear();

            //res=ProductList.SingleOrDefault(p=> p.UnitsInStock==0); // if seq empty return defult else exeption // exeption

            //res=lst.SingleOrDefault(p=> p.UnitsInStock==0); // if seq empty return defult else exeption // drfult

            //Console.WriteLine(res?.ProductName ?? "NA");

            #endregion

            #region aggreggate 
            //var res = ProductList.Count();

            //res = ProductList.Count(p=>p.ProductName=="Chai");

            // var res = ProductList.Max(); //empty() = IComparple

            //  var res = ProductList.Max(p=> p.UnitPrice);

            ////  res = ProductList.Min(); //empty() = IComparple

            //  res = ProductList.Min(p => p.UnitPrice);

            //  res =ProductList.Sum(p=> p.UnitPrice);

            //  res=ProductList.Average(p=> p.UnitPrice);

            //  Console.WriteLine(res);
            //Console.WriteLine(res?.ProductName ?? "NA");
            #endregion

            #region genratotrs

            //  var res = Enumerable.Range(50/*Start*/, 100 /*Count*/); 
            // seq(ienumrable) of ints has val from 50 to  149

            //var res = Enumerable.Empty<Product>();
            //res = Enumerable.Repeat(ProductList[1], 10);

            #endregion

            #region Select meny AND OrderBy
            //var Names = new List<string>() { "Atmd mo7md", "mano kemo", "lolo lala" };
            //var res = Names.SelectMany(Fn=> Fn.Split(" "));
            //var res = from Fn in Names
            //          from Sn in Fn.Split(" ")
            //          orderby Sn.Length
            //          select Sn;
            #endregion

            #region casting
            /*
             ToList()
            ToArray()
            ToHashSet()
            TODictionary()

             */
            //var res = ProductList.ToDictionary(p => p.ProductID);

            //var m=ProductList.ToDictionary(p=>p.ProductID,prd=> new {prd.ProductName,prd.ProductID});


            #endregion

            #region Set Operators

            //var seq01 = Enumerable.Range(0, 100); // 0.. 99
            //var seq02 = Enumerable.Range(50, 100); // 50 ..149

            ////var res = seq01.Union(seq02); 

            //var res = seq01.Concat(seq02); // +
            //res = res.Distinct(); // concat + distancat = union

            //res = seq01.Intersect(seq02);

            //res = seq01.Except(seq02);  // exist in 1 not exist in 2



            #endregion

            #region ZIP 
            // // use it to marge
            // var seq01 = Enumerable.Range(0, 10); // 0.. 9
            // var Names = new List<string>() { "Atmd mo7md", "mano kemo", "lolo lala" };
            //// var res = seq01.Zip(Names);
            // var res = seq01.Zip(Names,(FN,i)=>new {i , name=FN});

            #endregion

            #region Grouping

            //var res = from p in ProductList
            //          where p.UnitsInStock>0
            //          group p by p.Category
            //          into prdCat 
            //          where prdCat.Count() > 10
            //          select prdCat;

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Key} ");
            //    foreach (var prd in item)
            //        Console.WriteLine($" ..{prd.ProductName} ");
            //}


            //var res2 = from p in ProductList
            //          where p.UnitsInStock > 0
            //          group p by p.Category
            //         into prdCat
            //          where prdCat.Count() > 10
            //          select new { Catgory = prdCat.Key, ProCount = prdCat.Count() };
            //foreach (var item in res2)
            //{
            //    Console.WriteLine($"{item} ");
            //}


            #endregion

            #region Let
            //var Names = new List<string>() { "Atmd mo7md", "mano kemo", "lolo lala" };

            //// remove AIOUEaioue
            //var res = from n in Names
            //          let noAIOUEaioue = Regex.Replace(n, "[AIOUEaioue]", string.Empty)
            //          where noAIOUEaioue.Length>3
            //          select noAIOUEaioue;




            #endregion

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item} ");
            //}


            Console.ReadKey();

        }
    }
}
