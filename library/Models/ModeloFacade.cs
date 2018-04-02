using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class ModeloFacade
    {
        public string CreateBook(string name, string autor, string isbn, string year, string typeBook)
        {
            return new AddBooks().AddBookLibrary(name, autor, isbn, year, typeBook);
        }
        public string DeleteBook(string name)
        {
            return new DeleteBook().DeleteBookLibrary(name);
        }

        public string UpdateBook(int id, string name, string autor, string isbn, string year, string typeBook)
        {
            return new UpdateBook().UpdateBookLibrary(id,name,autor,isbn,year,typeBook);
        }

        public string AddTypeBook(string Type)
        {
            return new AddTypeBook().AddTypeBookLibrary(Type);
        }
        public string DeleteTypeBook(string Type)
        {
            return new DeleteTypeBook().DeleteTypeBookLibrary(Type);
        }

        public Dictionary<string, Dictionary<string, string>> SelectAllBooks()
        {
            return new SelectAllBooks().SelectAllBookLibrary();
        }


        public Dictionary<string, string> SelectAllTypeBooks()
        {
            return new SelectAllTypeBooks().SelectAllTypeBookLibrary();
        }



    }
}
