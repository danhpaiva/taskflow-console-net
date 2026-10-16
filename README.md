# 📋 TaskFlow CLI — Gerenciador de Tarefas

[![.NET Core](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![xUnit](https://img.shields.io/badge/Tests-xUnit-blue?logo=nuget)](https://xunit.net/)
[![Conventional Commits](https://img.shields.io/badge/Conventional%20Commits-1.0.0-yellow.svg)](https://conventionalcommits.org)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/danhpaiva/taskflow-console-net/blob/main/LICENSE)

> Aplicação Console desenvolvida em **C# / .NET 10** para gerenciamento de tarefas (To-Do List), aplicando conceitos de Domain-Driven Design (DDD) simplificado, validações defensivas, testes unitários automatizados com **xUnit** e padronização de commits semânticos com **Conventional Commits**.

---

## 📌 Sumário
- [📋 TaskFlow CLI — Gerenciador de Tarefas](#-taskflow-cli--gerenciador-de-tarefas)
  - [📌 Sumário](#-sumário)
  - [🎯 Sobre o Projeto](#-sobre-o-projeto)
  - [🏗️ Arquitetura e Estrutura de Namespaces](#️-arquitetura-e-estrutura-de-namespaces)
  - [⚙️ Pré-requisitos](#️-pré-requisitos)
  - [🚀 Como Executar o Projeto](#-como-executar-o-projeto)
  - [📋 Testes Mapeados (TaskManagerTests):](#-testes-mapeados-taskmanagertests)
  - [🏷️ Padrão de Commits (Conventional Commits)](#️-padrão-de-commits-conventional-commits)
  - [📄 Licença](#-licença)

---

## 🎯 Sobre o Projeto

O **TaskFlow** foi desenvolvido como atividade prática para a disciplina de **Gestão e Qualidade de Software**. O projeto demonstra:
- **Separação em Camadas e Namespaces:** Organização clara entre entidades de domínio (`Domain`) e serviços da aplicação (`Service`).
- **Garantia de Qualidade:** Cobertura de testes unitários com **xUnit** para cenários de sucesso e lançamento de exceções.
- **Rastreabilidade:** Histórico de commits totalmente padronizado no GitHub.

---

## 🏗️ Arquitetura e Estrutura de Namespaces

A solução está organizada com namespaces bem definidos para refletir as responsabilidades de cada classe:

```text
taskflow-console-net/
├── TaskFlow.sln
├── TaskFlow.Console/
│   ├── Domain/
│   │   └── TaskItem.cs           # Namespace: TaskFlow.Console.Domain
│   ├── Service/
│   │   └── TaskManager.cs        # Namespace: TaskFlow.Console.Service
│   ├── Program.cs                # Ponto de entrada do console
│   └── TaskFlow.Console.csproj
└── TaskFlow.Tests/
    ├── Tests/
    │   └── Service/
    │       └── TaskManagerTests.cs # Namespace: TaskFlow.Tests.Tests.Service
    └── TaskFlow.Tests.csproj
```

## ⚙️ Pré-requisitos
Para executar este projeto localmente, você precisará de:

.NET 10 SDK instalado.

Git para clonar o repositório.

## 🚀 Como Executar o Projeto
Clone o repositório:

~~~
git clone [https://github.com/danhpaiva/taskflow-console-net.git](https://github.com/danhpaiva/taskflow-console-net.git)
cd taskflow-console-net
~~~
Restaure as dependências:

~~~
dotnet restore
~~~

Compile a solução:

~~~
dotnet build
~~~

Execute o projeto Console:

~~~
dotnet run --project TaskFlow.Console/TaskFlow.Console.csproj
~~~

🧪 Executando os Testes Unitários
Para rodar a suíte completa de testes desenvolvida com o xUnit:

~~~
dotnet test
~~~

## 📋 Testes Mapeados (TaskManagerTests):
AddTask_Should_Add_Task_When_Title_Is_Valid: Garante a adição correta de novas tarefas com título válido.

AddTask_Should_Throw_Exception_When_Title_Is_Empty: Valida se o sistema lança ArgumentException ao tentar criar tarefa com título em branco ou nulo.

GetById_Should_Return_Null_When_Task_Does_Not_Exist: Confirma o retorno null na busca por um ID inexistente.

## 🏷️ Padrão de Commits (Conventional Commits)
Os commits no repositório seguem rigorosamente a especificação do Conventional Commits:

feat(domain): Alterações e regras na entidade TaskItem.

feat(service): Lógicas e métodos do TaskManager.

test(service): Suítes de testes unitários em TaskManagerTests.

chore(sln): Ajustes de solução, dependências ou referências.

docs(readme): Atualizações na documentação do projeto.

## 📄 Licença
Este projeto está licenciado sob a MIT License - consulte o arquivo LICENSE para mais detalhes.

Copyright (c) 2026 Daniel Paiva