using System.Collections.Generic; // リストの使用に必要
using UnityEngine;
using UnityEngine.UI; // UI要素を扱うためのライブラリ
using UnityEngine.Animations; // アニメーションを扱うためのライブラリ

public class ButtonContrroller : MonoBehaviour
{
    // ボタンを保持するリスト
    [SerializeField] private List<Button> actionButtons; // インスペクタでボタンを設定

    // プレイヤーのアニメーター
    [SerializeField] private Animator playerAnimator;

    // スタートメソッドで初期設定
    private void Start()
    {
        

        //// 各ボタンに対応するアクションを設定。書き方２の場合はこれにする
        //actionButtons[0].onClick.AddListener(() => PlayAnimation("Dig")); // 「ほる」のボタン
        //actionButtons[1].onClick.AddListener(() => PlayAnimation("Open"));   // 「あける」のボタン
        //actionButtons[2].onClick.AddListener(() => PlayAnimation("Break"));  // 「こわす」のボタン
        //actionButtons[3].onClick.AddListener(() => PlayAnimation("PickUp"));  // 「とる」のボタン



        actionButtons[0].onClick.AddListener(() => PlayDigAnimation()); // 「ほる」のボタン
        actionButtons[1].onClick.AddListener(() => PlayBreakAnimation());   // 「とる」のボタン
        actionButtons[2].onClick.AddListener(() => PlayOpenAnimation());  // 「あける」のボタン
        //actionButtons[3].onClick.AddListener(() => PlayPickUpAnimation()); //「こわす」のボタン

    }

    //「ほる」アニメーションを再生するメソッド
    public void PlayDigAnimation()
    {
        Debug.Log("掘るボタンが押されました。"); // ボタンが押されたことを確認

        if (playerAnimator != null)
        {
            playerAnimator.SetTrigger("Dig"); // アニメーションのトリガーを設定
            Debug.Log("アニメーション 'Dig' のトリガーが設定されました。"); // トリガーが設定されたことを確認
        }
        else
        {
            Debug.LogWarning("Player Animator が設定されていません！"); // アニメーターが未設定の場合の警告
        }
    }


    // 「開ける」アニメーションを再生するメソッド
    public void PlayOpenAnimation()
    {
        playerAnimator.SetTrigger("Open");
    }

    // 「取る」アニメーションを再生するメソッド
    public void PlayPickUpAnimation()
    {
        playerAnimator.SetTrigger("PickUp");
    }


    // 「壊す」アニメーションを再生するメソッド
    public void PlayBreakAnimation()
    {
        playerAnimator.SetTrigger("Break");
    }

    


    //この書き方もある
    //public void PlayButtonAnimation(Button button)
    //{
    //    string animationName = button.name; // ボタンの名前をアニメーション名とする
    //    playerAnimator.SetTrigger(animationName);
    //}



    //// ボタンが押されたときにアニメーションを再生するメソッド
    //private void PlayAnimation(string animationName)
    //{
    //    if (playerAnimator != null)
    //    {
    //        playerAnimator.Play(animationName); // アニメーターで指定したアニメーションを再生
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Player Animator is not assigned!"); // アニメーターが設定されていない場合の警告
    //    }
    //}
}
