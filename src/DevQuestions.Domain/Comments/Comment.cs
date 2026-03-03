using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuestions.Domain.Comments
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required string Text { get; set; }
        public Comment? parrent { get; set; }
        public List<Comment> children { get; set; } = [];
        public required Guid EntityId { get; set; }

    }
}
