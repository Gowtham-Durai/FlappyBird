using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveSpeed=2f;
    private float deathZone=-8.51f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(transform.position.x<deathZone)
            Destroy(gameObject);
            
        transform.position+=(Vector3.left*moveSpeed)*Time.deltaTime;
    }
}
