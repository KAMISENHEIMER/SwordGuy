using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab;
    void Start()
    {
        Instantiate(playerPrefab);
    }

}
