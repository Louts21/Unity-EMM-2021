using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabAB2Script : MonoBehaviour
{
    public static int score;

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 0.1f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        ++score;
        Debug.Log("Collection of bottles: " + score);
        Destroy(gameObject);
    }
}
