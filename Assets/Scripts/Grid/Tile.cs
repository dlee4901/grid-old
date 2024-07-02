using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _sprite;

    // [SerializeField]
    // private BoxCollider2D _collider;

    void OnMouseEnter()
    {
        _sprite.material.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnMouseExit()
    {
        _sprite.material.color = new Color(1.0f, 1.0f, 1.0f);
    }
}
