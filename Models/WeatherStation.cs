using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class WeatherStation
{
    public int Id { get; set; }

    public string? StationName { get; set; }

    public string? StationId { get; set; }

    public virtual ICollection<RegionProductWeatherMap> RegionProductWeatherMaps { get; set; } = new List<RegionProductWeatherMap>();
}
