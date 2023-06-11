# Draw Mode Tool Documentation

## Overview

The Draw Mode Tool is a powerful Unity Editor extension that allows you to create custom draw modes for your games. These draw modes provide unique visualization options within the Unity Editor scene view. This documentation will guide you through the process of using the tool, from setting up the required scriptable objects to assigning draw modes with custom shaders and variables.

## Installation

To start using the Draw Mode Tool, follow these steps:

1. Clone or download the Draw Mode Tool repository from [GitHub link](link).

2. Open your Unity project.

3. In the Unity Editor, navigate to **Assets > Import Package > Custom Package**.

4. Select the downloaded package from the file explorer.

5. Import the package into your project.

## Creating a Draw Collection

A Draw Collection is a container that holds multiple Draw Modes. To create a new Draw Collection, follow these steps:

1. In the Unity Editor's Project window, right-click on an empty space.

2. Navigate to **Create > Tooling > Draw Collection**.

3. A new Draw Collection asset will be created in your project. You can rename it as desired.

## Creating and Assigning Draw Modes

Draw Modes define the specific visualization behavior for your custom draw modes. Each Draw Mode is a Scriptable Object that can be assigned to a Draw Collection. To create and assign Draw Modes, follow these steps:

1. In the Unity Editor's Project window, right-click on an empty space.

2. Navigate to **Create > Tooling > Draw Mode**.

3. A new Draw Mode asset will be created in your project. You can rename it as desired.

4. Select the newly created Draw Mode asset.

5. In the Inspector window, you will see the properties for the Draw Mode.

6. Assign a name for the Draw Mode. This name will be displayed in the dropdown menu of the scene view.

7. Specify a section for the Draw Mode. The section helps organize draw modes in the dropdown menu.

8. Set a shader for the Draw Mode. This shader will determine how the scene objects are rendered in the custom draw mode.

9. Optionally, you can define additional shader variables to be affected or changed by the Draw Mode. Use the Inspector to add and configure these variables.

10. Repeat the above steps to create additional Draw Modes as needed.

11. Assign the created Draw Modes to the desired Draw Collection. Select the Draw Collection asset in the Project window and locate the **Draw Modes** field in the Inspector.

12. Drag and drop the Draw Mode assets from the Project window into the **Draw Modes** field of the Draw Collection.

13. Ensure that your scripts are pointing to the correct Draw Collection. You can reference the Draw Collection asset in your scripts to access and utilize the assigned Draw Modes.

## Refreshing Draw Modes

After making any changes to the Draw Collection or Draw Modes, it is important to refresh the tool to reflect the modifications in the Unity Editor scene view. The Draw Mode Tool provides a custom Inspector with a **Refresh** button for both the Draw Collection and individual Draw Mode assets. To refresh the tool, follow these steps:

1. Select the Draw Collection asset in the Project window.

2. In the Inspector, locate the **Refresh** button and click it.

3. Similarly, select the individual Draw Mode asset(s) and click the **Refresh** button in their respective Inspectors.

4. The tool will update and apply the changes to the scene view.

## Conclusion

The Draw Mode Tool is a versatile and customizable extension that empowers artists and developers to create unique visualizations within the Unity Editor scene view. By utilizing Draw Collections and Draw Modes, you can enhance your game development workflow and gain valuable insights into your scene's assets.
