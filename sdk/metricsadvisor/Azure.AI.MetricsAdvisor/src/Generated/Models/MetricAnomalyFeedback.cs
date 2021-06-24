// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor.Models;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> The AnomalyFeedback. </summary>
    public partial class MetricAnomalyFeedback : MetricFeedback
    {

        /// <summary> Initializes a new instance of MetricAnomalyFeedback. </summary>
        /// <param name="type"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdTime"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <param name="startTime"> the start timestamp of feedback time range. </param>
        /// <param name="endTime"> the end timestamp of feedback time range, when equals to startTime means only one timestamp. </param>
        /// <param name="valueInternal"> . </param>
        /// <param name="anomalyDetectionConfigurationId"> the corresponding anomaly detection configuration of this feedback. </param>
        /// <param name="anomalyDetectionConfigurationSnapshot"> . </param>
        internal MetricAnomalyFeedback(MetricFeedbackType type, string id, DateTimeOffset? createdTime, string userPrincipal, string metricId, FeedbackDimensionFilter dimensionFilter, DateTimeOffset startTime, DateTimeOffset endTime, AnomalyFeedbackValue valueInternal, string anomalyDetectionConfigurationId, AnomalyDetectionConfiguration anomalyDetectionConfigurationSnapshot) : base(type, id, createdTime, userPrincipal, metricId, dimensionFilter)
        {
            StartTime = startTime;
            EndTime = endTime;
            ValueInternal = valueInternal;
            AnomalyDetectionConfigurationId = anomalyDetectionConfigurationId;
            AnomalyDetectionConfigurationSnapshot = anomalyDetectionConfigurationSnapshot;
            Type = type;
        }
    }
}
