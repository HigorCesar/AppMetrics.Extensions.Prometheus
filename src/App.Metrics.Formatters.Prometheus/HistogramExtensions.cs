// <copyright file="TimeUnitConversions.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>
using System;

namespace App.Metrics.Formatters.Prometheus
{
    internal static class TimeUnitConversions
    {
        internal static double ToSeconds(this double value, TimeUnit timeUnit)
        {
            switch (timeUnit)
            {
                case TimeUnit.Days:
                    return TimeSpan.FromDays(value).TotalSeconds;
                case TimeUnit.Hours:
                    return TimeSpan.FromHours(value).TotalSeconds;
                case TimeUnit.Minutes:
                    return TimeSpan.FromMinutes(value).TotalSeconds;
                case TimeUnit.Microseconds:
                    return TimeSpan.FromSeconds(value).TotalSeconds;
                case TimeUnit.Milliseconds:
                    return TimeSpan.FromMilliseconds(value).TotalSeconds;
                case TimeUnit.Nanoseconds:
                    return TimeSpan.FromMilliseconds(value / 1000).TotalSeconds;
                default:
                 return value;
            }
        }
}
