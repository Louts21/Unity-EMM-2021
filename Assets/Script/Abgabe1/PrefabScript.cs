using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0, 0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        ScoreScript.score += 1;
        Destroy(gameObject);
    }
}