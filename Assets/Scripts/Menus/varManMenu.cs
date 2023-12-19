using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class varMan : MonoBehaviour
{
    // Start is called before the first frame update


    private bool ctrlActive = false;
    private bool optionsActive = false;
    private bool levelActive = false;
    public GameObject ecranC,ecranJ,ecranO;


    private int levelSelected;

    //private Vector3 storeC,storeJ,storeO;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        ecranC.SetActive(ctrlActive);
        ecranJ.SetActive(levelActive);
        ecranO.SetActive(optionsActive);
       


    }

    public bool getCtrlActive() {  return ctrlActive; }
    public void setCtrlActive(bool ctrlActive) { this.ctrlActive = ctrlActive; }
    public bool getOptionsActive() { return optionsActive; }
    public void setOptionsActive(bool modif) { this.optionsActive = modif; }
    public bool getLevelsActive() { return levelActive; }
    public void setLevelsActive(bool modif) { this.levelActive = modif; }

    public int getLevelSelected() { return levelSelected; }
    public void setLevelSelected(int levelChoosen) {  levelSelected = levelChoosen; }
}
