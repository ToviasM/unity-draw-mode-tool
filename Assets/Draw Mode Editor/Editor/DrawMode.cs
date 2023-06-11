using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Draw Mode", menuName = "Tooling/Draw Mode", order = 1)]
public class DrawMode : Refreshable
{
    public string DrawName;
    public string DrawCategory;
    public Shader shader;


    public List<ShaderFloat> floatVariables = new List<ShaderFloat>();
    public List<ShaderTexture> textureVariables = new List<ShaderTexture>();

    public void SetDrawMode(SceneView view)
    {
        view.SetSceneViewShaderReplace(shader, null);
    } 

    public void SetGlobalVariables()
    {
        foreach (ShaderFloat v in floatVariables)
        {
            Shader.SetGlobalFloat(v.name, v.value);
        }

        foreach (ShaderTexture v in textureVariables)
        {
            Shader.SetGlobalTexture(v.name, v.value);
        }
    }

    public void Refresh()
    {
        SetGlobalVariables();
    }

    [Serializable]
    public class ShaderFloat
    {
        public float value;
        public string name;
    }

    [Serializable]
    public class ShaderTexture
    {
        public Texture2D value;
        public string name;
    }
}
