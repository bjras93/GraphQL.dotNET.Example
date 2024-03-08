[README](../README.md)
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
- Replace `{PROJECT_ID}` with created project id
- Replace `{REFERENCE_ID}` with created technology id
```graphql
mutation {
  projects {
    addProjectTechnology(projectTechnology: {technologyId: {REFERENCE_ID}, projectId: {PROJECT_ID}}) {
      id
    }
  }
}
```