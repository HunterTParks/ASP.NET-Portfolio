# Portfolio By Hunter Parks

### Description
This Web Application is my portfolio which depicts my 3 most starred repo's on Github. This App utilizes the ASP.NET Framework running in C# and utilizes *_Materialize_* and *_jQuery_* as front end frameworks and basic Javascript.

***

### Tutorial
* [Clone the Repository](https://github.com/HunterTParks/ASP.NET-Portfolio)
* Create a new file in *_src\ASP.NET-Portfolio\Models\_* called 'EnvironmentalVariables.cs'
* Inside EnvironmentalVariables.cs, Copy the following into your file...
```csharp
namespace ASP.NET_Portfolio.Models
{
    public class EnvironmentalVariables
    {
        public static string AccessToken = "HunterTParks";
        public static string AuthToken = "xxxxxxxx"; //Replace 'xxxxxxxx' with your Client_Id
        public static string AuthSecret = "xxxxxxxx"; //Replace 'xxxxxxxx' with your Client_secret
    }
}
```
* Once completed, Open Terminal / Powershell / Mono / Git Bash and navigate to the *_ASP.NET-Portfolio_* folder and run the following commands...
```console
$ dotnet build
$ dotnet run
```

***

### Known bugs
* Materialize Not being able to display background picture

***
### Support
If you would like to report a bug, please email me at hunter.thomas.parks@gmail.com

I will also respond and merge any pull requests I am sent if they are necessary

***

### Copyright
Copyright 2017 Hunter Parks

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
