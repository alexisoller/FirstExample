using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sphere : MonoBehaviour {
    // Start is called before the first frame update

    public float speed;
    private float mov = 0;
    private bool izDer = false;
    void Start() {


    }

    // Update is called once per frame
    void Update() {

        transform.Translate(mov*speed*Time.deltaTime, 0,0);

        float x = transform.position.x;

        if (!izDer) {
            mov = 1;
            if (x > 40) {
                izDer = true;
            }
        } else {
            mov = -1;
            if (x < 0) {
                izDer = false;
            }
        }
        Debug.Log(x);
        Debug.Log(izDer);


    }
}
