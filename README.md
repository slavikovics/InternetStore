# How to run tests with code coverage results using coverlet:
```shell
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info
```
# How to generate code coverage report:
```shell
dotnet reportgenerator -reports:./InternetStoreTest/lcov.info -targetdir:.coverage
```
# How to set up local database
```shell
dotnet tool install --global dotnet-ef
```
```shell
dotnet ef migrations add "Migration name"
```
```shell
dotnet ef database update
```
Connection string is written in Program.cs