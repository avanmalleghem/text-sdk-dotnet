set BUILD_DIR=%~dp0
set OUTPUT_DIR=%BUILD_DIR%..\Output\Nuget
set PROJECT_FILE=%BUILD_DIR%..\CM.Text\CM.Text.csproj

call %BUILD_DIR%NuGet.exe pack %PROJECT_FILE% -Prop Configuration=Release -OutputDirectory %OUTPUT_DIR% -IncludeReferencedProjects -build
