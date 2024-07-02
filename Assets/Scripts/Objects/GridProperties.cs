using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Grid Properties")]
public class GridProperties : ScriptableObject
{
    public int x;
    public int y;
    public float size;

    public void ResetGrid()
    {
        x = 8;
        y = 8;
        size = 0.1f;
    }
}
