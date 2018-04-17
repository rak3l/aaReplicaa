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
            animator.SetTrigger("WinGame");
            StartCoroutine(NextLevel());
        }
        else
        {
            animator.SetTrigger("EndGame");
        }

    }

    public IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion
}
