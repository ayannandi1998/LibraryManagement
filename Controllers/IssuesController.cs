using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement3.Model;
using LibraryManagement3.Repository;

namespace LibraryManagement3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        readonly log4net.ILog _log4net;

        IIssueRep db;

        public IssuesController(IIssueRep _db)
        {
            db = _db;
            _log4net = log4net.LogManager.GetLogger(typeof(IssuesController));
        }

        // GET: api/SalaryDetail
        [HttpGet]
        public IActionResult Get()
        {
            _log4net.Info("IssueController GET ALL Action Method called");
            try
            {
                var obj = db.GetDetails();
                if (obj == null)
                    return NotFound();
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        // GET: api/SalaryDetail/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var obj = db.GetDetail(id);
                if (obj == null)
                    return NotFound();
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // POST: api/SalaryDetail
        [HttpPost]
        public IActionResult Post([FromBody] Issue obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = db.AddDetail(obj);
                    if (res != 0)
                        return Ok(res);

                    return NotFound();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        // PUT: api/SalaryDetail/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Issue obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = db.UpdateDetail(id, obj);
                    if (result != 1)
                        return NotFound();

                    return Ok(result);
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName ==
                             "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var res = db.Delete(id);
                if (res != 0)
                    return Ok(res);
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}