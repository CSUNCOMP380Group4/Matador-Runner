using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject Player;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(Teleport());
        }
    }
    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0);
        Player.transform.position = new Vector2(-7.8f,-2f);
    }
}
