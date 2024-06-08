# How to use

```csharp
using Mammoth;

var result = new DocumentConverter().ConvertToHtml("./document.docx");
var html = result.Value;
var warnings = result.Warnings;
```

More infos:
- https://github.com/r-Larch/dotnet-mammoth-core/blob/master/README.md
