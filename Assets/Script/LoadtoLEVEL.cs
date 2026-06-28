using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LoadtoLevel : MonoBehaviour
{
    [SerializeField] GameObject Fadeout;
    
     
    void Start()
    {
        StartCoroutine(Loadlevel());
    }

    
   
    IEnumerator Loadlevel()
    {
        yield return new WaitForSeconds(3);
        Fadeout.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);

    }
}
