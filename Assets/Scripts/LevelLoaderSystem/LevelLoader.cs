using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] List<LevelData> LevelList = new List<LevelData>();
    [SerializeField] ScriptableEvent SceneLoadedEvent;

    void Start()
    {
        
    }

    public void LoadLevel(int LevelIndex)
    {
        UnloadAllLevels();
        StartCoroutine(LoadSceneAsync(LevelIndex));
    }

    void UnloadAllLevels()
    {
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            if (i != 0)
            {
                SceneManager.UnloadSceneAsync(i);
            }
        }
    }

    IEnumerator LoadSceneAsync(int levelIndex)
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(levelIndex, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        SceneLoadedEvent.Invoke();
    }
}
