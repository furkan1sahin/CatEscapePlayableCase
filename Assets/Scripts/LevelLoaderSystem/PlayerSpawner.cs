using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] bool isSpawnPosOnLevel = true;
    [SerializeField] Vector3 spawnPos = new Vector3();
    public void SpawnPlayer()
    {
        if (isSpawnPosOnLevel) FindSpawnPos();
        Instantiate(playerPrefab, spawnPos, Quaternion.identity);
    }

    void FindSpawnPos()
    {
        var spawnPoint = FindObjectOfType<PlayerSpawnPoint>();
        if (spawnPoint == null)
        {
            Debug.Log("Spawn Point Cannot Be Found!");
            return;
        }
        spawnPos = spawnPoint.transform.position;
    }


}
