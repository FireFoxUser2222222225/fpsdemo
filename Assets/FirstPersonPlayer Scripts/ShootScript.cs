using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject Gun;
    public GameObject Bullet;
    public float Damage=10;
    public float Speed=100f;
    public float Range=600;
    private float RangetoReach=0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
        Bullet.transform.position = Gun.transform.position;
        if (Input.GetKeyDown(KeyCode.Mouse0) == true && (RangetoReach <= Range)){
            Bullet.transform.position = new Vector3(RangetoReach * Time.deltaTime,0,0);
            RangetoReach =Speed * Time.deltaTime;
        }
    }
}
