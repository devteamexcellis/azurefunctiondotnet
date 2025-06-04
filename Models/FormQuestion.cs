using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class FormQuestion
{
    public int Id { get; set; }

    public int FkFormId { get; set; }

    public string QuestionType { get; set; } = null!;

    public string Label { get; set; } = null!;

    public bool IsRequired { get; set; }

    public int Sequence { get; set; }

    public virtual Form FkForm { get; set; } = null!;

    public virtual ICollection<FormSubQuestion> FormSubQuestions { get; set; } = new List<FormSubQuestion>();
}
