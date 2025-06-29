using Microsoft.AspNetCore.Mvc;
using ConstrutoraApp.Models;
using ConstrutoraApp.Data.Repositories;

namespace ConstrutoraApp.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IGenericRepository<Cliente> _repository;

        public ClientesController(IGenericRepository<Cliente> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index() => View(await _repository.GetAllAsync());

        public async Task<IActionResult> Details(int id) => View(await _repository.GetByIdAsync(id));

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);
            await _repository.AddAsync(cliente);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id) => View(await _repository.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);
            await _repository.UpdateAsync(cliente);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id) => View(await _repository.GetByIdAsync(id));

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
