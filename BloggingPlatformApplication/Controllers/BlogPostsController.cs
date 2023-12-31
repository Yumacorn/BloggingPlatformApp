﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BloggingPlatformApplication.Data;
using BloggingPlatformApplication.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;


namespace BloggingPlatformApplication.Controllers
{
    public class BlogPostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAuthorizationService _authorizationService;

        public BlogPostsController(IAuthorizationService authorizationService, ApplicationDbContext context)
        {
            _context = context;
            _authorizationService = authorizationService;
        }

        // GET: BlogPosts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BlogPost.Include(b => b.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BlogPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BlogPost == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }

        // GET: BlogPosts/Create
        public IActionResult Create()
        {
            //var authorizationResult = await _authorizationService
            //.AuthorizeAsync(User, BlogPost, "CreatePolicy");
            //Debug.WriteLine(authorizationResult);


            ViewData["UserId"] = new SelectList(_context.User, "Id", "Email");
            ViewData["User"] = new SelectList(_context.User.ToList());
            return View();
        }

        // POST: BlogPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,UserId,Created,LastUpdated")] BlogPost blogPost)
        {
            var tempUser = await _context.User.FirstOrDefaultAsync(m => m.Id == blogPost.UserId);
            //Debug.WriteLine(tempUser);
            blogPost.User = tempUser;
            //Debug.WriteLine(ModelState);
            //@TODO: Add EF Interceptor for DateTime value
            Debug.WriteLine(DateTime.Now);
            blogPost.Created = DateTime.Now;
            blogPost.LastUpdated = DateTime.Now;
            Debug.WriteLine(blogPost.Created);
            Debug.WriteLine(blogPost.LastUpdated);
            if (ModelState.IsValid)
            {
                _context.Add(blogPost);
                Debug.WriteLine(blogPost);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Email", blogPost.UserId);
            return View(blogPost);
        }

        // GET: BlogPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BlogPost == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost.FindAsync(id);
            if (blogPost == null)
            {
                return NotFound();
            }

            // TODO: Troubleshoot User.Identities[0].name when "logged in" should return a user. Adjust Policy
            var authorizationResult = await _authorizationService
            .AuthorizeAsync(User, blogPost, "UserLoggedIn");
            Debug.WriteLine(authorizationResult);

            ViewData["UserId"] = new SelectList(_context.User, "Id", "Email", blogPost.UserId);
            return View(blogPost);
        }

        // POST: BlogPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,UserId")] BlogPost blogPost)
        {
            if (id != blogPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostExists(blogPost.Id))
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
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Email", blogPost.UserId);
            return View(blogPost);
        }

        // GET: BlogPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BlogPost == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }

        // POST: BlogPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BlogPost == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BlogPost'  is null.");
            }
            var blogPost = await _context.BlogPost.FindAsync(id);
            if (blogPost != null)
            {
                _context.BlogPost.Remove(blogPost);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostExists(int id)
        {
          return (_context.BlogPost?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
