using Microsoft.SemanticKernel;
using System.ComponentModel;

public class DataRetrievalPlugin
{
    [KernelFunction("GetDatabaseTelemetry")]
    [Description("Retrieves the current CPU and memory telemetry for a given database cluster.")]
    public string GetDatabaseTelemetry(
        [Description("The ID of the database cluster")] string clusterId)
    {
        // In a real system, this queries the actual infrastructure observability tool
        return $"Cluster {clusterId} status: CPU 45%, Memory 82%. No active alerts.";
    }
}