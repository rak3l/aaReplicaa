using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfPins : MonoBehaviour {

    #region properties

    public static int PinCount;

    public Text text;

    #endregion

    #region methods

    void Start()
    {
        PinCount = 20;
    }

    void Update()
    {
        text.text = PinCount.ToString();
    }

    #endregion
}
