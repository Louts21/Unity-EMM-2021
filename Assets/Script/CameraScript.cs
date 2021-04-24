using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    private Vector3 _endPosition;
    private Vector3 _cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        _cameraPosition = new Vector3(_target.position.x, 0, _target.position.z) + new Vector3(0, 0, -3);
    }

    // Update is called once per frame
    void Update()
    {
        _endPosition = new Vector3(_target.position.x, 0, _target.position.z) + _target.rotation * new Vector3(0, 0, -3);

        transform.LookAt(_target.position);

        _cameraPosition = Vector3.Slerp(_cameraPosition, _endPosition, 0.05f);
        transform.LookAt(_target.position);

        transform.position = _cameraPosition + new Vector3(0, 2f, 0);
    }
}