using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    #region properties

    public GameObject pinPrefab;
    public int maxItems = 10;
    public ActionType type;

    #endregion

    #region methods
    void Awake()
    {
        NumberOfPins.PinCount = maxItems;
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && maxItems-- > 0)
        {
            SpawnPin();
        }
    }

    void SpawnPin ()
    {
        GameObject pin = Instantiate(pinPrefab, transform.position, transform.rotation);
        pin.GetComponent<Pin>().type = type;
    }
    
    #endregion
}
