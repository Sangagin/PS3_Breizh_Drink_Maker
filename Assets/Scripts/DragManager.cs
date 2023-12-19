using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragManager : MonoBehaviour
{
    private bool _isDragEnCours = false;
    private Vector2 _dragPositionDepartEcran;
    private Vector3 _coordonneesEnJeu;
    private Drag _dragbougé;
    private Camera _camera;

    public GameObject cube;


    private void Start()
    {
        _camera = Camera.main;
    }



    // Update is called once per frame
    void Update()
    {

        if (_isDragEnCours && (Input.GetMouseButtonUp(0)||(Input.touchCount == 1 && Input.GetTouch(0).phase== TouchPhase.Ended)))
        {

            Debug.Log("drop");
            Drop();
            return;
        }









        if (Input.GetMouseButton(0))
        {
            Debug.Log("clicSourie");

            Vector3 positionSourie = Input.mousePosition;
            _dragPositionDepartEcran = new Vector3(positionSourie.x, positionSourie.y, _camera.farClipPlane);

        }
        else if (Input.touchCount > 0)
        {
            Debug.Log("clicTouch");

           // _dragPositionDepartEcran = (Input.GetTouch(0).position, _camera.farClipPlane);
        }
        else
        {
            return;
        }

        

        _coordonneesEnJeu = Camera.main.ScreenToWorldPoint(_dragPositionDepartEcran);
        GameObject test = Instantiate(cube, _coordonneesEnJeu, this.transform.rotation);


        Debug.Log(_coordonneesEnJeu);
        Debug.Log(_dragPositionDepartEcran);













        /*
        if (_isDragEnCours)
        {
            Debug.Log("onBouge");

            Drag();

        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(_coordonneesEnJeu, Vector3.zero, Mathf.Infinity);
            if (hit.collider != null)
            {
                Debug.Log("touche quelque chose");
                Drag drag = hit.transform.gameObject.GetComponent<Drag>();
                if(drag != null)
                {

                    Debug.Log("touche draggable");
                    _dragbougé = drag;
                    InitDrag();
                }
            }
        }

        */
    }


    void InitDrag()
    {
        _isDragEnCours = true;

    }

    void Drag()
    {
        _dragbougé.transform.position = new Vector3(_coordonneesEnJeu.x, _coordonneesEnJeu.y, _dragbougé.transform.position.z);
    }


    void Drop()
    {
        _isDragEnCours = false;
    }

}
