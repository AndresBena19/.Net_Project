using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class ModeloFacade
    {

        public string CreateBook(string name, string autor, string isbn, string year, int typeBook)
        {
            return new AddBooks().AddBookLibrary(name, autor,  isbn, year, typeBook);
        }
    }
}
