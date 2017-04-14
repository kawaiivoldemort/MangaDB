FROM microsoft/dotnet:latest
WORKDIR /app
COPY . /app
RUN dotnet restore
EXPOSE 5000
ENTRYPOINT ["dotnet", "run"]