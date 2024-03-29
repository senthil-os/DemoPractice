Files-Folder structure
-----------------------------------------------------------------------
Project Solution: AutoDriving\AutoDriving.sln
Project1:AutoDriving\AutoDriving\AutoDriving.csproj
   --Direction(Folder)
            --IVehicleMovement.cs
            --VehicleMovement.cs
   --Util(Folder)
          --Direction.cs(enum)
          --Movement.cs(enum)
          --Util.cs
   --Program.cs
Project2:AutoDriving\AutoDrivingTest\AutoDrivingTest.csproj
  --UtilTest.cs
  --VehicleMovementTest.cs
----------------------------------------------------------------------------
# Auto Driving Car Simulation
## Part 1
You're working on a brand new auto driving car to compete against Tesla. You've already gotten the prototype car working but rather primitively.

You're testing your prototype on a large rectangular field, with coordinates denoting the position on that field. Based on the coordinates, 
bottom left position is denoted (0, 0), and top right position is denoted (width, height). 

At this moment, it can only follow these commands:
- L: rotates the car by 90 degrees to the left
- R: rotates the car by 90 degrees to the right
- F: moves forward by 1 grid point

At the same time, the car has a facing direction, which follows usual map convention. So for a car at position (1,2) facing North,
 and moves forward by 1 grid point, it'll end up at (1, 3), still facing North.

## Sample Input
Your sample input consists 3 lines. The fist line indicates the width and height of the field. The second line indicates 
the current position and facing direction of the car. The last line shows the subsequent commands it will execute. For example
```
10 10
1 2 N
FFRFFFRRLF
```
To intepret the input above: the field 10 by 10 in size, hence upper right coordinate is (9,9). The car is at position (1,2) facing North, 
and executes these steps `FFRFFFRRLF` sequentially. So where would the car end up? What direction will it facing?

If the car tries to go out of the boundary, that command is ignored. E.g. For a car at (0,0) facing South, when it receives a F 
command to move forward, the command is ignored, as else the car will move outside of the boundary.

## Sample Output
Based on the sample input above, the output would be:
```
4 3 S
```
