using BoardGameHub.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Web.Controllers
{
    public class JogosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public JogosController(ApplicationDbContext db)
        {
            _db= db;
        }

        public IActionResult Index()
        {
            var jogos= _db.db_Jogos.ToList();

            return View(jogos);
        }
    }
}
