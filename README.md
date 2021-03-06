# studiolynn
Unity Simulation Workshop  
Die Angewandte - IoA Studio Lynn  
Winter 2019  

## 01 Agent Patrol
Use the NavMesh component in Unity, to produce a certain amount of humanoid agents that can navigate in a designated map (composed by 3D geometries) and avoid obstacles. 

### 1.1 Static Obstacle
Create a single plane and few cubes as obstacle geometry, in "static," set geometries as "Navigation Static." In the "Navigation" panel, next to "Inspector," bake the NavMesh map. NavMesh map needs to be baked everytime after there's a change to the geometries (scale, rotation or position).  

Create a 3D object, capsule, as an abstracted model of humanoid agent. In the "Inspector" panel, click "Add Component" and type in "Nav Mesh Agent," adjust the speed and acceleration to control the movement of agent. Drag and drop *Patrol* script to the inspector of the agent, to apply the patrol behavior. Use cube or sphere as waypoint geometries. 

### 1.2 Moving Obstacle
Change one of the geometries from NavMesh to a moving obstacle. Change the static to "Nothing" and add "Nav Mesh Obstacle" for the moving geometry, click the "Carve" to make sure that the obstacle can be recognized by the NavMesh map. Unfortunately the "Nav Mesh Obstacle" will be simplified as primitive shapes, either box or capsule, if you want to apply on a complicated geometry, you will need to add "Nav Mesh Obstacle" on individual Gameobjects and assign movement to the parent layer. For the movement of the geometry, there is a *Rotate* script ready. 

In this scene, agent should be duplicated to test with crowd behavior.

### 1.3 Geofencing
A geo-fence is a virtual perimeter for a real-world geographic area. The concept can be used as a way to divide different flow into zones or areas. There are two examples of geofencing in the scene 1.3.

Left: Use obstacles as a way to make agents moving along the wall.

Right: Create Nav Mesh map using different kinds of area, then assign different agents with different "Area Mask."

## 02 Customized Robot

### 2.1 Example: Forklift
Download and import the Prefeb "Forklift" in the Unity Scene. Run the forklift with keyboard control.
https://assetstore.unity.com/packages/3d/vehicles/controllable-forklift-free-80275

### 2.2 Autonomous Vehicle
In the scene 2.2, there are four ways of moving wheel-based agents autonomously without keyborad control. Note for different kinds of agents, the moving principles can be differently applied, you can also develop your own script and logic for autonomous moving.

Example 01: Tesla following NavMesh Agent(patrol)  

The NavMesh Agent is set to *Patrol* script, moving between two points. The Tesla is following NavMesh Agent, by remapping the "Auto User Control" to vector data.

Example 02: Tesla following Target on a path  

Path Creator is an external plug-in that allows you to create a path in Unity, it can either be Bezier path or Vertex path. The path can be 3 dimensional or attached to a 2D plane, you can control the shape of the path just like using control points to control curves in Rhino. It can be open or closed.  

See tutorials on Path Creator: https://www.youtube.com/watch?v=saAQNRSYU9k  
Path Creator github: https://github.com/SebLague/Path-Creator  

Example 03: Gita following NavMesh Agent(patrol)

Gita is using a *Follow Goal* script to follow an agent, as Gita has the freedom in two degrees (non-holonomic system), it can be simulated based on distance/speed calculation, instead of wheel-suspension. 

Example 04: Person pushing a stroller 

The simulation needs to calculate the turning radius of the stroller, which can be recognized as a four-wheel vehicle, so the simulation is just having the stroller following a target, and attach the human (capsule) as the child object.

### 2.3 Truck
Scene 2.3 is loaded with the asset *Vehicles for Logistic Center*
https://assetstore.unity.com/packages/3d/vehicles/land/vehicles-for-logistics-center-73990

### 2.4 Elevator (Vertical Shelves)
Geometries can patrol vertically.

### 2.5 Conveyor 
The conveyor system here is from the asset *Modular Conveyor Tools*. The suggustion would be to drag and drop the prefabs into the scene and then use transform in the inspector section to properly build up your own conveyor system. Select objects and press v key to align conveyor belts.
https://assetstore.unity.com/packages/tools/physics/modular-conveyor-tools-120090

## 03 Flow Vignette

Example files will come later.

## System
Unity version: 2019.2.10f1
Unity Recording Tutorial:https://www.youtube.com/watch?v=VqW-Fg5VafQ 
