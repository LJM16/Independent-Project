using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
       public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

        public void LoadObjectiveScene()
    {
        SceneManager.LoadScene(1);
    }
}
