// <copyright file="HistogramExtensions.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>
using System;

namespace App.Metrics.Formatters.Prometheus
{
    public static class HistogramExtensions
    {
        public static double ToSeconds(this double value) => TimeSpan.FromMilliseconds(value).TotalSeconds;
    }
}
