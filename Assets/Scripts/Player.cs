using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
    void handleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
            transform.position = transform.position + movement*0.1f;
        }
    }
    void Update()
    {
        handleMovement();
    }
}
