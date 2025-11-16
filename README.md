#  Increase Test Coverage — Assignment

This repository contains the .NET solution for the **Increase Test Coverage** assignment.

---

## Requirements Completed

### **Project Setup**
- Created a new solution  
- Added:
  - `AtmServices` class library  
  - `AtmServices.Test` xUnit test project  
- Renamed and implemented `Atm.cs`

### **Unit Testing**
Implemented tests for the **ATM service**, covering:

- `withdraw`  
  - success case  
  - failure case (insufficient balance)  
- `deposit`  
  - success case  
  - failure case (negative amount)  
- `getBalance`  
  - correct current balance  

### **Additional Requirements**
- Demonstrated a failing test, then fixed it  
- Added `.gitignore` and versioned the project  
- Installed Coverlet for coverage  
- Ran coverage report  
- Reached **100% coverage** in:
  - Line  
  - Branch  
  - Method  

### **Visualization**
Used **Coverage Gutters** extension in Codespaces to visualize coverage (all lines green).

---

## Commands Used

```bash
dotnet new sln -n hello-testing
dotnet new classlib -o AtmServices
dotnet new xunit -o AtmServices.Test
dotnet add AtmServices.Test/AtmServices.Test.csproj reference AtmServices/AtmServices.csproj
dotnet sln add AtmServices.Test/AtmServices.Test.csproj
dotnet test
dotnet new gitignore
dotnet add package coverlet.msbuild
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Threshold=90
