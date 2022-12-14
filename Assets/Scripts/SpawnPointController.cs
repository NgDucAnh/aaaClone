using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointController : MonoBehaviour
{
    [SerializeField] GameObject pinPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
