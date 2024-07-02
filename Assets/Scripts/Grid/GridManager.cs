using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    GridProperties _gridProperties;

    [SerializeField]
    Tile _tile;

    List<Tile> _tiles;

    // implement with unity grid?
    // [SerializeField]
    // Grid grid;

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
        _tiles = new List<Tile>();
        if (_tile != null) {
            for (int i = 0; i < _gridProperties.x; i++) {
                for (int j = 0; j < _gridProperties.y; j++) {
                    _tile.transform.localScale = new Vector3(_gridProperties.size, _gridProperties.size, transform.localScale.z);
                    float offset = _gridProperties.size / 0.1f;
                    var tile = Instantiate(_tile, new Vector3(i * offset, j * offset, 0), Quaternion.identity);
                    _tiles.Add(tile);
                }
            }
        }    
    }
}
