using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using library.Models;

namespace library.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Please, choose an option";
            return View();
        }

        public IActionResult CrudForBooks(){ //return CRUD Books' View
            return View();
        }

        public IActionResult CrudForTypeBooks() //return CRUD type of Books' View
        {
            return View();
        }

        public IActionResult AddBook() //this is gonna set all the data addForm,  change name to AddBookForm
        {
            ViewData["Message"] = "Please, fill this form in.";
            return View();
        }

        public IActionResult UpdateBook() //this is gonna set all the data addForm,  change name to AddBookForm
        {
            ViewData["Message"] = "Please, fill this form in.";
            return View();
        }

        public IActionResult ResultDeleteBookForm(string typeId) //form to delete a book
        {
            string Message = "All good at begin";
            ModeloFacade facade = new ModeloFacade();
            try
            {
                Message = facade.DeleteBook(typeId);

            }
            catch (Exception e)
            {
                Message = "Something Bad";
            }
            ViewData["Message"] = Message;
            return View("Index");
        }


        public IActionResult DeleteBookForm(string typeId) //form to delete a book
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResultUpdateBook(int id,string name, string author, string isbn, string year, string typeBook)
        {
            string Message = "All good at begin";
            ModeloFacade facade = new ModeloFacade();
            try
            {
                Message = facade.UpdateBook(id, name, author, isbn, year, typeBook);

            }
            catch (Exception e)
            {
                Message = "Something Bad";
            }
            ViewData["Message"] = Message;

            ViewBag.Message = Message;

            return View("Index");
        }



        [HttpPost]
        public IActionResult ResultAddBook(string name, string author, string isbn, string year, string typeBook)
        {
            string Message = "All good at begin";
            ModeloFacade facade = new ModeloFacade();
            try
            {
                Message = facade.CreateBook(name, author, isbn, year, typeBook);

            }
            catch (Exception e)
            {
                Message = "Something Bad";
            }
            ViewData["Message"] = Message;
            return View("Index");
        }
        
        public IActionResult ResultAddTypeBook(string typeBook) //agrega los datos a la DB
        {
            //back-end section
            ViewData["Result"] = "If everything went good or bad";
            return View();
        }

        public IActionResult DeleteTypeBookForm(string typeId) //form to delete a book
        {
            string Message = "All good at begin";
            ModeloFacade facade = new ModeloFacade();
            try
            {
                Message = facade.DeleteTypeBook(typeId);

            }
            catch (Exception e)
            {
                Message = "Something Bad";
            }
            ViewData["Message"] = Message;
            return View("Index");
        }

        [HttpGet]
        public IActionResult ListBooks() //lista los libros
        {
            string Message = null;
            Dictionary<string, Dictionary<string, string>> Books = new Dictionary<string, Dictionary<string, string>>();
            ModeloFacade facade = new ModeloFacade();
            try
            {
                Books = facade.SelectAllBooks();
                Message = "All gods";

            }
            catch (Exception e)
            {
                Message= "Somethig Bad";
            }

            ViewData["Books"] = Books;
            return View(ViewData);
        }


        public IActionResult AddTypeBookForm(string type) //formulario para agregar el tipo de libro, si existe no debe agregarlo
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResultAddTypeBookForm(string type) //formulario para agregar el tipo de libro, si existe no debe agregarlo
        {
            string Message = "All good at begin";
            ModeloFacade facade = new ModeloFacade();
            try
            {
                Message = facade.AddTypeBook(type);

            }
            catch (Exception e)
            {
                Message = "Something Bad";
            }
   

            ViewBag.Message = Message;
            return View("Index");
        }

        [HttpGet]
        public IActionResult ListType() //lista los tipos
        {
            string Message = null;
            Dictionary<string, string> TypeBooks = new Dictionary<string, string>();
            ModeloFacade facade = new ModeloFacade();
            try
            {

                TypeBooks = facade.SelectAllTypeBooks();
                Message = "AllGOod";

            }
            catch (Exception e)
            {
                Message = "Something Bad";
            }

            ViewBag.Error = Message;
            ViewData["TypesBooks"] = TypeBooks;
            return View(ViewData);
        }

        public IActionResult DeleteTypeForm() //retorna la vista para que se le solicite al user el id a eliminar
        {
            //back-end section
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public IActionResult ResultDelete(string typeId, string forDelete) 
        {
             return View();
            
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
