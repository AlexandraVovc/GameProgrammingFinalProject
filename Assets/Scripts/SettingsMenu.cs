using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public void ReturnButton() {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1); 
    }
}
