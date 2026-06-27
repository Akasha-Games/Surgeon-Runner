using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.SceneManagement;



public class COllision : MonoBehaviour
{
    [SerializeField] GameObject theplayer;
    [SerializeField] GameObject playerAim;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject maincam;
    [SerializeField] GameObject fadeoutp;
    void OnTriggerEnter(Collider other)
    {
       StartCoroutine(Collisionend());
    }

    IEnumerator Collisionend()
    {
        collisionFX.Play();
        theplayer.GetComponent<PlayerMovement>().enabled = false;
        playerAim.GetComponent<Animator>().Play("Stumble Backwards");
        maincam.GetComponent<Animator>().Play("CollisionCam");
        yield return new WaitForSeconds(2);
        fadeoutp.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
