using UnityEngine;

public class BunnyAge : MonoBehaviour
{
    public float minSpeed= 0.3f;  
    private Bunny bunny;
    private float baseSpeed;

    void Start()
    {
        bunny = GetComponent<Bunny>();
        baseSpeed = bunny.speed;
    }

    public void envejecimiento()
    {
        bunny.speed = Mathf.Lerp(baseSpeed, baseSpeed * minSpeed, bunny.age / bunny.maxAge); //la ia me ayudo a sacar esta operancion 

    }
}



