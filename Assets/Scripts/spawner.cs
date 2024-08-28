using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]GameObject tunel;
    private int spwanRate=3;
    private float time=0;
    private float offset=1.3f;
    private Bird bird;
    // Start is called before the first frame update
    void Start()
    {   
        bird=GameObject.FindGameObjectWithTag("Player").GetComponent<Bird>();
        spawnTunel();
    }

    // Update is called once per frame
    void Update()
    {   
        if(bird.isAlive){
            if(time<spwanRate){
                time+=Time.deltaTime;
            }
            else{
                spawnTunel();
                time=0;
        }
        }
        
    }

    void spawnTunel(){  
        float lowerLimit=transform.position.y-offset;
        float upperLimit=transform.position.y+offset;
        Instantiate(tunel,new Vector3(transform.position.x,
                            Random.Range(lowerLimit,upperLimit),0),transform.rotation);
    }
}
