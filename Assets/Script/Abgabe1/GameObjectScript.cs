using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    [SerializeField]
    private Transform _myPrefab;
    private int _prefabs = 5; 

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < _prefabs; i++)
        {
            Instantiate(_myPrefab, new Vector3(UnityEngine.Random.Range(-5, 5), 0.01f, UnityEngine.Random.Range(-5, 5)), Quaternion.identity);
        }
    }
}
