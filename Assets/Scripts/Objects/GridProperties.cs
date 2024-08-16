using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Grid Properties")]
public class GridProperties : ScriptableObject
{
    public int x;
    public int y;
    public float size;
    public int unitCap;
    public int numPlayers;
    public Dictionary<int, Unit> units;

    [System.Serializable]
    public struct DeployPositions
    {
        public List<Vector2Int> positions;
    }
    public List<DeployPositions> deployPositions;

    public void ResetGrid()
    {
        x = 8;
        y = 8;
        size = 0.1f;
        unitCap = 0;
        numPlayers = 2;
        deployPositions = null;
    }
}
