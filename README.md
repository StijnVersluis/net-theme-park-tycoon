# Codename: Theme Park Tycoon Game

*Except it's not really a game, but a simulator of a theme park.*



This is a text and menu-based game surrounding the management of a theme park. It allows you to buy rides and shops. Guests will want to go on these rides and buy from your stores. All based on random stats (with the guests) and stat boosts (from rides and consumption).



## Getting this running

In this checklist you can read how to get this solution running. Choosing to either use console commands, or just following the instructions in your own way.



1. Clone this repo to a folder by running

    `git clone https://github.com/timothywalter/net-theme-park-tycoon.git`

   (Or using your favourite Git Client)

2. Enter that folder

   `cd net-theme-park-tycoon`

3. Open the .sln file to open the solution

4. There are three different projects, described below...

5. Right-click the project you wish to start and "Set as StartUp project"

6. Press 'Start' or F5



## Solution Structure

The solution contains three projects and a `Resources` folder:

* Resources folder

  Contains all the images used in the application.

* ThemeParkTycoonGame.**Core** project

  Contains the core objects that make up the simulation. This contains no UI, no interfaces and should contain no direct messages to the end-user.

  This is kept separate from the UI/views in order to ensure maximum portability. Allowing compatibility with Desktop Apps to Mobile Apps

* ThemeParkTycoonGame.**Forms** project

  This is a basic example of the simulation. It is made in C# and is a .NET Framework 4.7 Windows Forms application.

  This provides an interface to the logic in the Core. All this project does is tie the logic together. 

* ThemeParkTycoonGame.**Fancy** project

  This is an example of the simulation in WPF. Also made in  C# and also .NET Framework 4.7 application.

  This project should become a prettier interface to the logic in Core. This project is similar to the Forms project, but will be able to look prettier thanks to WPF. Furthermore we can utilize Databinding to clean up our code a lot more. 

  *Besides looking better this project could provide some differences in gameplay as well. Many games that are cross-platform have platform unique items/features. We can do the same here.*

