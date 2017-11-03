FROM microsoft/dotnet:2.0.0-sdk-2.0.2-jessie

WORKDIR /app
COPY . .

ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_URLS=http://*:5000
ENV ASPNETCORE_ENVIRONMENT=Development

EXPOSE 5000

#RUN [ "dotnet", "restore" ]
#ENTRYPOINT [ "dotnet", "watch", "run" ]

ENTRYPOINT dotnet restore && dotnet watch run