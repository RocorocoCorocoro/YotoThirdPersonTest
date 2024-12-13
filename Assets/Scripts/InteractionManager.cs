using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InteractionManager : MonoBehaviour
{
    public GameObject YotoArmature; // プレイヤーのアーマチュア
    private Animator playerAnimator; // プレイヤーのアニメーター
    public Text interactionText; // 「とる」テキストUIを参照
    private bool isInRange = false; // プレーヤーがトリガー範囲に入っているかのフラグ
    private PlayerAnimationController playerAnimationController; // PlayerControllerスクリプトの参照


    void Start()
    {
        // PlayerControllerスクリプトを取得
        playerAnimationController = YotoArmature.GetComponent<PlayerAnimationController>();
        // 初期状態でテキストを非表示にする
        interactionText.enabled = false;
        //playerAnimator = YotoArmature.GetComponent<Animator>();
    }

    void Update()
    {
        
        // プレイヤーが範囲内にいて、Enterキーが押された場合
        if (isInRange && Input.GetKeyDown(KeyCode.Return))
        {
            playerAnimationController.PerformAction(); // PlayerController側のアクションを実行
        }
    }

    // トリガーに入ったときに呼び出されるメソッド
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // プレイヤーがトリガーに入った場合
        {
            interactionText.enabled = true;  // テキストを表示
            isInRange = true;                // 範囲内フラグを立てる
           
        }
    }

    // トリガーから出たときに呼び出されるメソッド
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // プレイヤーがトリガーから出た場合
        {
            interactionText.enabled = false; // テキストを非表示
            isInRange = false;               // 範囲内フラグを解除
            playerAnimationController.ResetLayerWeight(); // PlayerController内のResetLayerWeight()を実行
        }
    }

    //// アクションを実行するメソッド（例: アイテム取得やアニメーション変更）
    //private void PerformAction()
    //{
    //    // ActionLayerのWeightを1に設定してPickUpアニメーションを再生
    //    //playerAnimator.SetLayerWeight(1, 1); // 1はActionLayerのインデックス
    //    //playerAnimator.SetTrigger("PickUp"); // PickUpアニメーションを開始

    //    // アニメーションが終わったら（遅延でWeightを戻す）
    //    //Invoke("ResetLayerWeight", 5.0f); // 7.0秒後（アニメーションの長さによって調節する）にResetLayerWeightメソッドを呼ぶ
    //    //上の一行は、アニメーションのExitTimeを利用する場合は不要となる


    //    //// アイテムをインベントリに追加
    //    //// InventoryManager.Instance.AddItem(itemID);

    //    //// アニメーションをPickUpに変更
    //    //if (playerAnimator != null)
    //    //{

    //    //    playerAnimator.SetTrigger("PickUp"); // PickUpトリガーを設定
    //    //}



    //    // アクションが完了したらテキストを非表示にする
    //    interactionText.enabled = false;
    //    isInRange = false;
    //}

    //// レイヤーのウェイトをリセットするメソッド
    //public void ResetLayerWeight()
    //{

    //    // トリガーをリセットして再度実行可能にする
    //    playerAnimator.ResetTrigger("PickUp");
    //    playerAnimator.SetLayerWeight(1, 0); // ActionLayerのWeightを0に戻す
    //}


}
