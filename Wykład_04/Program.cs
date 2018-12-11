using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Wykład_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    list.Add(i);
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.Read();
            //var list = new Dictionary<int,string>();

            //for (int i = 0; i < 100; i++)
            //{
            //    list.Add(i, i.ToString());
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //var a = int.Parse("15");

            //int.TryParse("11", out int b);

            //Console.WriteLine("Numer 1: " +a +" numer 2:" + b);
            //Console.Read();

            var json = Http.HttpGet("https://jsonplaceholder.typicode.com/comments");
            var obj = JsonConvert.DeserializeObject<List<EkaObject>>(json);

            //IEnumerable<EkaObject> first = obj.Where(x => x.id > 50);
            //IOrderedEnumerable<EkaObject> second = obj.Where(x => x.id > 50).OrderBy(x => x.email);
            //List<EkaObject> third = obj.Where(x => x.id > 50).OrderBy(x => x.email).ToList();

            //var emails1 = obj.Where(x => x.email.Contains(".net"));
            //var emails2 = obj.Where(x => x.email.EndsWith(".net")).OrderByDescending(x=>x.id);
            //var bb = emails2.Count();

            //foreach (var item in emails2)
            //{
            //    Console.WriteLine(item.id);
            //}

            //IEnumerable<string> aa = obj.Select(x => x.email);
            //List<string> aa = obj.Select(x => x.email).ToList();
            //aa.ForEach(x => Console.WriteLine(x));
            //var aa = obj.Where(x => x.email.EndsWith(".net") || x.id > 50).OrderBy(x=> x.email).Where(x=> x.body.Contains("a")).Select(x=> x.id);
            var aa = obj.Single(x => x.id == 5555);
            Console.Read();

        }

    }
    public class EkaObject
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }

}
