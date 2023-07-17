using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 step = new Vector3(hor, ver, 0);

        animator.SetFloat("Horizontal", hor);
        animator.SetFloat("Vertical", ver);
        animator.SetFloat("Speed", (hor * hor + ver * ver));

        transform.position += step * moveSpeed * Time.deltaTime;



    }
}
