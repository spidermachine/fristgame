using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{

    private Rigidbody2D rd2d;
    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        rd2d.velocity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        rd2d.velocity = Vector2.down * GameController.instance.getSpeedUp() * 10; 
    }
}
