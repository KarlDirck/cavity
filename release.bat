MSBUILD build.xml /p:Versioning=Subversion /p:TargetFrameworkVersion=v4.0 /p:Configuration=Release
MSBUILD bundle.xml /p:Versioning=Subversion /p:TargetFrameworkVersion=v4.0 /p:Configuration=Release
PAUSE
MSBUILD build.xml /p:Versioning=Subversion /p:TargetFrameworkVersion=v3.5 /p:Configuration=Release
MSBUILD bundle.xml /p:Versioning=Subversion /p:TargetFrameworkVersion=v3.5 /p:Configuration=Release
PAUSE
MSBUILD build.xml /p:Versioning=Subversion /p:TargetFrameworkVersion=v2.0 /p:Configuration=Release
MSBUILD bundle.xml /p:Versioning=Subversion /p:TargetFrameworkVersion=v2.0 /p:Configuration=Release
