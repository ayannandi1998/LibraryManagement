using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement3.Model;

namespace LibraryManagement3.Repository
{
     public interface IBookRep
     {
         List<Book> GetDetails();
         Book GetDetail(int id);
         int AddDetail(Book obj);
         int UpdateDetail(int id, Book obj);
         int Delete(int id);
        
     }
}
