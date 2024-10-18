using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonHead : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    float time = 0f;

    [SerializeField]
    public GameObject BulletPrefab;

    [SerializeField]
    public GameObject BulletRespawnPoint;

    [SerializeField]
    public GameObject head;

    [SerializeField]
    public GameObject barrel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float v = -Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        barrel.transform.Rotate(new Vector3(v, 0, 0));
        head.transform.Rotate(new Vector3(0, h, 0));
    }

    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (time > 0.5f)
            {
                Instantiate(BulletPrefab, BulletRespawnPoint.transform.position, BulletRespawnPoint.transform.rotation);
                time = 0;
            }

        }
    }


}
