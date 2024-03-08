
[README](../README.md)
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
        endDate,
        technologies{
        	name
        }
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
