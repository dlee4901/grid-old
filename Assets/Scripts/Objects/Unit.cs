using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Unit")]
public class Unit : ScriptableObject
{
    public string title;
    public int maxHealth;
    public int currentHealth;
    public DirectionFacing facing;
    public UnitMovement movement;

    public void ResetProperties()
    {
        title = "";
        maxHealth = 0;
        currentHealth = 0;
        facing = DirectionFacing.N;
        movement = null;
    }
}
