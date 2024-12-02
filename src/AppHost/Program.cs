DistributedApplicationOptions options = new();
DistributedApplicationBuilder builder = new(options);
builder.AddProject<Projects.App>("app");

var host = builder.Build();

await host.RunAsync();
