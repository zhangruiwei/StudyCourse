
FROM newbe36524/sdk:3.1 AS build-env
WORKDIR /code
EXPOSE 80

COPY *.csproj /code
RUN dotnet restore

COPY . /code
RUN dotnet publish -c Release -o out

FROM newbe36524/aspnet:3.1
WORKDIR /app
COPY --from=build-env /code/out /app
ENTRYPOINT ["dotnet","Warren.StudyCource.CustomerService.API.dll"]
