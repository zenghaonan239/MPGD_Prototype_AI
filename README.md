# Prison Breaking

Project Description
-------------------

The theme of the game is prison escape, and the game type is a 3D horizontal action adventure game. The goal is to avoid the guards and successfully reach the prison gate.

Features
-------------------

The player controls the character through the keyboard to avoid the guard. The Space key is the jump key, and the A key and D key control the character to move to the left and right, respectively.

Deployment Steps
-------------------

You can download the entire game file from github and open it with Unity. It is recommended to use 2021.1.17f1 or newer versions of Unity to open the game file, or enter this webpage(https://zenghaonan239.github.io/MPGD_Prototype_AI/build/index.html) to preview the game directly.

Unity Environment Settings
-------------------

When opening the game file with Unity, pay attention to installing the Input System package.
* Add the Input System package:<br>
    (a)	Window → Package Manager.<br>
    (b)	Select ’Packages: Unity Registry’ in the top-left.<br>
    (c)	Search for ’Input System’.<br>
    (d)	Install (bottom-right; ’OK’ for warning) and restart Unity.<br>

In addition, in order to avoid the situation that the screen becomes dark when reloading the scene, please make the following settings.
* Lighting setting:<br>
    (a) Window→Rendering→Lighting<br>
    (b) Uncheck the Auto Generate in Scene<br>
    (c) Click the Generate Lighting button<br>

Please open the Tuturial Map scene file to run or test the game

Directory Structure Description
-------------------
The main content of the game is in the assets folder. The Input folder mainly stores the relevant component files controlled by the player. The Scenes folder mainly stores the relevant files of the game scene. The Material folder mainly Store the relevant materials of each element of the map, the Scripts folder mainly stores some script files. Our game prototype will run in the Tuturial Map scene, and the SampleScene will run as entry UI interface, you can choose tutorial, level 1 or level 2 in the UI interface. Map1 scene and Map2 scene will run as level 1 and level 2 respectively. 


External Reference
-------------------
Wall material, Door model: https://assetstore.unity.com/packages/3d/environments/stylized-hand-painted-dungeon-free-173934
Floor material: https://assetstore.unity.com/packages/3d/environments/dungeons/decrepit-dungeon-lite-33936
Character model: https://assetstore.unity.com/packages/3d/characters/humanoids/humans/adventure-character-201384
Character action: https://www.mixamo.com/#/?page=1&type=Motion%2CMotionPack
Background music: https://assetstore.unity.com/packages/audio/music/orchestral/music-the-chase-157802
Key 3D model: https://assetstore.unity.com/packages/3d/props/rust-key-167590
