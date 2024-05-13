using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordData : MonoBehaviour
{
    Sword sword;

    void Start()
    {
        sword = new Sword();
        Debug.Log("Damage: "+ sword.damage+"\nRange: "+ sword.range+"\nType: "+ sword.damageType);
    }
}
