using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType
{
    None, ChangeSpeed, ChangeDirection
}

public class Rotator : MonoBehaviour {

    #region properties

    public float speed = 100f;

    #endregion

    #region methods 
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

    public void DoAction(ActionType type)
    {
        switch (type)
        {
            case ActionType.ChangeDirection:
                speed *= -1;
                break;

            case ActionType.ChangeSpeed:
                speed += 15;
                break;
        }

        if (NumberOfPins.PinCount == 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    #endregion
}

