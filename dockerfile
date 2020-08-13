FROM mcr.microsoft.com/dotnet/core/sdk as build
WORKDIR /app
COPY . .
#ENV ASPNETCORE_URLS='http://*:5000'
RUN dotnet publish -c Release -o out DevOpsCI.Client/DevOpsCI.Client.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet 
WORKDIR /dist
COPY --from=build /app/out .
CMD ["dotnet", "DevOpsCI.Client.dll"]
