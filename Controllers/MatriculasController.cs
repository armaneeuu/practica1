using Microsoft.AspNetCore.Mvc;
using practica1.Models;
using practica1.Data;
using System.Linq;

namespace practica1.Controllers
{
    public class MatriculasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatriculasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.DataMatriculas.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Matriculas objMatriculas)
        {
            _context.Add(objMatriculas);
            _context.SaveChanges();
            ViewData["Message"] = "Se ha registrado satisfactoriamente";
            return View();
        }

        public IActionResult Edit(int id)
        {
            Matriculas objMatriculas = _context.DataMatriculas.Find(id);
            if (objMatriculas == null)
            {
                return NotFound();
            }
            return View(objMatriculas);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,Name,Categoria,Precio,Descuento")] Matriculas objMatriculas)
        {
            _context.Update(objMatriculas);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto ya esta actualizado";
            return View(objMatriculas);
        }
        public IActionResult Delete(int id)
        {
            Matriculas objMatriculas = _context.DataMatriculas.Find(id);
            _context.DataMatriculas.Remove(objMatriculas);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}