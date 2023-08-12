# ASP.NET Core logging in Azure

[![.NET](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/dotnet.yml) [![Deploy to Azure](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/azure-webapps-dotnet-core.yml/badge.svg)](https://github.com/damienbod/aspnetcore-azure-logging/actions/workflows/azure-webapps-dotnet-core.yml)

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

```
traces
| where * hassuffix "my home"
and severityLevel >= 1
```

## Links

https://github.com/serilog/serilog

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/logging

https://learn.microsoft.com/en-us/azure/azure-monitor/app/ilogger

https://learn.microsoft.com/en-us/azure/azure-monitor/app/tutorial-asp-net-core

https://jonathancrozier.com/blog/learning-the-kusto-query-language-with-application-insights-logs
