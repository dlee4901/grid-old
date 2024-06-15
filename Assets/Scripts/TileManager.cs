using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f);
    }
}
