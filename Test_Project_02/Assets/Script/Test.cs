using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public  int     a  =  1;
    public  float   b  =  2.1f;
    public  string  c  =  "Hellow World";
    public  bool    d  =  true;
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.SetActive(false)
        this.gameObject.GetComponent<Transform>().position = new Vector3(1f, 0f, 0f);
        this.gameObject.GetComponent<SpriteRenderer>() .color = Color.red;
        //this.gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0f, 0f, 45f);
    }
    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Transform>().position += new Vector3(0.01f, 0f, 0f);
    }
}