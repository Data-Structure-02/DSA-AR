using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoaderNoDelay : MonoBehaviour
{

    public void LoadScne(string nmescene)
    {
        SceneManager.LoadScene(nmescene);
    }
}