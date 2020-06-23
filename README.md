<!--
*** Markdown "reference style" links used for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->


<!-- PROJECT SHIELDS -->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />
 <h3 align="center">Simple app to demonstrate Hierarchy Navigation</h3>

  <p align="center">    
    <a href="https://github.com/BrettFlavin/Hierarchy-Navigation-example/issues">Report Bug</a>
    ·
    <a href="https://github.com/BrettFlavin/Hierarchy-Navigation-example/issues">Request Feature</a>
  </p>
  
<p align="center">
  <a href="https://github.com/BrettFlavin/Hierarchy-Navigation-example">
    <img src="https://github.com/BrettFlavin/Hierarchy-Navigation-example/blob/master/screenshot.gif" alt="screenshot">
  </a> 
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
* [Built With](#built-with)
* [Usage](#usage)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project

I'm a big fan of fishkeeping and African Cichlids, so I decided to make an educational little app using Xamarin.Forms to learn a bit about hierarchy navigation and also show off some cool fish! The fish pictured in this app live in a 7 foot 200g tank in my living room.

This app demonstrates hierarchy navigation in Xamarin.Forms by using a root page with a short description of Lake Malawi in Africa and 3 buttons for "Facts", Lake Pics", and "Fish Pics". We use the PushAsync() and PopAsync() methods to "push" and "pop" the pages from the navigation stack. The PopToRootAsync() method is used when the home page button is clicked to pop all but the root page off the stack. 
* Clicking on the "Facts" button will display a random fact about Lake Malawi when the button is clicked
* Clicking on the "Lake Pics" button will display a list of Lake Malawi pictures which can be clicked on for more details 
* Clicking on the "Fish Pics" Button will display a list of lake Malawi fish pictures which can be clicked on for more details



<!-- BUILT WITH -->
### Built With

This application was created in Visual Studio 2019 using Xamarin.Forms to target both iOS and Android mobile platforms. XAML is used for the UI and display, and C# for the code behind logic.

* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
* [Xamarin.Forms](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [XAML](https://docs.microsoft.com/en-us/dotnet/desktop-wpf/fundamentals/xaml)



<!-- USAGE EXAMPLES -->
## Usage

Here are some example screenshots of the application running on an Android device:

![screenshot1](https://github.com/BrettFlavin/Hierarchy-Navigation-example/blob/master/screenshot1.PNG)    ![screenshot2](https://github.com/BrettFlavin/Hierarchy-Navigation-example/blob/master/screenshot2.PNG)



![screenshot3](https://github.com/BrettFlavin/Hierarchy-Navigation-example/blob/master/screenshot3.PNG) {: style="float:left"}    ![screenshot4](https://github.com/BrettFlavin/Hierarchy-Navigation-example/blob/master/screenshot4.PNG) {: style="float:right"} 



![screenshot5](https://github.com/BrettFlavin/Hierarchy-Navigation-example/blob/master/screenshot5.PNG)    ![screenshot6](https://github.com/BrettFlavin/Hierarchy-Navigation-example/blob/master/screenshot6.PNG)



<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/BrettFlavin/Hierarchy-Navigation-example/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions make the open source community an amazing place to learn, be inspired, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Adding some feature that is amazing!'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Author:
<br />
Brett R. Flavin - brettflavin@yahoo.com

Project Link: [https://github.com/BrettFlavin/Hierarchy-Navigation-example](https://github.com/BrettFlavin/Hierarchy-Navigation-example)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Frida Lau - background image](https://unsplash.com/photos/0TLnj5q2oKA)
* [othneildrew - readme template](https://github.com/othneildrew/Best-README-Template)



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/BrettFlavin/Hierarchy-Navigation-example?style=plastic
[contributors-url]: https://github.com/BrettFlavin/Hierarchy-Navigation-example/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/BrettFlavin/Hierarchy-Navigation-example?style=plastic
[forks-url]: https://github.com/BrettFlavin/Hierarchy-Navigation-example/network/members
[stars-shield]: https://img.shields.io/github/stars/BrettFlavin/Hierarchy-Navigation-example?style=plastic
[stars-url]: https://github.com/BrettFlavin/Hierarchy-Navigation-example/stargazers
[issues-shield]: https://img.shields.io/github/issues/BrettFlavin/Hierarchy-Navigation-example?style=plastic
[issues-url]: https://github.com/BrettFlavin/Hierarchy-Navigation-example/issues
[license-shield]: https://img.shields.io/github/license/BrettFlavin/Hierarchy-Navigation-example.svg?style=plastic
[license-url]: https://github.com/BrettFlavin/Hierarchy-Navigation-example/LICENSE.txt
