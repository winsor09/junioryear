using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SHIP : MonoBehaviour
{

    float timeLeft = 0f;
    public GameObject enemy;
    public GameObject bullet;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        int speed = 10;
        Vector3 velocity = new Vector3(0, 0, 0);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();


        if (Input.GetKey(KeyCode.A) && transform.position.x >= -8.51)
            transform.position += Vector3.left * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D) && transform.position.x <= 8.51)
            transform.position += Vector3.right * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W) && transform.position.y <= 4.65)
            transform.position += Vector3.up * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S) && transform.position.y >= -4.65)
            transform.position += Vector3.down * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(bullet, transform.position, Quaternion.identity);

            obj.GetComponent<Rigidbody2D>().velocity = Vector3.up * 13;

        }

        timeLeft += Time.deltaTime;
        if (timeLeft >= 3f)
        {

            Vector2 spawn = new Vector2(Random.Range(-8.51f, 8.51f), 5.17f);

            GameObject obj = Instantiate(enemy, spawn, Quaternion.identity);

            obj.GetComponent<Rigidbody2D>().velocity = Vector3.down * 8;

            timeLeft = 0f;

        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ENEMY")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}

