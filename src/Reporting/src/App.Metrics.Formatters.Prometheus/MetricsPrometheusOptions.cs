﻿// <copyright file="MetricsPrometheusOptions.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using System;
using App.Metrics.Formatters.Prometheus.Internal;

namespace App.Metrics.Formatters.Prometheus
{
    /// <summary>
    ///     Provides programmatic configuration for Prometheus format in the App Metrics framework.
    /// </summary>
    public class MetricsPrometheusOptions
    {
        public MetricsPrometheusOptions()
        {
            MetricNameFormatter = PrometheusFormatterConstants.MetricNameFormatter;
        }

        public Func<string, string, string> MetricNameFormatter { get; set; }

        public NewLineFormat NewLineFormat { get; set; } = NewLineFormat.Default;
    }
}
