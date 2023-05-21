using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapController : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 15;
    public float tiltSmooth = 2;
    private Rigidbody2D rb;
    Quaternion downRotation;
    Quaternion forwardRotation;
    public AudioSource tapAudio;
    public AudioSource dieAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -45);
        forwardRotation = Quaternion.Euler(0, 0, 35);
    }

    void Update()
    {
            if (Input.GetMouseButtonDown(0))
            {
                if (EventSystem.current.IsPointerOverGameObject() == false)
                {
                    tapAudio.Play();
                    transform.rotation = forwardRotation;
                    rb.velocity = Vector2.up * velocity;
                }
            }
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);

    }

  void OnCollisionEnter2D(Collision2D collision)
    {
        dieAudio.Play();
        gameManager.GameOver();
    }
}
