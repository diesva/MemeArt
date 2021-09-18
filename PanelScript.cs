using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour {

    public GameObject Panel;
    float counter;

    
        void Awake()
        {
            Panel.gameObject.SetActive(false);
        }

    

    public void ShowHidePanel () {
        counter++;
        if (counter % 2 == 1)
        {
            Panel.gameObject.SetActive(true);
        }
        else
        {
            Panel.gameObject.SetActive(false);
        }
            }
        }


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showhidePanel : MonoBehaviour {
    int counter;
    public GameObject Panel;
    void Awake()
    {
        Panel.gameObject.SetActive(false);
    }

    public void showhidePanel_dps()
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
    }
}
*/

	
	
