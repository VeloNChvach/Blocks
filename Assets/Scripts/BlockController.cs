using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    //[SerializeField] private GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Time.timeScale = 0;
        //Destroy(collision.gameObject);
    }

    //private void FixedUpdate()
    //{
    //    if (transform.position.z > player.transform.position.z)
    //        return;
    //    Destroy(gameObject, 1f);
    //}

}
