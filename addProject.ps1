param (
    [string]$DirectoryPath = (Get-Location).Path, # Default to current directory
    [string]$SlnFileName = ""
)

# Ensure the specified directory exists
if (!(Test-Path -Path $DirectoryPath)) {
    Write-Error "The specified directory does not exist: $DirectoryPath"
    exit 1
}

# Get the solution file in the directory (default to first one found if none is provided)
if ([string]::IsNullOrWhiteSpace($SlnFileName)) {
    $SlnFile = Get-ChildItem -Path $DirectoryPath -Filter "*.sln" | Select-Object -First 1
    if (-not $SlnFile) {
        Write-Error "No .sln file found in the specified directory."
        exit 1
    }
    $SlnFilePath = $SlnFile.FullName
} else {
    $SlnFilePath = Join-Path -Path $DirectoryPath -ChildPath $SlnFileName
    if (!(Test-Path -Path $SlnFilePath)) {
        Write-Error "The specified .sln file does not exist: $SlnFilePath"
        exit 1
    }
}

Write-Host "Using solution file: $SlnFilePath"

# Find all .csproj files recursively in the directory
$CsProjFiles = Get-ChildItem -Path $DirectoryPath -Recurse -Filter "*.csproj"
if ($CsProjFiles.Count -eq 0) {
    Write-Warning "No .csproj files found in the directory: $DirectoryPath"
    exit 0
}

# Add each .csproj file to the solution
foreach ($CsProjFile in $CsProjFiles) {
    Write-Host "Adding project: $($CsProjFile.FullName)"
    & dotnet sln "$SlnFilePath" add "$($CsProjFile.FullName)"
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Failed to add project: $($CsProjFile.FullName)"
    }
}

Write-Host "All projects have been added to the solution."