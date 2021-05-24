using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 0.1f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        ScoreScript.score += 1;
        Destroy(gameObject);
    }
}