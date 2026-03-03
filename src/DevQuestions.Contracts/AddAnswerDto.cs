using JetBrains.Annotations;

namespace DevQuestions.Contracts
{
    [UsedImplicitly]
    public record AddAnswerDto(Guid UserId, string TextAnswer);
}
