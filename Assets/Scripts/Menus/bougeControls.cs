using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bougeControls : MonoBehaviour
{

    public int sens;
   // public int pos = 0;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public varMan var;
    // Start is called before the first frame update
 public void bouge()
    {
        
        if(sens == 0)
        {
            if(var.pos == 0)
            {
                image1.SetActive(false);
                image2.SetActive(true);
                image3.SetActive(false);
                var.pos = 1;
            }
            else if(var.pos == 1){
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(true);
                var.pos = 2;
            }

        }
        else if (sens == 1)
        {
            if (var.pos == 1)
            {
                image1.SetActive(true);
                image2.SetActive(false);
                image3.SetActive(false);
                var.pos = 0;
            }
            else if (var.pos == 2)
            {
                image1.SetActive(false);
                image2.SetActive(true);
                image3.SetActive(false);
                var.pos = 1;
            }
        }

    }
}
