using System.Linq;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;

namespace WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IBookRepository repository;

        public AdminController(IBookRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Books);
        }

        public ViewResult Edit(int bookId)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            return View(book);
        }
    }
}