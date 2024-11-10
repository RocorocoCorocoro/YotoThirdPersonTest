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
        Debug.Log("Script Started"); // デバッグログ追加
    }



    void OnTriggerEnter(Collider other) //何かがTriggerに入った時の処理
    {
        Debug.Log("OnTriggerEnter called"); // デバッグログ追加

        //ぶつかったのがPlayerというTagを付けたものだったら
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player detected"); // デバッグログ追加
            Debug.Log("ぶつかった"+ this);
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
        Debug.Log("OnTriggerExit called"); // デバッグログ追加

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player exited"); // デバッグログ追加

            Debug.Log("離れた" + this);
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
