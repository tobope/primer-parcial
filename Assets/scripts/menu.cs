using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.scripts
{
    public class menu : MonoBehaviour
    {

        public void play()
        {
            SceneManager.LoadScene(1);
        }


        public void exit()
        {
            Debug.Log("Saliendo...");
            Application.Quit();
        }
    }
}