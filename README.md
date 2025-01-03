# ASP.NET Core logging in Azure

[![.NET](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/dotnet.yml) [![Deploy to Azure](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/azure-webapps-dotnet-core.yml/badge.svg)](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/azure-webapps-dotnet-core.yml)

[ASP.NET Core Logging using Serilog and Azure]([https://damienbod.com](https://damienbod.com/2023/08/21/asp-net-core-logging-using-serilog-and-azure/))

Some KDL queries for the traces or the exceptions

```
traces
| where * hassuffix "my home"
and severityLevel >= 2
```

```
exceptions
| where * hassuffix "FIND"
```

## History

- 2024-12-31 .NET 9
- 2024-10-26 Updated packages
- 2024-01-14 Updated packages, remove AzureApp sink
- 2023-11-26 .NET 8
- 2023-08-27 clean up packages for Serilog

## Links

https://github.com/rufer7/aspnetcore-serilog-azureappservice

https://github.com/serilog/serilog

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/logging

https://learn.microsoft.com/en-us/azure/azure-monitor/app/ilogger

https://learn.microsoft.com/en-us/azure/azure-monitor/app/tutorial-asp-net-core

https://jonathancrozier.com/blog/learning-the-kusto-query-language-with-application-insights-logs
