<!-- https://github.com/quagma-software/fsharp-ga -->

<br />
<div align="center">
  <h3 align="center">Geometric Algebra for F♯</h3>

  <p align="center">
    Basic library to manipulate multivectors
    of geometric algebra
  </p>

  <img src=".logo.svg" width="360" height="360" />
</div>


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#the-project">The Project</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>


<!-- THE PROJECT -->
## The Project

Work in progress...

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

No NPM available right now...

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/quagma-software/fsharp-ga.git
   ```
2. Open with Visual Studio 2022
   ```text
   FSharpGA.sln
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- USAGE EXAMPLES -->
## Usage

Modules to be included:
```fsharp
open tech.quagma.ꗃⳆutils.ꕺⳆuseFSharp
open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ
open tech.quagma.ꗃⳆmaths.ꗃⳆgeometry.ꕺⳆuseꓽᎶꓹ2ꓹ0
```

Inside an async block:
```fsharp
async {
    let! ᑉuᐣ= withꓽᎶꓹ2ꓹ0<unit> {
        ᐅ (``ᑉᎶ꘎ᐣꓹλꓸ`` <| Ꭱᘁ 50.0)
        ᐅ (``ᑉᎶ꘎ᐣꓹλ₁`` <| Ꭱᘁ 50.0)
        ᐅ (``ᑉᎶ꘎ᐣꓹλ₂`` <| Ꭱᘁ 50.0)
        ᐃ (``ᑉᎶ꘎ᐣꓹλ₁₂`` <| Ꭱᘁ 50.0)

        ᐅ (``ᑉᎶ꘎ᐣꓹλꓸ`` <| Ꭱᔥ 100.0)
        ᐅ (``ᑉᎶ꘎ᐣꓹλ₁`` <| Ꭱᔥ 100.0)
        ᐅ (``ᑉᎶ꘎ᐣꓹλ₂`` <| Ꭱᔥ 100.0)
        ꕕ (``ᑉᎶ꘎ᐣꓹλ₁₂`` <| Ꭱᔥ 100.0)

        ᐁ ()
    }

    // do something with ᑉuᐣ
}
```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTACT -->
## Contact

Qᴜᴀԍᴍᴀ® Sᴏғᴛᴡᴀʀᴇ<br/>
software@quagma.net

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo_name.svg?style=for-the-badge
[contributors-url]: https://github.com/github_username/repo_name/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo_name.svg?style=for-the-badge
[forks-url]: https://github.com/github_username/repo_name/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo_name.svg?style=for-the-badge
[stars-url]: https://github.com/github_username/repo_name/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo_name.svg?style=for-the-badge
[issues-url]: https://github.com/github_username/repo_name/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo_name.svg?style=for-the-badge
[license-url]: https://github.com/github_username/repo_name/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 