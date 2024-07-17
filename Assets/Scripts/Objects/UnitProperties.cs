using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Unit Properties")]
public class UnitProperties : ScriptableObject
{
    public int title;
    public int maxHealth;
    public int currentHealth;
}
