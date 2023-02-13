using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StateController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<State> _stateRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public StateController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<State> stateRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _stateRepo = stateRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateState(StateDTO stateDTO)
        {
            var objCheck = _context.States.SingleOrDefault(opt => opt.StateName == stateDTO.StateName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    State state = new State();
                    state.StateName = stateDTO.StateName;
                    state.CreatedBy = stateDTO.CreatedBy;
                 
                    var obj = _stateRepo.Insert(state);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation
                {
                    Status = "error",
                    ResponseMsg = ex.Message
                });
            }
        }

        [HttpGet]
        public IActionResult GetStateList()
        {
            try
            {
                var list = (from u in _context.States
                            select new
                            {
                                u.StateId,
                                u.StateName,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false).ToList();

                return Ok(list);
            }
            catch(Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public IActionResult GetStatesList()
        {
            try
            {
                var list = (from u in _context.States
                            select new
                            {
                                u.StateId,
                                u.StateName,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false).ToList();
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{id}")]
        public ActionResult GetSingleState(int id)
        {
            try
            {
                var singleState= _stateRepo.SelectById(id);
                return Ok(singleState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateState(StateUpdateDTO stateUpdateDTO)
        {
            try
            {
                var objState = _context.States.SingleOrDefault(opt => opt.StateId == stateUpdateDTO.StateId);
                objState.StateName = stateUpdateDTO.StateName;
                objState.UpdatedBy = stateUpdateDTO.CreatedBy;
                objState.UpdatedOn = System.DateTime.Now; ;
                _context.SaveChanges();
                return Ok(objState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [Authorize(Roles = "Admin")]
        [HttpGet("{stateid}/{DeletedBy}")]
        public ActionResult DeleteState(int stateid, int DeletedBy)
        {
            try
            {
                var State = _context.States.SingleOrDefault(opt => opt.StateId == stateid);
                State.IsDeleted = true;
                State.UpdatedBy = DeletedBy;
                State.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(State);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
