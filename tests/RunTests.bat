del intermediate.json

dotnet test CoverletTests.BarTests\CoverletTests.BarTests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,cobertura\" /p:CoverletIntermediateResult=\"../intermediate.json\" /p:Exclude=\"[NUnit3.TestAdapter]*,[*Tests]*\"
dotnet test CoverletTests.FooTests\CoverletTests.FooTests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,cobertura\" /p:CoverletIntermediateResult=\"../intermediate.json\" /p:Exclude=\"[NUnit3.TestAdapter]*,[*Tests]*\"
