using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClectingItems : MonoBehaviour
{
    [SerializeField] GameObject ButtonGroup;
    [SerializeField] GameObject Button1;
    [SerializeField] GameObject Button2;
    [SerializeField] GameObject Button3;
    
    [SerializeField] GameObject Player;
   


    // Start is called before the first frame update
    void Start()
    {
        
        ButtonGroup.SetActive(false);
        
    }



    void OnTriggerEnter(Collider other) //‰½‚©‚ªTrigger‚É“ü‚Á‚½‚Ìˆ—
    {
        

        //‚Ô‚Â‚©‚Á‚½‚Ì‚ªPlayer‚Æ‚¢‚¤Tag‚ğ•t‚¯‚½‚à‚Ì‚¾‚Á‚½‚ç
        if (other.gameObject.CompareTag("Player"))
        {



            ButtonGroup.SetActive(true);
            //Button1.SetActive(true);
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            ButtonGroup.SetActive(true);
           // Button1.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        

        if (other.gameObject.CompareTag("Player"))
        {


            ButtonGroup.SetActive(false);
            //Button1.SetActive(false);
        }
    }


            // Update is called once per frame
            void Update()
    {
      
    }


}
