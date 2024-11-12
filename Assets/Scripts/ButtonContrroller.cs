using System.Collections.Generic; // ���X�g�̎g�p�ɕK�v
using UnityEngine;
using UnityEngine.UI; // UI�v�f���������߂̃��C�u����
using UnityEngine.Animations; // �A�j���[�V�������������߂̃��C�u����

public class ButtonContrroller : MonoBehaviour
{
    // �{�^����ێ����郊�X�g
    [SerializeField] private List<Button> actionButtons; // �C���X�y�N�^�Ń{�^����ݒ�

    // �v���C���[�̃A�j���[�^�[
    [SerializeField] private Animator playerAnimator;

    // �X�^�[�g���\�b�h�ŏ����ݒ�
    private void Start()
    {
        

        //// �e�{�^���ɑΉ�����A�N�V������ݒ�B�������Q�̏ꍇ�͂���ɂ���
        //actionButtons[0].onClick.AddListener(() => PlayAnimation("Dig")); // �u�ق�v�̃{�^��
        //actionButtons[1].onClick.AddListener(() => PlayAnimation("Open"));   // �u������v�̃{�^��
        //actionButtons[2].onClick.AddListener(() => PlayAnimation("Break"));  // �u���킷�v�̃{�^��
        //actionButtons[3].onClick.AddListener(() => PlayAnimation("PickUp"));  // �u�Ƃ�v�̃{�^��



        actionButtons[0].onClick.AddListener(() => PlayDigAnimation()); // �u�ق�v�̃{�^��
        actionButtons[1].onClick.AddListener(() => PlayBreakAnimation());   // �u�Ƃ�v�̃{�^��
        actionButtons[2].onClick.AddListener(() => PlayOpenAnimation());  // �u������v�̃{�^��
        //actionButtons[3].onClick.AddListener(() => PlayPickUpAnimation()); //�u���킷�v�̃{�^��

    }

    //�u�ق�v�A�j���[�V�������Đ����郁�\�b�h
    public void PlayDigAnimation()
    {
        Debug.Log("�@��{�^����������܂����B"); // �{�^���������ꂽ���Ƃ��m�F

        if (playerAnimator != null)
        {
            playerAnimator.SetTrigger("Dig"); // �A�j���[�V�����̃g���K�[��ݒ�
            Debug.Log("�A�j���[�V���� 'Dig' �̃g���K�[���ݒ肳��܂����B"); // �g���K�[���ݒ肳�ꂽ���Ƃ��m�F
        }
        else
        {
            Debug.LogWarning("Player Animator ���ݒ肳��Ă��܂���I"); // �A�j���[�^�[�����ݒ�̏ꍇ�̌x��
        }
    }


    // �u�J����v�A�j���[�V�������Đ����郁�\�b�h
    public void PlayOpenAnimation()
    {
        playerAnimator.SetTrigger("Open");
    }

    // �u���v�A�j���[�V�������Đ����郁�\�b�h
    public void PlayPickUpAnimation()
    {
        playerAnimator.SetTrigger("PickUp");
    }


    // �u�󂷁v�A�j���[�V�������Đ����郁�\�b�h
    public void PlayBreakAnimation()
    {
        playerAnimator.SetTrigger("Break");
    }

    


    //���̏�����������
    //public void PlayButtonAnimation(Button button)
    //{
    //    string animationName = button.name; // �{�^���̖��O���A�j���[�V�������Ƃ���
    //    playerAnimator.SetTrigger(animationName);
    //}



    //// �{�^���������ꂽ�Ƃ��ɃA�j���[�V�������Đ����郁�\�b�h
    //private void PlayAnimation(string animationName)
    //{
    //    if (playerAnimator != null)
    //    {
    //        playerAnimator.Play(animationName); // �A�j���[�^�[�Ŏw�肵���A�j���[�V�������Đ�
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Player Animator is not assigned!"); // �A�j���[�^�[���ݒ肳��Ă��Ȃ��ꍇ�̌x��
    //    }
    //}
}
