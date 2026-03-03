using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuestions.Domain.Reports;

public class Report
{
    public Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required Guid RepotedUserId { get; set; }
    public required string Reason { get; set; }
    public Status Status { get; set; } = Status.Open;
    public Guid? ResolvedByUserId { get; set; }
    public Guid? ScreenshotId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    
}

