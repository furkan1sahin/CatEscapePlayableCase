using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu(menuName = "ScriptableFloat")]
public class LevelData : ScriptableObject
{
    [SerializeField] string levelName;
    [SerializeField] int levelIndex;
    [SerializeField] Scene levelScene;
}
