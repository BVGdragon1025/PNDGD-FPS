using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    //Public Variables


    //Private Variables
    [SerializeField] private Vector3 _dPos;
    private bool _open;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Operate()
    {
        if (_open)
        {
            Vector3 pos = transform.localPosition - _dPos;
            transform.localPosition = pos;
        }
        else
        {
            Vector3 pos = transform.localPosition + _dPos;
            transform.localPosition= pos;
        }
        _open = !_open;
    }

    public void Activate()
    {
        if (!_open)
        {
            Vector3 pos = transform.localPosition + _dPos;
            transform.localPosition = pos;
            _open = true;
        }
    }

    public void Deactivate()
    {
        if (_open)
        {
            Vector3 pos = transform.localPosition - _dPos;
            transform.localPosition = pos;
            _open = false;
        }
    }

}
