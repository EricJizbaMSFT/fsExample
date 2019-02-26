namespace Company.Function

open Microsoft.AspNetCore.Mvc
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Logging

module HttpTrigger =

  let run(req: HttpRequest, log: ILogger) =
    log.LogInformation("F# HTTP trigger function processed a request.");
    ContentResult(Content = "Hello World", ContentType = "text/html")