using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float slowDownFactor;
    public void EndGame() {
       StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel() {

        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownFactor;

        yield return new WaitForSeconds(slowDownFactor * 2);

        Time.timeScale = 1; 
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDownFactor;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
