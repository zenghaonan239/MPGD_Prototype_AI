# Prison Breaking Customer

Project Description
-------------------

The theme of the game is prison escape, and the game type is a 3D horizontal action adventure game. The goal is to avoid the guards and successfully reach the prison gate.

Features
-------------------

The player controls the character through the keyboard to avoid the guard. The W key is the jump key, and the A key and D key control the character to move to the left and right, respectively.

Deployment steps
-------------------

You can download the entire game file from github and open it with Unity. It is recommended to use 2021.1.17f1 and newer versions of Unity to open the game file, or enter this webpage(https://zenghaonan239.github.io/MPGD_Prototype_AI/build/index.html) to preview the game directly.

Unity environment settings
-------------------

When opening the game file with Unity, pay attention to installing the Input System package.
* Add the Input System package:
    (a)	Window → Package Manager.
    (b)	Select ’Packages: Unity Registry’ in the top-left.
    (c)	Search for ’Input System’.
    (d)	Install (bottom-right; ’OK’ for warning) and restart Unity.

In addition, in order to avoid the situation that the screen becomes dark when reloading the scene, please make the following settings.
* Lighting setting:
    (a) Window→Rendering→Lighting
    (b) Uncheck the Auto Generate in Scene
    (c) Click the Generate Lighting button

Please open the Tuturial Map scene file to run or test the game

Directory structure description
-------------------
The main content of the game is in the assets folder. The Input folder mainly stores the relevant component files controlled by the player. The Scenes folder mainly stores the relevant files of the game scene. Our game prototype will run in the Tuturial Map scene, and the Material folder mainly Store the relevant materials of each element of the map, the Scripts folder mainly stores some script files