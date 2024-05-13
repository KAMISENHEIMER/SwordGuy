using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType {
Normal,
Fire,
Ice
}

public enum AttackPattern {
    Cone,
    Sphere,
    Line
}

public class Sword
{
    public float damage;
    public float range;
    public float cooldown;
    public DamageType damageType;
    public AttackPattern attackPattern;

    public Sword()
    {
        //make all this random
        damage = 1;
        range = 1;
        cooldown = 1;
        damageType = DamageType.Normal;
        attackPattern = AttackPattern.Cone;
    }

}
