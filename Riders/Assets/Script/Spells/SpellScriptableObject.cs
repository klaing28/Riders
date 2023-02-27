using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Spell", menuName = "Spells")]

public class SpellScriptableObject : ScriptableObject
{
    public float DamageAmount = 10f;
    public float ManaCost = 5f;
    public float Lifetime = 2f;
    public float Speed = 15f;
}