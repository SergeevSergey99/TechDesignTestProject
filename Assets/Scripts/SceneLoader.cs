using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] SceneAsset sceneAsset;
    
    public void LoadScene()
    {
        if (sceneAsset != null)
        {
            SceneManager.LoadScene(sceneAsset.name);
        }
    }
}
