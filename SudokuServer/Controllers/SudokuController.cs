using Microsoft.AspNetCore.Mvc;

namespace SudokuServer.Controllers
{
    public class SudokuController : ControllerBase
    {
        private readonly ILogger<SudokuController> _logger;

        public SudokuController(ILogger<SudokuController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Status")]
        public string GetStatus()
        {
            return "Returns Status";
        }
    }
}