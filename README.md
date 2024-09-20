# IdentityTemplate

Complete Auth for ASP .NET 9 projects

* ASP Razor Pages / MVC scaffolded Identity
* Web Api with Auth
* Swagger with correct config
* Admin Area
* Sqlite
* EF Core. Remember you are free to use any other ORM or not ORM at all for other parts of your application.

## Databases
Identity core UI supports SQLServer, Sqlite, Postgres, and Cosmos.
To use one of these instead of Sqlite you can just run the .ps1 script provided and change the connection string, and overwrite the scaffolded Areas/Identity code.

This project has been setup so you don't need to run the powershell script. But if you want to create it with a different db you can do so.
It is run like this:
```
 .\setup-aspnet-identity-full.ps1 -ProjectName "IdentityTemplate" -DbProvider "sqlite"
```

## Notes
* I am going to make another version of this which uses Tailwind CSS instead of the default BootStrap 5.
