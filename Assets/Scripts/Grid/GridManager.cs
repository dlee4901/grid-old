using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] GridProperties gridProperties;
    [SerializeField] Tile tile;
    [SerializeField] List<GameObject> units;
    List<Tile> tiles;

    // Start is called before the first frame update
    void Start()
    {
        InitGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitGrid()
    {
        tiles = new();
        if (tile != null) {
            for (int i = 0; i < gridProperties.x; i++) {
                for (int j = 0; j < gridProperties.y; j++) {
                    float offset = gridProperties.size / 0.1f;
                    var newTile = Instantiate(tile, new Vector3(i * offset, j * offset, 0), Quaternion.identity);
                    newTile.transform.localScale = new Vector3(gridProperties.size, gridProperties.size, transform.localScale.z);
                    tiles.Add(newTile);
                }
            }
        }
    }

    List<int> GetMovePositions(int position, UnitMovement movement) {
        return GetMovePositions(Unflatten(position), movement);
    }

    List<int> GetMovePositions((int, int) position, UnitMovement movement) {
        List<int> movePositions = new();
        var unit = GetUnit(position);
        if (!IsValidPosition(position) || unit == null) {
            return movePositions;
        }
        

        return movePositions;
    }

    // Helper Methods
    int Flatten(int x, int y) {
        return y * gridProperties.x + x;
    }

    (int x, int y) Unflatten(int x) {
        return (x % gridProperties.x, x / gridProperties.x);
    }

    void AddUnit(int position, GameObject unit) {
        units[position] = unit;
    }

    void MoveUnit(int src, int dst) {
        if (units[src] != null) {
            units[dst] = units[src];
            units[src] = null;
        }
    }

    GameObject GetUnit(int position) {
        return units[position];
    }

    GameObject GetUnit((int, int) position) {
        return GetUnit(Flatten(position.Item1, position.Item2));
    }

    bool IsValidPosition(int position) {
        return IsValidPosition(Unflatten(position));
    }

    bool IsValidPosition((int, int) position) {
        return position.Item1 >= 0 && position.Item2 >= 0 && position.Item1 < gridProperties.x && position.Item2 < gridProperties.y;
    }
}
