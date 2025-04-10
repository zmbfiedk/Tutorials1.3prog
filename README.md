# Tutorials 1-2

This project includes two key scripts for animating a player and handling basic movement. Below are the details on how to integrate and use the provided scripts.

## Files

1. **AnimatePlayer.cs**  
   [Link to AnimatePlayer.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/AnimatePlayer.cs)  
   This script is responsible for animating the player. It should be attached to your player object and will control the animation states based on the player's movement.

2. **MoveBasic.cs**  
   [Link to MoveBasic.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/MoveBasic.cs)  
   This script handles the basic movement controls for the player. It uses Unity's Input system to allow the player to move in a 2D or 3D environment.

## GIF Demonstration

![Player Movement & Animation](Gifs/ezgif-5ae935d205e1f7.gif)

# Tutorial 3

This project introduces a jump mechanic for the player. Below are the details on how to integrate and use the provided script.

## Files

1. **Jump.cs**  
   [Link to Jump.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/Jump.cs)  
   This script handles the player's jumping functionality. It should be attached to your player object and allows the player to jump when the jump input is triggered.

## GIF Demonstration

![Player Jumping](Gifs/ezgif-1f84b338ccf2df.gif)

# Tutorial 4

This project introduces the functionality to collect pickups and track the player's score. Below are the details on how to integrate and use the provided scripts.

## Files

1. **GetPickup.cs**  
   [Link to GetPickup.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/GetPickup.cs)  
   This script is responsible for detecting when the player collects a pickup. It adds to the player's score when a pickup is collected.

2. **KeepScore.cs**  
   [Link to KeepScore.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/KeepScore.cs)  
   This script tracks and displays the player's score. It works in conjunction with `GetPickup.cs` to keep a running total of the score.

## GIF Demonstration

![Player Collecting Pickup](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Gifs/ezgif-6b1aef1a2627ab.gif)

# Tutorial 5

This project introduces the functionality for shooting, killing on hit, and managing bullet movement. Below are the details on how to integrate and use the provided scripts.

## Files

1. **Kill on hit.cs**  
   [Link to Kill on hit.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/Kill%20on%20hit.cs)  
   This script is responsible for detecting when the player or enemy is hit by a bullet, and it handles the logic for killing the affected object.

2. **Shoot.cs**  
   [Link to Shoot.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/Shoot.cs)  
   This script controls the player's shooting mechanics, enabling the firing of bullets when the shoot input is triggered.

3. **MoveBullet.cs**  
   [Link to MoveBullet.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/MoveBullet.cs)  
   This script is responsible for the movement of the bullets, allowing them to travel across the screen after being fired.

4. **GetPickup.cs (Updated)**  
   [Link to GetPickup.cs Script](https://github.com/zmbfiedk/Tutorials1.3prog/blob/main/Assets/Scripts/GetPickup.cs)  
   This updated script handles the pickup collection logic and also integrates with the player's score, which increases as pickups are gathered.

## GIF Demonstration

![Player Shooting & Bullet Movement](Gifs/ezgif-8b9fcb279a4774.gif)


