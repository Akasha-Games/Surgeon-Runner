using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Bluetriggersyringe : MonoBehaviour
{
    [SerializeField] AudioSource BlueFX;

     void OnTriggerEnter(Collider other)
    {
       BlueFX.Play();
        SCOREINFO.Bluesyringecount += 1;
        this.gameObject .SetActive(false);  
    }
}
