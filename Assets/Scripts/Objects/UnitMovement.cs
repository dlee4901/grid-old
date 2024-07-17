using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction {step, stride, line, diagonal, straight, horizontal, vertical, N, NE, E, SE, S, SW, W, NW}

[CreateAssetMenu(menuName = "Unit Movement")]
public class UnitMovement : ScriptableObject
{
    public Direction direction;
    public int distance;
    public bool exact;
    // public bool relativeFacing;

    public void ResetMovement()
    {
        direction = Direction.step;
        distance = 0;
        exact = false;
        // relativeFacing = false;
    }
}
