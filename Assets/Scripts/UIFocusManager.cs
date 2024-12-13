using UnityEngine;
using UnityEngine.EventSystems;

public class UIFocusManager : MonoBehaviour
{
    private void Update()
    {
        // もしマウスがUI要素の上にあるならば
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // マウスカーソルを表示し、ロックを解除
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            // マウスがUI外にあるときは、再度カーソルをロック
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
