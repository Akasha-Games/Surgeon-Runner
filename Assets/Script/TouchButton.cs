using UnityEngine;
using UnityEngine.EventSystems;

public class TouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public PlayerMovement player;
    public bool leftButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (leftButton)
            player.moveLeft = true;
        else
            player.moveRight = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (leftButton)
            player.moveLeft = false;
        else
            player.moveRight = false;
    }
}