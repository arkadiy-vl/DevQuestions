using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuestions.Contracts
{
    public record CreatedQuestionDto(string Title, string Body, Guid UserId, Guid[] TagIds);
}

