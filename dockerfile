FROM mcr.microsoft.com/dotnet/core/sdk
WORKDIR /app
COPY . .
#ENV ASPNETCORE_URLS='http://*:5000'
CMD ["dotnet", "run", "-p","DevOpsCI.Client/DevOpsCI.Client.csproj"]
