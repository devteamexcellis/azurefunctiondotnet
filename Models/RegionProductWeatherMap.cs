using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RegionProductWeatherMap
{
    public int Id { get; set; }

    public int? FkRegionId { get; set; }

    public int? FkProductId { get; set; }

    public int? FkWeatherStationId { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual Region? FkRegion { get; set; }

    public virtual WeatherStation? FkWeatherStation { get; set; }
}
