using BoardGameHub.Domain.Entities;
using BoardGameHub.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace BoardGameHub.Web.Controllers
{
	public class JogosController : Controller
	{
		private readonly ApplicationDbContext _db;

		public JogosController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			var jogos = _db.db_Jogos.ToList();

			return View(jogos);
		}

		//GET
		public IActionResult Create()
		{
			return View();
		}

		//POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Jogos obj)
		{
			if (obj.Name == obj.Description) 
			{
				ModelState.AddModelError("Description", "A descrição não pode ser igual ao nome");		
			}

			if (ModelState.IsValid)
			{
				_db.db_Jogos.Add(obj);
				_db.SaveChanges();

                TempData["success"] = "O jogo foi criado com sucesso.";

                return RedirectToAction(nameof(Index));
			}

            TempData["error"] = "Erro ao criar o Jogo.";
            return View(obj);
		}

		public IActionResult Update(int jogosId) 
		{
			Jogos? obj = _db.db_Jogos.FirstOrDefault(u => u.Id == jogosId);


			if (obj == null)
			{
				return RedirectToAction("Error", "Home");
			}

			return View(obj);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(Jogos obj)
		{
			if (ModelState.IsValid && obj.Id > 0)
			{
				_db.db_Jogos.Update(obj);
				_db.SaveChanges();

                TempData["success"] = "O jogo foi editado com sucesso.";

                return RedirectToAction(nameof(Index));
			}

            TempData["error"] = "Erro ao editar o Jogo.";
            return View(obj);
		}
		public IActionResult Delete(int jogosId)
		{
			Jogos? obj = _db.db_Jogos.FirstOrDefault(u => u.Id == jogosId);


			if (obj == null)
			{
				return RedirectToAction("Error", "Home");
			}

			return View(obj);
		}

		[HttpPost]
		public IActionResult Delete(Jogos obj)

		{
			Jogos? objFromDb = _db.db_Jogos.FirstOrDefault(u => u.Id == obj.Id);

			if (objFromDb is not null)
			{
				_db.db_Jogos.Remove(objFromDb);
				_db.SaveChanges();

				TempData["success"] = "O jogo foi apagado com sucesso.";

				return RedirectToAction(nameof(Index));
			}

            TempData["error"] = "Erro ao apagar o Jogo.";
            return View(obj);
		}
	}
}
