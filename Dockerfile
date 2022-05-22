FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY AcnhMate.Api/bin/Release/net6.0/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "AcnhMate.Api.dll"]