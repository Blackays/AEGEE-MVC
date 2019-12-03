using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AEGEE_MVC.Data;
using AEGEE_MVC.Models;

namespace AEGEE_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDBContent _context;

        public UserController(AppDBContent context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        } 
    }
}
