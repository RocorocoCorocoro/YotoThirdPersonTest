using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonStateTester : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Button highlighted!");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Button normal state!");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Button pressed!");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Button released!");
    }
}