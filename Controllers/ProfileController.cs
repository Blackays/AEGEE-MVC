using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AEGEE_MVC.Data;
using AEGEE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AEGEE_MVC.Controllers
{
    public class ProfileController : Controller
    {
        private AppDBContent db;
        public ProfileController(AppDBContent context)
        {
            db = context;
        }

        public async Task<IActionResult> EditAge(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAge(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }
            User newuser = await db.Users.FirstOrDefaultAsync(c => c.UserId == id);
            newuser.Age = user.Age;
            db.Update(newuser);
            await db.SaveChangesAsync();
            return RedirectToAction("Details", "Profile", new { id=id });
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {

            if (id == 0)
            {
                return NotFound();
            }

            var user = await db.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(user);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }
        private bool UserExists(int id)
        {
            return db.Users.Any(e => e.UserId == id);
        }

        public async Task<IActionResult> EditEmail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEmail(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }
            User newuser = await db.Users.FirstOrDefaultAsync(c => c.UserId == id);
            newuser.Email = user.Email;
            db.Update(newuser);
            await db.SaveChangesAsync();
            return RedirectToAction("Details", "Profile", new { id = id });
        }

        public async Task<IActionResult> EditName(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditName(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }
            User newuser = await db.Users.FirstOrDefaultAsync(c => c.UserId == id);
            newuser.Name = user.Name;
            newuser.Surname = user.Surname;
            db.Update(newuser);
            await db.SaveChangesAsync();
            return RedirectToAction("Details", "Profile", new { id = id });
        }

        public async Task<IActionResult> EditPassword(int? id)
        {
            if (id == null)
            {
                return Content("id not found");
            }

            var user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return Content("user not found");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPassword(int id, EditPasswordModel user)
        {
            User newuser = await db.Users.FirstOrDefaultAsync(c => c.UserId == id);
            if (id != newuser.UserId)
            {
                return NotFound();
            }        
            if (user.CurrentPassword == newuser.Password)
            {
                newuser.Password = user.Password;
                db.Update(newuser);
                await db.SaveChangesAsync();
                return RedirectToAction("Details", "Profile", new { id = id });
            }
            else
            {
                return View();
                //return Content(newuser.Password);

            }

        }
    }
}