using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AEGEE_MVC.Data;
using AEGEE_MVC.Models;
using AEGEE_MVC.Data.Interfaces;

namespace AEGEE_MVC.Controllers
{
    public class DescriptionsController : Controller
    {
        private readonly AppDBContent _context;
        private readonly IAllDesc allDesc;
        public DescriptionsController(AppDBContent context, IAllDesc allDesc)
        {
            _context = context;
            this.allDesc = allDesc;
        }

        public IActionResult Index(int id)
        {
            User user = _context.Users.FirstOrDefault(c => c.UserId == id);
            DescOfUserModel des = new DescOfUserModel
            {
                Name = user.Name,
                Surname = user.Surname,
                UserId = user.UserId,
                Desc = allDesc.GetAllDescOfUser(user.UserId)
            };
            return View(des);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptions = await _context.Descriptions
                .FirstOrDefaultAsync(m => m.DescId == id);
            if (descriptions == null)
            {
                return NotFound();
            }

            return View(descriptions);
        }

        public IActionResult Create(int? id)
        {
            User user = _context.Users.FirstOrDefault(c => c.UserId == id);
            var person = new DescCreateModel
            {
                Name = user.Name,
                Surname = user.Surname,
                UserId = user.UserId
            };
            return View(person);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, DescCreateModel descriptions)
        {

                User Cuser = await _context.Users.FirstOrDefaultAsync(c => c.UserId == id);
                Descriptions desc = new Descriptions();
                desc.Description = descriptions.Desc.Description;
                desc.UserCharacterId = Cuser;
                desc.UserAuthorId = descriptions.UserAuthorId;

                _context.Add(desc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
                //return Content(descriptions.UserAuthorId+ "      " + descriptions.Desc.Description + "      "   + id );
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptions = await _context.Descriptions.FindAsync(id);
            if (descriptions == null)
            {
                return NotFound();
            }
            return View(descriptions);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DescId,Description")] Descriptions descriptions)
        {
            if (id != descriptions.DescId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(descriptions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DescriptionsExists(descriptions.DescId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(descriptions);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptions = await _context.Descriptions
                .FirstOrDefaultAsync(m => m.DescId == id);
            if (descriptions == null)
            {
                return NotFound();
            }

            return View(descriptions);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var descriptions = await _context.Descriptions.FindAsync(id);
            _context.Descriptions.Remove(descriptions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DescriptionsExists(int id)
        {
            return _context.Descriptions.Any(e => e.DescId == id);
        }
    }
}
