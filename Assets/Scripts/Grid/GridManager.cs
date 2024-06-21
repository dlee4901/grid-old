using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    int _x;

    [SerializeField]
    int _y;

    [SerializeField]
    Tile _tile;

    [SerializeField]
    public float _size;

    List<Tile> _tiles;

    // implement with unity grid?
    // [SerializeField]
    // Grid _grid;

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
        for (int i = 0; i < _x; i++) {
            for (int j = 0; j < _y; j++) {
                _tile.transform.localScale = new Vector3(_size, _size, transform.localScale.z);
                float offset = _size / 0.1f;
                var tile = Instantiate(_tile, new Vector3(i * offset, j * offset, 0), Quaternion.identity);
                _tiles.Add(tile);
            }
        }
    }
}
