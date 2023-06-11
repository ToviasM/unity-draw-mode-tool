using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Draw Collection", menuName = "Tooling/Draw Collection", order = 1)]
public class DrawCollection : Refreshable
{
    public List<DrawMode> drawModes = new List<DrawMode>();
}
