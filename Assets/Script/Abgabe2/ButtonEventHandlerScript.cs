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

    // Start is called before the first frame update
    void Start()
    {
        _turnLeftButton = GameObject.Find("VirtualButtonTurnLeft");
        _turnLeftButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressedTL);

        _turnRightButton = GameObject.Find("VirtualButtonTurnRight");
        _turnRightButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressedTR);

        _goForwardButton = GameObject.Find("VirtualButtonGoForward");
        _goForwardButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressedGF);

        _goBackwardButton = GameObject.Find("VirtualButtonGoBackward");
        _goBackwardButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressedGB);
    }

    public void OnButtonPressedTL(VirtualButtonBehaviour vbb)
    {
        transform.rotation *= Quaternion.LookRotation(new Vector3(Mathf.Sin(-0.005f), 0, Mathf.Cos(-0.005f)));
        Debug.Log("Turn Left");
    }

    public void OnButtonPressedTR(VirtualButtonBehaviour vbb)
    {
        transform.rotation *= Quaternion.LookRotation(new Vector3(Mathf.Sin(0.005f), 0, Mathf.Cos(0.005f)));
        Debug.Log("Turn Right");
    }

    public void OnButtonPressedGF(VirtualButtonBehaviour vbb)
    {
        Vector3 moveDirectionVBGF = new Vector3(0f, 0f, 1f) * _speed * Time.deltaTime;
        transform.Translate(moveDirectionVBGF, Space.Self);
        Debug.Log("Go Forward");
    }

    public void OnButtonPressedGB(VirtualButtonBehaviour vbb)
    {
        Vector3 moveDirectionVBGB = new Vector3(0f, 0f, -1f) * _speed * Time.deltaTime;
        transform.Translate(moveDirectionVBGB, Space.Self);
        Debug.Log("Go Backward");
    }
}