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
        //Debug.Log("����̓e�X�g�p�{�^���ł�");
    }

    public void OnPointerEnter()
    {
        Debug.Log("�{�^���ɐG��܂����B");
    }
}