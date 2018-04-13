using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    #region properties

    public float speed = 100f;

    #endregion

    #region methods 
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
    #endregion
}

