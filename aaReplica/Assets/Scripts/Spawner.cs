using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    #region properties 

    public GameObject pinPrefab;
    public int maxItems = 10;

    #endregion

    #region method

    void Update()
    {
        if (Input.GetButtonDown("Jump") && maxItems-- > 0)
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }

    #endregion
}
