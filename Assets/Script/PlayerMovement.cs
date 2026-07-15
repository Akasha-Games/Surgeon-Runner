using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 2;
    public float horizontalSpeed = 3;
    public float rightlimit = 5.5f;
    public float leftlimit = -5.5f;

    public bool moveLeft;
    public bool moveRight;

    [SerializeField] bool isRunning = false;

    void Update()
    {
        if (!isRunning)
        {
            isRunning = true;
            StartCoroutine(Adddistance());
        }

        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World);

  
        if ((Keyboard.current != null &&
            (Keyboard.current.aKey.isPressed ||
             Keyboard.current.leftArrowKey.isPressed))
            || moveLeft)
        {
            if (transform.position.x > leftlimit)
            {
                transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);
            }
        }

        
        if ((Keyboard.current != null &&
            (Keyboard.current.dKey.isPressed ||
             Keyboard.current.rightArrowKey.isPressed))
            || moveRight)
        {
            if (transform.position.x < rightlimit)
            {
                transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
            }
        }
    }

    IEnumerator Adddistance()
    {
        yield return new WaitForSeconds(0.35f);
        SCOREINFO.distanceRun++;
        isRunning = false;
    }
}