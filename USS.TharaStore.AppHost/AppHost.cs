var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.USS_TharaStore_ApiService>("apiService")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.USS_TharaStore_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
