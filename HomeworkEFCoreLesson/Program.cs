using HomeworkEFCoreLesson.Data;
using System;
using System.Linq;

namespace HomeworkEFCoreLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {
                //Console.WriteLine("Список должников:");
                //var debitors = (from readers in context.Readers
                //                where readers.IsDebitor
                //                select readers).ToList();

                //foreach(var item in debitors)
                //{
                //    Console.WriteLine($"{item.Id} {item.FullName}");
                //}
                //Console.WriteLine();

                //Console.WriteLine("Список авторов книги №3:");
                //var authors = (from author in context.Authors
                //               join authorAndBook in context.AuthorsAndBooks on author.Id equals authorAndBook.AuthorId
                //               join books in context.Books on authorAndBook.BookId equals books.Id
                //               where author.Id == 3
                //               select author).ToList();
                //foreach (var item in authors)
                //{
                //    Console.WriteLine($"{item.Id} {item.FullName}");
                //}
                //Console.WriteLine();

                //Console.WriteLine("Список книг:");
                //var books = (from book in context.Books                                
                //                select book).ToList();

                //foreach (var item in books)
                //{
                //    Console.WriteLine($"{item.Id} {item.Title}");
                //}
                //Console.WriteLine();

                //Console.WriteLine("Список книг на руках читателя №2:");
                //var books = (from book in context.Books
                //             join extradition in context.Extraditions on book.Id equals extradition.Id
                //             join reader in context.Readers on extradition.Id equals reader.Id
                //             where reader.Id == 2
                //             select book).ToList();

                //foreach (var item in books)
                //{
                //    Console.WriteLine($"{item.Id} {item.Title}");
                //}
                //Console.WriteLine();

                Console.WriteLine("Обнуление должников:");
                var debitors = (from readers in context.Readers
                                where readers.IsDebitor
                                select readers).ToList();

                foreach (var item in debitors)
                {
                    item.IsDebitor = false;
                }
                context.SaveChanges();
            }

            }
        }
    }

