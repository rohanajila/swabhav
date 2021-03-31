using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnetoManyNHibernate_app.Model;

namespace OnetoManyNHibernate_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateTable();
            //Query1();
            Query2();
            Console.ReadKey();
        }
        private static void CreateTable()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    var category = new Category
                    {
                        Id = 1,
                        Name = "Sport"
                    };
                    var category1 = new Category
                    {
                        Id = 2,
                        Name = "Climate"
                    };
                    var category2 = new Category
                    {
                        Id = 1,
                        Name = "Religious"
                    };
                    var post = new Post
                    {
                        Id = 1,
                        Title = "Football"
                    };
                    var post1 = new Post
                    {
                        Id = 2,
                        Title = "Cricket"
                    };
                    var post2 = new Post
                    {
                        Id = 3,
                        Title = "Rainy"
                    };
                    var post3 = new Post
                    {
                        Id = 4,
                        Title = "Hindu"
                    };
                    post.Category = category;
                    post1.Category = category;
                    post2.Category = category1;
                    post3.Category = category2;

                    session.Save(category);
                    session.Save(category1);
                    session.Save(category2);
                    session.Save(post);
                    session.Save(post1);
                    session.Save(post2);
                    session.Save(post3);
                    transaction.Commit();

                }

                //Console.ReadKey();
            }
            Console.WriteLine("Table created!");
        }
        private static void Query1()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    var category = session.Query<Category>().Where(c => c.Id == 3);
                    foreach(var c in category)
                    {
                        Console.WriteLine("ID: " + c.Id + " |Name: " + c.Name);
                    }

                }
            }

        }
        
        private static void Query2()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    Console.WriteLine("Posts belonging to category id 1:");
                    var result = session.Query<Category>().Join(session.Query<Post>(), e => e.Id, a => a.Category.Id, (e, a) => new
                    { e.Id, a.Title }).Where(x => x.Id == 1).ToList();

                    foreach (var p in result)
                    {
                        Console.WriteLine(" |Title: " + p.Title);
                    }

                }
            }
        }

    }
}
