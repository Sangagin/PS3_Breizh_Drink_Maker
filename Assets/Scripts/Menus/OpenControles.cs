using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OpenControles : MonoBehaviour
{
    public varMan varMan;

    public void OpenContr()
    {
        bool ctrl = varMan.getCtrlActive();
        if (!ctrl)
        {
            ctrl = true;
            varMan.setCtrlActive(ctrl);
            varMan.setOptionsActive(false);
            varMan.setLevelsActive(false);


        }
    }
}
