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

        public IActionResult Result()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult CrudForBooks(){
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult AddBook() //this is gonna set all the data addForm,  change name to AddBookForm
        {
            ViewData["Message"] = "Please, fill this form in.";
            return View();
        }


        [HttpPost]
        public IActionResult ResultAddBook(string name, string autor, string isbn, string year, int typeBook) //this is gonna set all the data addForm,  change name to AddBookForm
        {

            string Message = "All good";
            ModeloFacade facade = new ModeloFacade();
            try
            {
                Message = facade.CreateBook(name, autor, isbn, year, typeBook);

            }catch (Exception e)
            {
                Message = "Something Bad";
            }
            ViewData["Message"] = Message;
            return View();
        }
  

        public IActionResult ListBooks()
        {
            ViewData["Message"] = "Whatever you want to send, e.g. Array, datatable, etc.";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
