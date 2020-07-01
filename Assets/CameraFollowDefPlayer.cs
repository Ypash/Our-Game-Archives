
using UnityEngine;

public class CameraFollowDefPlayer : MonoBehaviour
{   
    //A basic Camera Follow Script.
    public Transform meme;
    public Vector3 offset;

    void Update()
    {
     transform.position = meme.position + offset;
	}
}
