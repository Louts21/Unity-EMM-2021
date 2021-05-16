using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectAB2Script : MonoBehaviour
{
    [SerializeField]
    private Transform _myPrefab;
    [SerializeField]
    private Transform _parent;
    private int _prefabs = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _prefabs; i++)
        {
            Instantiate(_myPrefab, new Vector3(UnityEngine.Random.Range(-0.23f, 0.23f), 0.04f, UnityEngine.Random.Range(-0.1f, 0.3f)), Quaternion.identity, _parent);
        }
    }
}
