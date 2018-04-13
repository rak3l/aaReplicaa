using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    #region  properties

    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    
    #endregion 

    #region methods

	public void EndGame ()
    {
        if (gameHasEnded)
            return;

        gameHasEnded = true;

    }

    #endregion
}
