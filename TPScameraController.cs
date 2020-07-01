using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPScameraController : MonoBehaviour
{
    //This is the simple script to set camerafollow!!
    //--------------------------------------------------------

    //First need to create the gameobject to set the camera into.
    public Transform cameraPos; //used to save the camera position
    void Start()
    {
        transform.position = cameraPos.position;
        transform.rotation = cameraPos.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, cameraPos.position, Time.deltaTime * 3f);    //charater change position equal camera position
        transform.rotation = Quaternion.Lerp(transform.rotation, cameraPos.rotation, Time.deltaTime * 3f); //charater change rotation equal camera rotation
        //could let the camera buffer 
    }
}
