using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInputManager : MonoBehaviour
{
    // Updateメソッドはフレームごとに呼び出される
    void Update()
    {
        // もしUIが現在フォーカスされている場合
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // 入力を一時的に無効にする処理（例：キャラクター移動やアクションを無効化）
            // 実際のプロジェクトに合わせてここでキャラクターの入力を無効にします
            return;
        }

        // それ以外の場合、通常のキャラクター操作を行う
        // （例：移動やジャンプなどのコードをここに記述）
    }
}
