using LibraryManagement3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement3.Repository
{
    public class BookRep : IBookRep
    {
        LMContext db;
        public BookRep(LMContext _db)
        {
            db = _db;
        }

        public List<Book> GetDetails()
        {
            return db.Books.ToList();
        }

        public Book GetDetail(int id)
        {
            if (db != null)
            {
                return (db.Books.Where(x => x.BookId == id)).FirstOrDefault();
            }
            return null;
        }

        public int AddDetail(Book obj)
        {
            db.Books.Add(obj);
            db.SaveChanges();

            return obj.BookId;
        }



        public int UpdateDetail(int id, Book obj)
        {
            if (db != null)
            {
                var obj1 = (db.Books.Where(x => x.BookId == id)).FirstOrDefault();
                if (obj != null)
                {
                    obj1.BookName = obj.BookName;
                    obj1.BookCopyno = obj.BookCopyno;
                    obj1.AuthorName = obj.AuthorName;
                    
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
            return 0;
        }

        public int Delete(int id)
        {
            int result = 0;

            if (db != null)
            {

                var post = db.Books.Where(x => x.BookId == id).FirstOrDefault();

                if (post != null)
                {

                    db.Books.Remove(post);
                    db.SaveChanges();
                    return 1;
                }
                return result;
            }

            return result;

        }
    }
}
