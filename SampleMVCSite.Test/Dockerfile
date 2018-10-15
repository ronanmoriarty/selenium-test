FROM microsoft/dotnet:2.1-sdk-alpine3.7
WORKDIR /app
COPY ./SampleMVCSite.Test/SampleMVCSite.Test.csproj ./SampleMVCSite.Test/
RUN dotnet restore ./SampleMVCSite.Test
COPY ./SampleMVCSite.Test ./SampleMVCSite.Test
RUN dotnet build ./SampleMVCSite.Test/SampleMVCSite.Test.csproj
