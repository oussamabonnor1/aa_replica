using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraBehaviour : MonoBehaviour
{
    public Animation jig;
    

    public void jiggle() 
    {
        jig.Play("CameraJigOnPin");
    }
    
    public IEnumerator gameOver()
    {
        PinSpawner.canPin = false;
        jig.Play("CameraJig");
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PinSpawner.canPin = true;
        PinSpawner.score = 0;
    }
}
