using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstProject1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    public GameObject sphere;
    [SerializeField] float speed = 3.0f;
    private float myAxis=1;
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        //cube.transform.Rotate(new Vector3(speed*Time.deltaTime, 0, 0));
        myAxis++ ;
        //cube.transform.eulerAngles = new Vector3(cube.transform.eulerAngles.x+myAxis, 0, 0);
        //cube.transform.position = new Vector3(myAxis++, 0, 0);
        //Debug.Log(sphere.transform.localPosition);
        cube.transform.position = Vector3.MoveTowards(cube.transform.position, sphere.transform.position, 0.02f);
        /*if (cube.transform.position == sphere.transform.position) {
            sphere.GetComponent<Renderer>().material.color = Color.blue;
        }*/
    }
   
    private void FixedUpdate()
    {
        
    }

}
