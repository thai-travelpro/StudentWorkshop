using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProOnline.Gds.WebServices.Logs.Web.Data;

namespace ProOnline.Gds.WebServices.Logs.Web.Controllers
{
    public class WebServiceLogsController : Controller
    {
        private readonly LogsDbContext _context;

        public WebServiceLogsController(LogsDbContext context)
        {
            _context = context;
        }

        // GET: WebServiceLogs

        public async Task<IActionResult> Index()
        {
            //var rows = new string[100];

            //int page = 1;
            //int rowPage = 10;

            //var totalPage = rows.Length / rowPage;

            return View(_context.WebServiceLogs.Take(10));
        }

        // POST: WebServiceLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Models.SearchModel Search)
        {

            var models = new List<WebServiceLog>();
            

            if (ModelState.IsValid)
            {
                //var webServiceLog = await _context.WebServiceLogs.FirstOrDefaultAsync(models => models.Host == Search);
                //_context.Add(webServiceLog);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            } 
            //return View(webServiceLog);
            return View(models);
        }


        // GET: WebServiceLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webServiceLog = await _context.WebServiceLogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webServiceLog == null)
            {
                return NotFound();
            }

            return View(webServiceLog);
        }

        // GET: WebServiceLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebServiceLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreationDate,Gds,Host,Pcc,Username,WebServiceName,Version,SuccessedReq,SuccessedResp,TotalMillieseconds")] WebServiceLog webServiceLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(webServiceLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(webServiceLog);
        }

        // GET: WebServiceLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webServiceLog = await _context.WebServiceLogs.FindAsync(id);
            if (webServiceLog == null)
            {
                return NotFound();
            }
            return View(webServiceLog);
        }

        // POST: WebServiceLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreationDate,Gds,Host,Pcc,Username,WebServiceName,Version,SuccessedReq,SuccessedResp,TotalMillieseconds")] WebServiceLog webServiceLog)
        {
            if (id != webServiceLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(webServiceLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebServiceLogExists(webServiceLog.Id))
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
            return View(webServiceLog);
        }

        // GET: WebServiceLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webServiceLog = await _context.WebServiceLogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webServiceLog == null)
            {
                return NotFound();
            }

            return View(webServiceLog);
        }

        // POST: WebServiceLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var webServiceLog = await _context.WebServiceLogs.FindAsync(id);
            _context.WebServiceLogs.Remove(webServiceLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebServiceLogExists(int id)
        {
            return _context.WebServiceLogs.Any(e => e.Id == id);
        }
    }
}