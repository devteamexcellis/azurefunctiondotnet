using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class FormSubQuestion
{
    public int Id { get; set; }

    public int FkQuestionId { get; set; }

    public int Sequence { get; set; }

    public string Label { get; set; } = null!;

    public virtual FormQuestion FkQuestion { get; set; } = null!;
}
