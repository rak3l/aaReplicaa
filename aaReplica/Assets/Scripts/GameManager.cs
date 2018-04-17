using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    #region  properties

    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    #endregion 

    #region methods

	public void EndGame ()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        gameHasEnded = true;

        if (NumberOfPins.PinCount == 0)
        {
            // win - change level
            Debug.Log("you win");
        }
        else
        {
            animator.SetTrigger("EndGame");
        }

    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion
}
