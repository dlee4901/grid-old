using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tile : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    // [SerializeField] private BoxCollider2D collider;

    bool isHovered;

    public void OnSelect(InputAction.CallbackContext ctx) 
    {
        if (ctx.started && isHovered)
        {
            sprite.material.color = new Color(0.2f, 0.2f, 0.2f);
        }
    }
    
    void OnMouseEnter()
    {
        isHovered = true;
        sprite.material.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnMouseExit()
    {
        isHovered = false;
        sprite.material.color = new Color(1.0f, 1.0f, 1.0f);
    }
}
