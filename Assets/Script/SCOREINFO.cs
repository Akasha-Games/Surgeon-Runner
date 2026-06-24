using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
public class SCOREINFO : MonoBehaviour
{
    
    public static int syringecount = 0;
    [SerializeField] GameObject syringedisplay ;
   

    
    void Update()
    {
        syringedisplay.GetComponent<TMPro.TMP_Text>().text = "SYRINGE " + syringecount;

    }
}
