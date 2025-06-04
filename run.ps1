# Kill any leftover function host process
taskkill /f /im func.exe > $null 2>&1

# Clean up previous run artifacts
Remove-Item -Force -Recurse .\bin\Debug\net8.0\.azurefunctions -ErrorAction SilentlyContinue
Remove-Item -Force -Recurse .\obj\Debug\net8.0\WorkerExtensions -ErrorAction SilentlyContinue

# Start the function
func start --verbose