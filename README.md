# Be.HexEditor

This repository mirrors the source code of the [Be.HexEditor](http://sourceforge.net/projects/hexbox/) project created by Bernhard Elbl.

## Changes

_See the [CHANGELOG.txt](CHANGELOG.txt) for the full list of changes._

This repository also includes the following additions:

- Changes made by [Jaroslav Imrich](https://github.com/Pkcs11Admin/Be.HexEditor) for the NuGet package
- The ability to color regions in the hex view with a different background color as can be seen below
- Update to .NET8

![alt text](/Media/preview.png "Preview")

## Usage

```c#
HexView.HighlightedRegions.Add(new HighlightedRegion(0, 12, Color.Purple));
```

## NuGet Package

[Nuget package for HexBox](https://www.nuget.org/packages/be.windows.forms.hexbox.net8)

Versions for

- .NET Framework 4.6.2 and higher
- .NET 8.0 and higher

available


## License

This project is licensed under MIT, see the [LICENSE](LICENSE.txt) file for more details
