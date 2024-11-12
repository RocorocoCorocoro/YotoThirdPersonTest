using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer entered the button area");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer exited the button area");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Button was pressed");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Pointer released the button");
    }


    void Start()
    {
        //Debug.Log("これはテスト用ボタンです");
    }

    public void OnPointerEnter()
    {
        Debug.Log("ボタンに触りました。");
    }
}