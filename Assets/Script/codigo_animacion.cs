using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class codigo_animacion : MonoBehaviour
{
    public float velocidadMovimiento = 0.5f;
    public float velocidadRotacion = 200.0f;
    public Animator animator;
    public float x,y;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0,x * Time.deltaTime*velocidadRotacion,0);
        transform.Translate(0, 0, y*Time.deltaTime*velocidadMovimiento);
    }
}
