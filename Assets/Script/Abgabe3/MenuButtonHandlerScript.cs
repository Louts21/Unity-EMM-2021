using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonHandlerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _menu;
    [SerializeField]
    private Button _returnButton;
    [SerializeField]
    private Button _restartButton;

    // Start is called before the first frame update
    void Start()
    {
        _menu.SetActive(false);

        _returnButton.onClick.AddListener(ReturnOnClick);

        _restartButton.onClick.AddListener(RestartOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_menu.activeSelf)
            {
                _menu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
                _menu.SetActive(true);
            }
        }
    }

    void ReturnOnClick()
    {
        _menu.SetActive(false);
        Time.timeScale = 1;
    }

    void RestartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _menu.SetActive(false);
        Time.timeScale = 1;
    }
}
