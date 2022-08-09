using Microsoft.AspNetCore.Mvc;
using W3Class.Models;

namespace W3Class.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult show()
        {
            List<Author> authors = new List<Author>
            {
                new Author{AuthorId=1,AuthorName="Tatiana Pas", Book="C# for lazy people", Price=100.50 },
                new Author{AuthorId=2,AuthorName="Mr Johns", Book="New Life", Price=80.50 },
                new Author{AuthorId=3,AuthorName="Victor Choy", Book="Study Python", Price=70 },
                new Author{AuthorId=4,AuthorName="Mike Johns ", Book="The beginning", Price=169.99 },
                new Author{AuthorId=5,AuthorName="Vikky Reeds", Book="How to", Price=45.99 },
                new Author{AuthorId=6,AuthorName="Olly Pasttr", Book="Stop doing this now", Price=75 },
            };
            return View(authors);
        }
    }
}
