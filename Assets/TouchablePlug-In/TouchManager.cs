using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{

    public bool debug;
    private Camera _mainCamera;
    private Collider _collider;
    private ITouchable _iTouchable;
    public BoutonManager _boutonManager;
    private int decalage;
    void Start()
    {
        _mainCamera = Camera.main;
    }

    public int tc;

    void Update()
    {

        if(_boutonManager.idScene == 0)
        {
            decalage = 7;
        }
        else if(_boutonManager.idScene == 1)
        {
            decalage = 4;
        }
        else if (_boutonManager.idScene  == 2)
        {
            decalage = 7;
        }

        tc = Input.touchCount;

        if(Input.touchCount<=0)
        {
            ChangeITouchable(null);
            return;
        }


        var touchePos = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, _mainCamera.farClipPlane);
        var touchePosInWorld = _mainCamera.ScreenToWorldPoint(touchePos);
        
        if(debug)
        {
            Debug.DrawLine(_mainCamera.transform.position, touchePosInWorld, Color.red);
        }

        if (Physics.Raycast(_mainCamera.transform.position, touchePosInWorld - _mainCamera.transform.position, out var info))
        {
            var touchePosNear = _mainCamera.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, _mainCamera.nearClipPlane+decalage));
            if(info.collider != _collider)
            {
                _collider = info.collider;
                ChangeITouchable( info.collider.GetComponent<ITouchable>());

                _iTouchable?.OnTouchedDown(touchePosNear);
            }
            _iTouchable?.OnTouchedStay(touchePosNear);

        }
        else
        {
            ChangeITouchable(null);
        }
    }

    private void ChangeITouchable(ITouchable newValue)
    {
        if(_iTouchable==newValue)
        {
            return;
        }
        _iTouchable?.OnTouchedUp();
        _iTouchable = newValue;
        if(newValue == null)
        {
            _collider = null;
        }
    }
}