# ASP.NET Core logging in Azure

Some KDL queries for the traces or the exceptions

```
traces
| where * hassuffix "my home"
| and severityLevel >= 2
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

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/logging

https://learn.microsoft.com/en-us/azure/azure-monitor/app/ilogger

https://learn.microsoft.com/en-us/azure/azure-monitor/app/tutorial-asp-net-core

https://jonathancrozier.com/blog/learning-the-kusto-query-language-with-application-insights-logs
