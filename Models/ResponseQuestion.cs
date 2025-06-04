using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ResponseQuestion
{
    public int Id { get; set; }

    public int FkResponseId { get; set; }

    public int FormQuestionReferenceId { get; set; }

    public string QuestionType { get; set; } = null!;

    public string Label { get; set; } = null!;

    public bool IsRequired { get; set; }

    public string? Answer { get; set; }

    public int Sequence { get; set; }

    public string? Guid { get; set; }

    public string? UrlBase { get; set; }

    public string? UrlEntity { get; set; }

    public string? UrlContainer { get; set; }

    public string? Filename { get; set; }

    public virtual Response FkResponse { get; set; } = null!;

    public virtual ICollection<ResponseSubQuestion> ResponseSubQuestions { get; set; } = new List<ResponseSubQuestion>();
}
