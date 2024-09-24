using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task2.Data;
using Task2.Models;

namespace Task2.Controllers
{
    public class TransactionController : Controller
    {
        private readonly AppDbContext _context;
        public TransactionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Transaction> transactions = _context.Transaction.Include(x => x.Category).ToList();
            return View(transactions);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            Transaction transaction = new();
            transaction.Categories = _context.Category.ToList();
            return View(transaction);
        }

        [HttpPost]
        public IActionResult Create(Transaction transaction)
        {
            _context.Transaction.Add(transaction);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
