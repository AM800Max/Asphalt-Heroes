using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarGame : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main Track");
    }

}