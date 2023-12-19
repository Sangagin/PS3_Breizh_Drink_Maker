using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOptions : MonoBehaviour
{
    public varMan varMan;



    public void OpenOpt()
    {
        bool ctrl = varMan.getOptionsActive();
        if (!ctrl)
        {
            ctrl = true;
            varMan.setOptionsActive(ctrl);
            varMan.setCtrlActive(false);
            varMan.setLevelsActive(false);


        }
    }

    
}
