using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class triggersyringe : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;

     void OnTriggerEnter(Collider other)
    {
       coinFX.Play();
        SCOREINFO.syringecount += 1;
        this.gameObject .SetActive(false);  
    }
}
