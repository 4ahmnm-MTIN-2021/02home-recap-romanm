using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_script : MonoBehaviour
{
 public void NextScene()
    {
        SceneManager.LoadScene("recap_scene2", LoadSceneMode.Single);
    }
}
