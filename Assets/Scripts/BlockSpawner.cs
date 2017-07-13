using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject block;
    [SerializeField] private float numOfBlocks;
    [SerializeField] private float spawnStep;

    [SerializeField] private float xMinPosLim;
    [SerializeField] private float xMaxPosLim;

    [SerializeField] private float yMinPosLim;
    [SerializeField] private float yMaxPosLim;

    [SerializeField] private float ScaleMin;
    [SerializeField] private float ScaleMax;

    private float lastPosPlayer;

    private void Start()
    {
        //float startPosZPlayer = player.transform.position.z;

        //for (int i = 1; i <= numOfBlocks; i++)
        //{
        //    GameObject bl = Instantiate(
        //        block,
        //        new Vector3(Random.Range(xMinPosLim, xMaxPosLim), Random.Range(yMinPosLim, yMaxPosLim), startPosZPlayer + spawnStep * i),
        //        Quaternion.identity, gameObject.transform) as GameObject;
        //    bl.transform.localScale = new Vector3(Random.Range(ScaleMin, ScaleMax), Random.Range(ScaleMin, ScaleMax), 1f);
        //}
    }
}
