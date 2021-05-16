using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    private float _speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_target);
        if (_target.position != transform.position)
        {
            //Problem aber interessant: Er wird, je naeher er kommt, langsamer.
            transform.position += new Vector3(_target.position.x - transform.position.x, 0, _target.position.z - transform.position.z) * _speed * Time.deltaTime;

        } 
        else
        {
            //Verloren
        }
    }
}