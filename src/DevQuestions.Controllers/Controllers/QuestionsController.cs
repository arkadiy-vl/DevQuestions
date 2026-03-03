// using System.Security.Cryptography.X509Certificates;

using DevQuestions.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DevQuestions.Controllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreatedQuestionDto request,
            CancellationToken cancellationToken)
        {
            return Ok("Question created");
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            [FromQuery] GetQuestionDto request,
            CancellationToken cancellationToken)
        {
            return Ok("Questions got");
        }

        [HttpGet("{questionId:Guid}")]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid questionId,
            CancellationToken cancellationToken)
        {
            return Ok("Question got by Id");
        }

        [HttpPut("{questionId:Guid}")]
        public async Task<IActionResult> Update(
            [FromRoute] Guid questionId,
            [FromBody] UpdateQuestionDto request,
            CancellationToken cancellationToken)
        {
            return Ok("Question updated");
        }

        [HttpDelete("{questionId:Guid}")]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid questionId,
            CancellationToken cancellationToken)
        {
            return Ok("Question deleted");
        }

        [HttpPost("{questionId:Guid}/answers")]
        public async Task<IActionResult> AddAnswer(
            [FromRoute] Guid questionId,
            [FromBody] AddAnswerDto request,
            CancellationToken cancellationToken)
        {
            return Ok("Answer added");
        }

        [HttpPut("{questionId:guid}/solution{answerId:Guid}")]
        public async Task<IActionResult> SelectSolution(
            [FromRoute] Guid questionId,
            [FromQuery] Guid answerId)
        {
            return Ok("Solution selected");
        }
    }
}
