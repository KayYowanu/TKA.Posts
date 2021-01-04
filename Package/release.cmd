"..\..\TheKingdomAge\oqtane.package\nuget.exe" pack TKA.Posts.nuspec 
XCOPY "*.nupkg" "..\..\TheKingdomAge\Oqtane.Server\wwwroot\Modules\" /Y
