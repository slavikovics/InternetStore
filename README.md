# How to run tests with code coverage results using coverlet:
```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info
```
# How to generate code coverage report:
```bash
dotnet reportgenerator -reports:./InternetStoreTest/lcov.info -targetdir:.coverage
```