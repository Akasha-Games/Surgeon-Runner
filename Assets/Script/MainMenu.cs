using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class MainMenu : MonoBehaviour
{
    [SerializeField]  GameObject Fadeout;
    [SerializeField] GameObject Button;
    [SerializeField]  GameObject BounceText;
    [SerializeField] GameObject animCam;
    [SerializeField] GameObject maincam;
    [SerializeField] GameObject menucontrol;
    [SerializeField] AudioSource buttonselect;
    public static bool hasclicked;
    [SerializeField] GameObject StaticCam;
    [SerializeField] GameObject Fadein;
  void Start()
    {
        StartCoroutine(FadeInoff());
        if (hasclicked == true)
        {
            StaticCam.SetActive(true);
            animCam.SetActive(false);
            menucontrol.SetActive(true);
            BounceText.SetActive(false);
            Button.SetActive(false);
            
        }
    }

    public void MenuStartButton ()
    {
        StartCoroutine(AnimCam());
    }


    public void StartGame()
    {
        StartCoroutine(StartButton());
    }
   
    IEnumerator StartButton()
    {
        buttonselect.Play();
        Debug.Log("Start Button Pressed");

        Fadeout.SetActive(true);

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(1);
    }
    IEnumerator AnimCam()
    {
        animCam.GetComponent<Animator>().Play ("CamMEnuAnim");
        BounceText.SetActive(false);
        Button.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        Fadein.SetActive(false);
        maincam.SetActive(true);
        animCam.SetActive(false);
        menucontrol.SetActive(true);
        hasclicked = true; 


    }

    IEnumerator FadeInoff()
    {
        yield return new WaitForSeconds(1);
        Fadein.SetActive(false);

    }

}