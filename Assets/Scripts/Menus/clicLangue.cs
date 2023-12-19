using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicLangue : MonoBehaviour
{
    // Start is called before the first frame update
    public int en;
    public Codex codex;
    public void change()
    {
        if (en == 0)
        {
            codex.langue = true;
        }
        else
        {
            codex.langue=false;
        }
    }
}
