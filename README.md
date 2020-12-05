# CSharpStaderLander
Skapa objekt från JSON med Json.NET
Om man vill använda JSON-filer i .NET kan man använda paketet Newtonsoft.Json Json.NET.
Här är ett litet exempel på hur det går till att läsa in data (Deserialization).

## Lägg till nugetpaketet Newtonsoft.Json
För att använda Json.NET behöver man lägga till nugetpaketet Newtonsoft.Json.
Från dotnet CLI i den mappen där .csproj filen ligger:
```
❯ dotnet add package Newtonsoft.Json
```
Då läggs detta till i .csproj:
```
<ItemGroup>
  <PackageReference Include="Newtonsoft.Json" Version="12.0.3" />
</ItemGroup>
```

## Skapa klasser som stämmer överens med den JSON du vill använda
Exempel hur klassen för länder ser ut:
```
class Country
{
  public int Id { get; set; }
  public string Countryname { get; set; }
}
```
För att stämma med land.json:
```
[
	{
		"id": 1,
		"countryname": "Sverige"
	},
	{
		"id": 2,
		"countryname": "Finland"
	},
	{
		"id": 3,
		"countryname": "Norge"
	}
]
```
Nu kan man skapa en lista med alla objekt som finns i JSON filen:
```
List<Country> countryList = JsonConvert.DeserializeObject<List<Country>>(countryJson);
```
## Vidare läsning
Json.NET innehåller en mängd andra funktioner.
För en djupdykning finns dokumentationen här: https://www.newtonsoft.com/json/help/html/Introduction.htm

En guide från Microsoft om Nuget Packages med just Newtonsoft.Json som exempel.: https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-using-the-dotnet-cli
