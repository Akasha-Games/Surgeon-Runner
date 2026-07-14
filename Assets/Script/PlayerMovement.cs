using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 2;
    public float horizontalSpeed = 3;
    public float rightlimit = 5.5f;
    public float leftlimit = -5.5f;
    [SerializeField] bool isRunning = false;
    void Update()
    {
        if (isRunning == false)
        {
            isRunning = true;
            StartCoroutine(Adddistance());
        }
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftlimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))

        {
            if (this.gameObject.transform.position.x < rightlimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * playerSpeed );
        }
    }

    IEnumerator Adddistance()
    {
        yield return new WaitForSeconds(0.35f);
        SCOREINFO.distanceRun += 1;
        isRunning = false;
    }

}

