using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class LEVELGENERATOR : MonoBehaviour
{
    public GameObject[] level;
    [SerializeField] int zPos = 0;
    [SerializeField] bool creatinglevel = false;
    [SerializeField] int levelnum;


    void Update()
    {
        if (creatinglevel == false) { creatinglevel = true;
            StartCoroutine(levelgen());
        }
    } 
       
    
    IEnumerator levelgen()
    {
        levelnum = Random.Range(0, 3);
        Instantiate(level[levelnum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;

        yield return new WaitForSeconds(1);
        creatinglevel = false;
       
      
    }
}
    

