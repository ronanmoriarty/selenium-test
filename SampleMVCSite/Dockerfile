FROM microsoft/dotnet:2.1-sdk-alpine3.7
WORKDIR /app
COPY ./SampleMVCSite.csproj .
RUN dotnet restore ./
COPY . .
RUN dotnet build ./SampleMVCSite.csproj
EXPOSE 5808

CMD dotnet run ./bin/Release/netcoreapp2.1/SampleMVCSite.dll