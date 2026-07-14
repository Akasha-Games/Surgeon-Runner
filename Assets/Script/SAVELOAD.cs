using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SAVELOAD : MonoBehaviour
{
    public static int loadedredsyringe;
    public static int loadedbluesyringe;
    public static int loadedDistance;
    public static bool saveData;

    [SerializeField] int internalREDsy;
    [SerializeField] int internalBluesy;
    [SerializeField] int internalDiS;

    void Start()
    {
        loadedredsyringe = PlayerPrefs.GetInt("REDSYsave");
        loadedbluesyringe = PlayerPrefs.GetInt("BLUESYsave");
        loadedDistance = PlayerPrefs.GetInt("DISsave");

    }

    
    void Update()
    {
        internalREDsy = loadedredsyringe + SCOREINFO.syringecount;
        internalBluesy = loadedbluesyringe + SCOREINFO.Bluesyringecount;

        internalDiS = loadedDistance + SCOREINFO.distanceRun;
        if (saveData == true)
        {
            saveData = false;
            PlayerPrefs.SetInt("REDSYsave", internalREDsy);
            PlayerPrefs.SetInt("BLUESYsave", internalBluesy);
            PlayerPrefs.SetInt("DISsave", internalDiS);

        }
    }
}
