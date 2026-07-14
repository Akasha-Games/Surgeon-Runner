using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
public class SCOREINFO : MonoBehaviour
{
    
    public static int syringecount = 0;
    [SerializeField] GameObject syringedisplay ;
    public static int Bluesyringecount = 0;
    public static int distanceRun;
    [SerializeField] int internalDistance;
    [SerializeField] GameObject bluesyringedisplay;
    [SerializeField] GameObject Rundisp;


     void Start()
    {
        syringecount = 0;
        Bluesyringecount = 0;
        distanceRun = 0;    

    }

    void Update()
    {
        internalDistance = distanceRun;
        syringedisplay.GetComponent<TMPro.TMP_Text>().text = "" + syringecount;
       bluesyringedisplay.GetComponent<TMPro.TMP_Text>().text = "" + Bluesyringecount;
        Rundisp.GetComponent<TMPro.TMP_Text>().text = "" + distanceRun;

    }
}
