# Member

```
dotnet ef migrations add "InitialDatabase" --project .\src\Infrastructure\ --startup-project .\src\Member\ --output-dir Persistence\Migrations
```

```
dotnet ef migrations remove --project .\src\Infrastructure\ --startup-project .\src\Member\
```