using Microsoft.AspNetCore.Mvc;
using NLog;

namespace SudokuServer.Controllers
{
    [ApiController]
    [Route("[controller]/API")]
    public class SudokuController : ControllerBase
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        [HttpGet("Status")]
        public string HealthCheck()
        {
            //TODO: HealthCheck
            return "I'm healthy";
        }

        [HttpPost("Solve")]
        public IActionResult Solve( char[][] board)
        {
            if (board == null)
            {
                return BadRequest("Invalid board. Please provide a valid Sudoku puzzle.");
            }

            // TODO: Perform additional validation

            try
            {
                // TODO: Solve the Sudoku puzzle using the provided board
                char[,] randomResult = new char[,]
                {
                    {'5', '2', '9', '1', '4', '3', '7', '6', '8'},
                    {'3', '1', '6', '2', '7', '9', '4', '5', '8'},
                    {'4', '6', '7', '5', '9', '8', '2', '3', '1'},
                    {'9', '5', '3', '8', '2', '7', '6', '4', '1'},
                    {'2', '8', '7', '6', '5', '4', '9', '1', '3'},
                    {'6', '4', '1', '9', '3', '5', '8', '2', '7'},
                    {'8', '6', '2', '7', '1', '4', '3', '9', '5'},
                    {'1', '3', '4', '8', '2', '9', '5', '7', '6'},
                    {'4', '8', '3', '6', '1', '9', '7', '5', '2'}
                };

                return Ok(randomResult);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occurred while solving the Sudoku puzzle.");
                return StatusCode(500, "An error occurred while solving the Sudoku puzzle. Please try again later.");
            }
        }
    }
}