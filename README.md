# increase-test-coverage

 Increase Test Coverage — Assignment
This repository contains the .NET solution for the Increase Test Coverage assignment.

Requirements Completed
Created a solution with:
AtmServices class library
AtmServices.Test xUnit test project
Implemented tests for:
withdraw (success + failure)
deposit (success + failure)
getBalance
Fixed failing test as required
Added .gitignore
Versioned and pushed the project to GitHub
Added Coverlet for test coverage
Successfully achieved 100% line, branch, and method coverage
Verified using Coverage Gutters in Codespaces

Commands Used
dotnet new sln -n hello-testing
dotnet new classlib -o AtmServices
dotnet new xunit -o AtmServices.Test
dotnet add AtmServices.Test/AtmServices.Test.csproj reference AtmServices/AtmServices.csproj
dotnet sln add AtmServices.Test/AtmServices.Test.csproj
dotnet test
dotnet new gitignore
dotnet add package coverlet.msbuild
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Threshold=90

Coverage
All metrics reached 100%:
Line: 100%
Branch: 100%
Method: 100%