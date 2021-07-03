# Flappy_Bird_Game-MVC_DESIGN
## Aim Of Project

Creating Flappy Bird 2D game clone using MVC pattern.

![Flappy Bird Game](https://shiftdelete.net/wp-content/uploads/2021/04/flappy-bird-macos-ile-geri-dondu-2.jpg)


***What is MVC Design? (Model- View- Controller Design Pattern)***
<br/>
You can check from [this site](https://www.toptal.com/unity-unity3d/unity-with-mvc-how-to-level-up-your-game-development)
<br/>

***Model*** -> Class represents data of our objects.
<br/>Example: Player Inventory, Entire Level
<br/>Note: Should not inherit from Monobehaviour
<br/>Our Game: Force Jump for bird, slide speed of our obstacles from right to left, UI can be hold from Model too

***View*** -> All interactions that will occur in our game scene must be detected by the view and transferred to the controller.
<br/>Example: Click in the game and make the bird jump, detection of collisions, earning points or collecting gold on every pass
<br/>Note: They should be told to the controller that they are detected.

***Controller*** -> The controller should provide the link between the view and the model.
<br/> The code part of the interactions detected in the View section is written here.
<br/> Logic and operation parts are located here.
<br/> GameManager is generally used with singleton pattern.

![MVC Hierarchy](https://uploads.toptal.io/blog/image/91486/toptal-blog-image-1438268968391.2-56f489174107c172be051385f7d274e8.jpg)
