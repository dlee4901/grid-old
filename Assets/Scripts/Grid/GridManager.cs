using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    GridProperties gridProperties;

    [SerializeField]
    Tile tile;

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
        tiles = new List<Tile>();
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

    int Flatten(int x, int y) {
        return y * gridProperties.x + x;
    }

    (int x, int y) Unflatten(int x) {
        return (x % gridProperties.x, x / gridProperties.x);
    }
}
