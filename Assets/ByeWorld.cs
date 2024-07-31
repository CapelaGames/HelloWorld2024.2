using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeWorld : MonoBehaviour
{
    public float speed = 5f;
    private float timeElapsed = 0f;
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        timeElapsed += Time.deltaTime;

        if (timeElapsed > 5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.transform.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        } 
    }
}
