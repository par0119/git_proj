using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float OffsetX = -5f;
    float OffsetY = 4.5f;
    float OffsetZ = -5f;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(player.transform.position.x + OffsetX, player.transform.position.y + OffsetY, player.transform.position.z + OffsetZ);
    }
}
