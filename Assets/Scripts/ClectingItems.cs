using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClectingItems : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Button1;
    [SerializeField] GameObject Button2;
    [SerializeField] GameObject Button3;
    //[SerializeField] GameObject TreasureBox;
    [SerializeField] GameObject Player;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = Player.GetComponent<Animator>();
        Panel.SetActive(false);
        Debug.Log("Script Started"); // �f�o�b�O���O�ǉ�
    }



    void OnTriggerEnter(Collider other) //������Trigger�ɓ��������̏���
    {
        Debug.Log("OnTriggerEnter called"); // �f�o�b�O���O�ǉ�

        //�Ԃ������̂�Player�Ƃ���Tag��t�������̂�������
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player detected"); // �f�o�b�O���O�ǉ�
            Debug.Log("�Ԃ�����"+ this);
            animator.SetBool("Colect", true);
            Panel.SetActive(true);
            Button1.SetActive(true);
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Colect", true);
            Panel.SetActive(true);
            Button1.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit called"); // �f�o�b�O���O�ǉ�

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player exited"); // �f�o�b�O���O�ǉ�

            Debug.Log("���ꂽ" + this);
            animator.SetBool("Colect", false);
            Panel.SetActive(false);
            Button1.SetActive(false);
        }
    }


            // Update is called once per frame
            void Update()
    {
      
    }


}
