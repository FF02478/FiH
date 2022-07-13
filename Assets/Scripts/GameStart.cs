using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour
{

    private void TransitionToMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void ButtonClicked () 
    {
       TransitionToMain();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TransitionToMain();
        }
    }
}
