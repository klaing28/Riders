using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "Spells")]
public class SpellSO : ScriptableObject
{
    public KeyCode key;
    public new string name;
    public float ManaCost;
    public float cooldownTime;
    public GameObject chuj;
    //public virtual void Projectile() { }
    public enum Caster{ Projectile, Self };
    public Caster caster;
    
}
