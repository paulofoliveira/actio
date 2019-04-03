FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY ./bin/Docker .
ENV ASPNETCORE_URLS http://*:5051
ENV ASPNETCORE_ENVIRONMENT docker
#ENV ASPNETCORE_Kestrel__Certificates__Default__Password "crypticpassword" 
#ENV ASPNETCORE_Kestrel__Certificates__Default__Path /https/aspnetapp.pfx

ENTRYPOINT dotnet Actio.Services.Activities.dll