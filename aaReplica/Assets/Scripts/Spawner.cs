using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    #region properties

    public GameObject pinPrefab;

    #endregion

    #region methods

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            SpawnPin();
        }
    }

    void SpawnPin ()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
    
    #endregion
}
