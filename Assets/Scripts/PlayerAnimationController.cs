using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
   
        private Animator playerAnimator;

        void Start()
        {
            playerAnimator = GetComponent<Animator>(); // プレイヤーのAnimatorコンポーネントを取得
        }

        public void PerformAction()
        {
            // アクションレイヤーのWeightを1に設定し、PickUpアニメーションを再生
            playerAnimator.SetLayerWeight(1, 1);//()内のはじめの１は、Actionレイヤーのこと。そっちのウェイトを大にする。
            //因にBaseLayerは0。
            playerAnimator.SetTrigger("PickUp");
        }

        public void ResetLayerWeight()
        {
            // アニメーションが終了したらWeightを0に戻す
            playerAnimator.SetLayerWeight(1, 0);//Actionレイヤーのウェイトをゼロにする
        }
    
}
