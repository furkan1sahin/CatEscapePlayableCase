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
        StartCoroutine(LoadSceneAsync(LevelIndex));
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
