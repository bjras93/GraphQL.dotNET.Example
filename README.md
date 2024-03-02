# MindworkingTest

## Introduction

- Project is created using vscode
- To run application type following
  - `dotnet run --project src/API`
  - [graphiql](http://localhost:5000/ui/graphiql)
- Primary resources used to solve the assignment
  - https://graphql-dotnet.github.io/
  - https://graphql.org/learn/
  - https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
- Sqlite
  - Used as database

## Data model
![Data model](/documentation/datamodel.png)

## Queries

### Curriculum Vitarum
```graphql
query {
  curriculumVitarum {
    curriculumVitae {
      projects{
        title,
        description,
        startDate,
        endDate
      },
      skills {
        name
        proficiencyLevel
        experienceYears
      },
      companies{
        name,
        startDate,
        endDate
      }
      educations{
        name,
        fieldOfStudy,
        startDate,
        endDate
      }
    }
  }
}
```

### Companies

**Multiple**
```graphql
query
{
  companies{
    companies{
      id,
      name,
      startDate,
      endDate
    }
  }
}
```

**Single**
```graphql
query
{
  companies{
    company(id: 1){
      id,
      name,
      startDate,
      endDate
    }
  }
}
```

### Technologies

**Multiple**

```graphql
query
{
  technologies{
    technologies{
      id,
      name
    }
  }
}
```

**Single**

```graphql
query
{
  technologies{
    technology(id: 1){
      id,
      name
    }
  }
}
```

### Projects
```graphql
query
{
  projects{
    projects{
      id,
      title,
      description,
      startDate,
      endDate
    }
  }
}
```
### Educations

```graphql
query
{
  educations{
    educations{
      id,
      name,
      startDate,
      endDate
    }
  }
}
```

## Mutations


### Create education
```graphql
mutation {
  educations {
    createEducation(education: {name: "Test", fieldOfStudy: "IT", startDate: "2014-09-01T00:00:00Z", endDate: "2016-09-01T00:00:00Z"}) {
      id
      name,
      fieldOfStudy,
      startDate,
      endDate
    }
  }
}
```
### Create technology
```graphql
mutation {
  technologies{
    createTechnology(technology: { name: "C++"})
    {
      id,
      name
    }
  }
}
```


### Create skill
Replace `{REFERENCE_ID}` with created technology id

```graphql
mutation {
  skills {
    createSkill(skill: {proficiencyLevel: EXPERT, experienceYears: 8, referenceId: {REFERENCE_ID}, referenceType: TECHNOLOGY}) {
      proficiencyLevel
    }
  }
}
```
### Create company

```graphql
mutation {
  companies{
    createCompany(company: { name: "Test", startDate: "2024-03-02T00:00:00+00:00"})
    {
      id,
      name
      startDate,
      endDate
    }
  }
}
```

### Create project
```graphql
mutation {
  projects{
    createProject(project: { title: "Test", description: "Test description", startDate: "2024-03-02T00:00:00+00:00"})
    {
      id,
      title
      description,
      startDate,
      endDate
    }
  }
}
```