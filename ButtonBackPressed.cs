using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonBackPressed : MonoBehaviour {


    public GameObject Panel;
    float counter;




    public void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                counter++;
                if (counter % 2 == 1)
                {
                    Panel.gameObject.SetActive(true);
                }
                else
                {
                    Panel.gameObject.SetActive(false);
                }
                return;
            }
        }
       
   // void Awake()
   // {
    //    Panel.gameObject.SetActive(false);
    //}



    /*public void ShowHidePanel()
    {
        counter++;
        if (counter % 2 == 1)
        {
            Panel.gameObject.SetActive(true);
        }
        else
        {
            Panel.gameObject.SetActive(false);
        }
    }*/
}
}
