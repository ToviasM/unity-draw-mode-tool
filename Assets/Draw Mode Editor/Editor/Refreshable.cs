using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Refreshable : ScriptableObject
{

}

[CustomEditor(typeof(Refreshable), true)]
public class DrawModeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.DrawDefaultInspector();
        if (GUILayout.Button("Refresh"))
        {
            UnityEditor.Compilation.CompilationPipeline.RequestScriptCompilation();
        }
    }
}
