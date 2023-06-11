using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using static UnityEditor.SceneView;
using System.IO;

[InitializeOnLoad]
public class CustomDrawModeEditor
{
    public const string c_drawCollectionPath = "Assets\\Draw Mode Editor\\Example\\Collections\\Collection.asset";

    public static DrawCollection currentCollection;
    public static SceneView currentSceneView;
    static CustomDrawModeEditor()
    {
        EditorApplication.update += EditorUpdate;
        currentCollection = AssetDatabase.LoadAssetAtPath<DrawCollection>(c_drawCollectionPath);


        for (int i = 0; i < currentCollection.drawModes.Count; i++)
        {
            currentCollection.drawModes[i].Refresh();
            SceneView.AddCameraMode(currentCollection.drawModes[i].DrawName, currentCollection.drawModes[i].DrawCategory);
        }
    }


    public static void OnCameraModeChange(CameraMode mode)
    {
        bool IsSelected = false;
        for (int i = 0; i < currentCollection.drawModes.Count; i++)
        {
       
            if (mode.name == currentCollection.drawModes[i].DrawName)
            {
                currentCollection.drawModes[i].Refresh();
                currentCollection.drawModes[i].SetDrawMode(currentSceneView);
                IsSelected = true;
            }
        }
        if (IsSelected == false)
        {
            ResetDrawMode(currentSceneView);
        }
    }
     
    public static void ResetDrawMode(SceneView view)
    {
        view.SetSceneViewShaderReplace(null, null);
    }
    public static void EditorUpdate()
    {
        //If our sceneView has changed
        if (SceneView.lastActiveSceneView != currentSceneView)
        {
            //Go ahead and clear the event from the previous scene View
            if (currentSceneView != null)
                currentSceneView.onCameraModeChanged -= OnCameraModeChange;

            //As long as our scene view exists, and is new, add our event and set our current drawing scene to latest scene view
            if (SceneView.lastActiveSceneView != null)
            {
                currentSceneView = SceneView.lastActiveSceneView;
                currentSceneView.onCameraModeChanged += OnCameraModeChange;
            }
        }
    }
}
