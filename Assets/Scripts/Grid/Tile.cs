using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _sprite;

    [SerializeField]
    private BoxCollider2D _collider;

    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = new Vector3(_size, _size, transform.localScale.z);
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // void OnMouseOver()
    // {
    //     gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
    // }

    void OnMouseEnter()
    {
        _sprite.material.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnMouseExit()
    {
        _sprite.material.color = new Color(1.0f, 1.0f, 1.0f);
    }
}
