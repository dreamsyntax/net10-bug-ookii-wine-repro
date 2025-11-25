Simple WPF C# app to demonstrate a bug with .NET 10 Desktop Runtime apps running on Wine 10.19 (staging, dev and stable all tested on Debian Trixie as of 2025-11-24)

This was made to easily reproduce the bug for wine developers.

* Use branch NET10 for bugged version (built with NET10)
* Use branch NET9 for version that works with Wine (built with NET 9)

Build with:

`dotnet publish -c Release -r win-x64 --self-contained false /p:PublishReadyToRun=true`


See releases page for pre-built NET10 and NET9 versions.