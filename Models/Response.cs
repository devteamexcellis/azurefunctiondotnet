using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Response
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string ResponseCode { get; set; } = null!;

    public DateTime DateSubmitted { get; set; }

    public int FormReferenceId { get; set; }

    public string FormType { get; set; } = null!;

    public string FormName { get; set; } = null!;

    public string? RespondentUserId { get; set; }

    public string? RespondentName { get; set; }

    public string? RespondentEmail { get; set; }

    public string? RespondentContactNumber { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual ICollection<ResponseQuestion> ResponseQuestions { get; set; } = new List<ResponseQuestion>();
}
