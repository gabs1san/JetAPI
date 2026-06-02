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
├── Services
├── Repositories
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

### 3. Configure a Connection String

No arquivo `appsettings.json`, configure sua conexão com o banco:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=JetAPI;Trusted_Connection=True;"
}
```

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

## 👨‍💻 Autor

Gabriel San Gregorio

⭐ Projeto desenvolvido para estudos e evolução na plataforma .NET.
