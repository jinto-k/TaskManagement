using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ReportsController : ControllerBase
    {
        private readonly TaskManagementContext _context;

        public ReportsController(TaskManagementContext context)
        {
            _context = context;
        }

        [HttpGet("tasks-due")]
        public async Task<IActionResult> GetTasksDue([FromQuery] int days)
        {
            var dueDate = DateTime.Now.AddDays(days);
            var tasks = await _context.Tasks
                .Where(t => t.DueDate <= dueDate && t.Status != "Completed")
                .ToListAsync();
            return Ok(tasks);
        }

        [HttpGet("team-performance")]
        public async Task<IActionResult> GetTeamPerformance()
        {
            var teamStats = await _context.Teams
                .Select(t => new
                {
                    TeamName = t.Name,
                    TotalTasks = t.Users.SelectMany(u => u.Tasks).Count(),
                    CompletedTasks = t.Users.SelectMany(u => u.Tasks).Count(t => t.Status == "Completed"),
                    OverdueTasks = t.Users.SelectMany(u => u.Tasks).Count(t => t.DueDate < DateTime.Now && t.Status != "Completed")
                })
                .ToListAsync();

            return Ok(teamStats);
        }
    }

}
