# Graphql dotnet example
![workflow](https://github.com/bjras93/GraphQL.dotNET.Example/actions/workflows/dotnet.yml/badge.svg)

## Task
- Return an overall list of companies/projects/education/skills ✅
- Return details for the entries ✅

### Optional
- ORM (EF-Core) ✅
- git repository ✅
- Automated testing ✅
- Mutations ✅

## Introduction

- Project is created using vscode
- To run application type following
  - `dotnet run --project src/API`
  - [graphiql](http://localhost:5000/ui/graphiql)
- To run test
  - `dotnet test`
- Primary resources used to solve the assignment
  - https://graphql-dotnet.github.io/
  - https://graphql.org/learn/
  - https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
- Sqlite
  - Used as database

## Data model
![Data model](/documentation/datamodel.png)

# GraphQL
- [Queries](/documentation/Queries.md)
- [Mutations](/documentation/Mutations.md)