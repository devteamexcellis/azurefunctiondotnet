using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TankTemp
{
    public string? Location { get; set; }

    public string? DelId { get; set; }

    public string? Type { get; set; }

    public string? SerialNumber { get; set; }

    public decimal? TankSize { get; set; }

    public decimal? IdealVolume { get; set; }

    public string? Codelivr { get; set; }

    public string? K1 { get; set; }

    public DateOnly? Date1 { get; set; }

    public decimal? Vol1 { get; set; }

    public string? TankMonitorCode { get; set; }

    public string? TankMonitor { get; set; }
}
