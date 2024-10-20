using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controll : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float speed = 0.1f;
    float time;
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(new Vector3(0, speed, 0));
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 5)
        { 
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "target")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
