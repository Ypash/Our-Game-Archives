using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchScript : MonoBehaviour
{   
    public Transform ThiefBot;
    public Vector3 Jail;
    public Transform JailPosition;
     void OnCollisionEnter(Collision igotcaught)
     //Teleports Thief To 'Jail' Empty Object  currently 100 on X axis .
     {
        if(igotcaught.collider.tag == "Cop")
        {
            ThiefBot.position = Jail;
            
        }
     }
}
