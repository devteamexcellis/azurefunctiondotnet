using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ResponseSubQuestion
{
    public int Id { get; set; }

    public int FkResponseQuestionId { get; set; }

    public int FormSubQuestionReferenceId { get; set; }

    public string Label { get; set; } = null!;

    public int Sequence { get; set; }

    public string? Answer { get; set; }

    public virtual ResponseQuestion FkResponseQuestion { get; set; } = null!;
}
