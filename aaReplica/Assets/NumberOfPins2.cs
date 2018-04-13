using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfPins2 : MonoBehaviour
{

    #region properties

    public static int PinCount2;

    public Text text2;

    #endregion

    #region methods

    void Start()
    {
        PinCount2 = 16;
    }

    void Update()
    {
        text2.text = PinCount2.ToString();

    }
    #endregion
}