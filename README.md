<p align="center">
  <img src="https://i.imgur.com/iKoCsVH.png">
</p>


# Hero Stats

A simple website that displays 20 random heroe's and their information. 

The purpose of this site was to solidy the learning of:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) to learn another language and Object Oriented Programming principles
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) to utilize a framework that shares server-side and client-side logic in .NET
- [Bootstrap 5](https://getbootstrap.com/) for helping build responsive webpages
- API usage 

## Table of Contents
- [Hero Stats](#hero-stats)
  * [Table of Contents](#table-of-contents)
  * [Author](#author)
  * [Demo](#demo)
    + [Quick Links to Heroes](#quick-links-to-heroes)
    + [Homepage](#homepage)
    + [Hero Stats Page](#hero-stats-page)
  * [Tech Stack](#tech-stack)
  * [Lessons Learned](#lessons-learned)
    + [C\#](#c--)
    + [Blazor](#blazor)
    + [Bootstrap, HTML, CSS](#bootstrap--html--css)
    + [Source Control](#source-control)
  * [Run Locally](#run-locally)
  * [Acknowledgements](#acknowledgements)
## Author

[Gerardo Guerrero](https://www.linkedin.com/in/gerardo-guerrero2/)


## Demo

[Link to Homepage](https://hero-stats-durzo95.herokuapp.com/)

#### Quick Links to Heroes
- [Batman, Terry McGinnis](https://hero-stats-durzo95.herokuapp.com//hero/Batman)
- [Spider-Man](https://hero-stats-durzo95.herokuapp.com//hero/Spider%20Man)
- [Robin](https://hero-stats-durzo95.herokuapp.com//hero/Robin)

#### Homepage
![Homepage](https://github.com/Durzo95/SuperheroStats/blob/master/SuperheroStats/wwwroot/images/Homepage.png?raw=true)

#### Hero Stats Page
![Hero Page](https://github.com/Durzo95/SuperheroStats/blob/master/SuperheroStats/wwwroot/images/HeroPage.png?raw=true)
## Tech Stack

**Client:** [Bootstrap 5](https://getbootstrap.com/)

**Server:** [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)

**Languages:** [C#](https://getbootstrap.com/), HTML, CSS

**APIs:** [Super Hero Search](https://rapidapi.com/jakash1997/api/superhero-search/)


## Lessons Learned

### C\#
- [Object Oriented Programming](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)
- [Interfaces](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces)
- [Traversing JSON](https://stackoverflow.com/questions/22191167/convert-json-string-to-c-sharp-object-list) from API responses
- [Dependency Injection](https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/dependency-injection?view=aspnetcore-6.0)

### Blazor
- [Call APIs](https://docs.microsoft.com/en-us/aspnet/core/blazor/call-web-api?view=aspnetcore-6.0&pivots=server) for hero data
- [Razor pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/ui-class?view=aspnetcore-6.0&tabs=visual-studio) for Server Side Rendering
- [Services](https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/dependency-injection?view=aspnetcore-6.0)
- [SignalIR](https://dotnet.microsoft.com/en-us/apps/aspnet/signalr)
- [Components](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/components) to re-use HTML blocks of code with parameters
- [Code-Behind Files](https://darthpedro.net/2021/04/26/how-to-use-blazor-code-behind-file/)

### Bootstrap, HTML, CSS
- [Bootstrap Grid System](https://getbootstrap.com/docs/5.2/layout/grid/)
- [Responsive Design](https://getbootstrap.com/docs/5.2/extend/approach/) with Bootstrap
- [Card Grids](https://getbootstrap.com/docs/5.0/components/card/#grid-cards) to display the hero cards
- [Pill Badges](https://getbootstrap.com/docs/5.2/components/badge/#pill-badges) to display hero affiliations
- [Text on Images](https://css-tricks.com/design-considerations-text-images/) with better readability
- [Image Effects on Hover](https://w3bits.com/css-image-hover-zoom/) for the hero images on the homepage

### Source Control
- [Github CI/CD](https://resources.github.com/ci-cd/)
- [Branches](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-branches)
## Run Locally

Clone the project

```bash
  git clone https://github.com/Durzo95/SuperheroStats
```

Go to the project directory

```bash
  cd SuperheroStats
```

Start the server

```bash
  dotnet run --project SuperheroStats
```


## Acknowledgements
 - [Superhero icons created by Freepik - Flaticon](https://www.flaticon.com/free-icons/superhero)
 - [How to write a Good readme](https://bulldogjob.com/news/449-how-to-write-a-good-readme-for-your-github-project)
 - [Table of contents generated with markdown-toc](https://ecotrust-canada.github.io/markdown-toc/)
