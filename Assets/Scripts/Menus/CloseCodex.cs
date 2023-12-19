using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCodex : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject codex;
    public void closeCode()
    {
        codex.SetActive(false);
    }
}
