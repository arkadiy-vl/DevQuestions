using JetBrains.Annotations;

namespace DevQuestions.Contracts
{
    [UsedImplicitly]
    public record UpdateQuestionDto(string Title, string Body, Guid[] TagIds);
}
