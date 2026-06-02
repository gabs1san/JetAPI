# 🚀 JetAPI

Uma API REST desenvolvida em **ASP.NET Core** utilizando **Entity Framework Core** com o objetivo de revisar conceitos fundamentais de desenvolvimento backend, persistência de dados e arquitetura de APIs.

Este projeto também marcou minha primeira experiência utilizando o **JetBrains Rider** como ambiente de desenvolvimento para aplicações .NET.

---

## 📖 Sobre o Projeto

A JetAPI foi criada como um projeto de estudos para reforçar conhecimentos em:

* ASP.NET Core Web API
* Entity Framework Core
* CRUD completo
* Migrations
* Injeção de Dependência (Dependency Injection)
* Boas práticas de organização de código
* Integração com banco de dados
* Utilização do JetBrains Rider

O foco principal não foi a complexidade da regra de negócio, mas sim consolidar conceitos importantes do ecossistema .NET.

---

## 🛠️ Tecnologias Utilizadas

* C#
* ASP.NET Core
* Entity Framework Core
* SQL Server
* Swagger / OpenAPI
* JetBrains Rider

---

## 📂 Estrutura do Projeto

```text
JetAPI
├── Controllers
├── Models
├── Data
├── Migrations
└── Program.cs
```

*A estrutura pode variar conforme a evolução do projeto.*

---

## ⚙️ Funcionalidades

* Cadastro de registros
* Consulta de dados
* Atualização de informações
* Exclusão de registros
* Persistência utilizando Entity Framework Core
* Documentação automática via Swagger

---

## 🚀 Como Executar

### 1. Clone o repositório

```bash
git clone https://github.com/gabs1san/JetAPI.git
```

### 2. Acesse a pasta

```bash
cd JetAPI
```

### 3. Observação sobre a Connection String

Por se tratar de um projeto de estudos com foco na revisão de conceitos do Entity Framework Core, a Connection String foi configurada diretamente no `AppDbContext`.

Em projetos de produção, o recomendado é armazenar a Connection String no arquivo `appsettings.json` e injetá-la através da configuração da aplicação, facilitando a manutenção, a segurança e a separação de responsabilidades.

Exemplo:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("SuaConnectionString");
}
```

Este formato foi adotado apenas para simplificar a configuração durante os estudos e testes iniciais.

Exemplo em ambiente de produção: 
No arquivo appsettings.json, configure sua conexão com o banco:

"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=JetAPI;Trusted_Connection=True;"
}

### 4. Execute as Migrations

```bash
dotnet ef database update
```

### 5. Inicie a aplicação

```bash
dotnet run
```

ou

```bash
dotnet watch run
```

---

## 📚 Documentação da API

Após iniciar a aplicação, acesse:

```text
https://localhost:xxxx/swagger
```

A documentação interativa será disponibilizada através do Swagger.

---

## 🎯 Objetivo de Aprendizado

Este projeto foi desenvolvido para:

* Reforçar conceitos de APIs REST.
* Praticar Entity Framework Core.
* Aprender o fluxo de Migrations.
* Explorar o ambiente JetBrains Rider.
* Servir como base para projetos futuros mais robustos.

---

## 📈 Próximos Passos

Possíveis melhorias para versões futuras:

* Implementar Repository Pattern
* Adicionar camada de Services
* Utilizar DTOs
* Implementar autenticação com JWT
* Configurar tratamento global de exceções
* Mover a Connection String para o `appsettings.json`
* Adicionar testes unitários

---

## 👨‍💻 Autor

**Gabriel San Gregorio**

* GitHub: https://github.com/gabs1san
* LinkedIn: https://www.linkedin.com/in/gabriel-san-gregorio

---

⭐ Projeto desenvolvido para estudos, prática de conceitos do Entity Framework Core e evolução no ecossistema .NET.
