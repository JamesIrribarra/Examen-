using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    public string _sceneName;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
