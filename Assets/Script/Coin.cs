using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] int rotatespeed = 1;


    
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);
    }
}
