using UnityEngine;

public class MovementsForPlayer : MonoBehaviour
{   
    //All Variables
    public Transform player;
    public Rigidbody man;
    public float SideForce = 200f;
    public string LeftKey = "a";
    public float FrontForce = 2000f;
    public string FrontKey = "w";
    public string RightKey = "d";
    public string DownKey = "s";
    

    // Update is called once per frame
    void Update()
    {   
        //Controls
        if(Input.GetKey(LeftKey))
        {
            man.AddForce(-2000*Time.deltaTime,0,0);
		}

        if(Input.GetKey(DownKey))
        {
            man.AddForce(0,0,-FrontForce*Time.deltaTime);
		}

        if(Input.GetKey(FrontKey))
        {
            man.AddForce(0,0,FrontForce*Time.deltaTime);
		}

        if(Input.GetKey(RightKey))
        {
            man.AddForce(2000*Time.deltaTime,0,0);
            Debug.Log(player.position.x);
		}
    }
}
