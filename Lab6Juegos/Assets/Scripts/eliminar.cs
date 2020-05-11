using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy1"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Coin1"))
        {
            Destroy(collision.gameObject);
        }
    }
}
