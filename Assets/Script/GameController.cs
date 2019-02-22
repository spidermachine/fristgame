using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private float speedUp = 0f;

    private float speedHorizontal = 0f;

    public static GameController instance;

    // Start is called before the first frame update
    void Awake()
    {
       if (instance == null) {
            instance = this;
         }else if (instance != this) {
            Destroy(gameObject);
         }
    }

    // Update is called once per frame
    void Update()
    {
        speedHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        speedUp = Input.GetAxis("Vertical") * Time.deltaTime * 10;
        if (speedUp < 0) speedUp = 0f;
    }

    public float getSpeedUp() {
        return this.speedUp;
    }

    public float getSpeedHorizontal() {
        return this.speedHorizontal;
    }
}
