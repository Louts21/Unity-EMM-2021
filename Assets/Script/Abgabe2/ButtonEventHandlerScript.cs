using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandlerScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6f;

    private GameObject _turnLeftButton;
    private GameObject _turnRightButton;
    private GameObject _goForwardButton;
    private GameObject _goBackwardButton;

    private bool _turnLeft = false;
    private bool _turnRight = false;
    private bool _goForward = false;
    private bool _goBackward = false;

    // Start is called before the first frame update
    void Start()
    {
        _turnLeftButton = GameObject.Find("VirtualButtonTurnLeft");
        _turnLeftButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        _turnLeftButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        _turnRightButton = GameObject.Find("VirtualButtonTurnRight");
        _turnRightButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        _turnRightButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        _goForwardButton = GameObject.Find("VirtualButtonGoForward");
        _goForwardButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        _goForwardButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        _goBackwardButton = GameObject.Find("VirtualButtonGoBackward");
        _goBackwardButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        _goBackwardButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    void Update()
    {
        if(_turnLeft == true)
        {
            transform.rotation *= Quaternion.LookRotation(new Vector3(Mathf.Sin(-0.005f), 0, Mathf.Cos(-0.005f)));
        }
        if(_turnRight == true)
        {
            transform.rotation *= Quaternion.LookRotation(new Vector3(Mathf.Sin(0.005f), 0, Mathf.Cos(0.005f)));
        }
        if(_goForward == true)
        {
            Vector3 moveDirectionVBGF = new Vector3(0f, 0f, 0.01f) * _speed * Time.deltaTime;
            transform.Translate(moveDirectionVBGF, Space.Self);
        }
        if(_goBackward == true)
        {
            Vector3 moveDirectionVBGB = new Vector3(0f, 0f, -0.01f) * _speed * Time.deltaTime;
            transform.Translate(moveDirectionVBGB, Space.Self);
        }
    }


    public void OnButtonPressed(VirtualButtonBehaviour vbb)
    {
        switch(vbb.VirtualButtonName)
        {
            case "VirtualButtonTurnLeft":
                _turnLeft = true;
                break;
            case "VirtualButtonTurnRight":
                _turnRight = true;
                break;
            case "VirtualButtonGoForward":
                _goForward = true;
                break;
            case "VirtualButtonGoBackward":
                _goBackward = true;
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vbb)
    {
        switch (vbb.VirtualButtonName)
        {
            case "VirtualButtonTurnLeft":
                _turnLeft = false;
                break;
            case "VirtualButtonTurnRight":
                _turnRight = false;
                break;
            case "VirtualButtonGoForward":
                _goForward = false;
                break;
            case "VirtualButtonGoBackward":
                _goBackward = false;
                break;
        }
    }
}