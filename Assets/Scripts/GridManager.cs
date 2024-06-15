using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int _x;
    public int _y;
    public GameObject _tile;

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
        for (int i = 0; i < _x; i++) {
            for (int j = 0; j < _y; j++) {
                Instantiate(_tile, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }
}
