using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed =8f;
    public GameObject gameObj;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        playerRigidbody.velocity = new Vector3(xInput*speed,0f , zInput*speed);
    }

    public void Die()
    {
        this.gameObject.SetActive(false);
    }
}
