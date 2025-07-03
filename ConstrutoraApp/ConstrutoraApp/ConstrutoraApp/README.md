# ConstrutoraApp 🏗️

Sistema web ASP.NET Core MVC para gerenciamento de clientes, obras e funcionários de uma empresa de construção civil.

## Funcionalidades

- Cadastro de Clientes
- Cadastro de Funcionários
- Cadastro de Obras
- Edição, Visualização e Remoção de registros
- Interface com Bootstrap

## Tecnologias

- ASP.NET Core MVC
- Entity Framework Core (SQLite)
- Bootstrap 5
- Repository Pattern

## Como executar

```bash
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

## Autor

Pablo  
