using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    private bool isPinned = false;

    [SerializeField] private float speed = 20f;
    [SerializeField] private Rigidbody2D rb;

    private GameManager gameManager;

    private void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            ScoreManager.PinCount++;
            isPinned = true;
        }
        else if (collision.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
            //Debug.Log("End Game");
        }
    }
}
