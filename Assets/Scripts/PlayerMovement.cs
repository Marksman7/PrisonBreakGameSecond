using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 6.0F;
    public float Speedy = 54.0F;

    private Vector3 PlayerStart;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStart = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        PlayMoveForward();
        PlayMoveTurn();
    }


    void PlayMoveForward()
    {
        float HorizontalMovement = Input.GetAxis("Vertical") * Speed;
        HorizontalMovement *= Time.deltaTime;

        transform.Translate(0, 0, HorizontalMovement);
    }

    void PlayMoveTurn()
    {
        float VerticalMovement = Input.GetAxis("Horizontal") * Speedy;
        VerticalMovement *= Time.deltaTime;

        transform.Rotate(0, VerticalMovement, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PrisonGuard"))
        {
            this.transform.position = PlayerStart;

            if (other.gameObject.GetComponent<DetectionTypes>() != null)
            {
                other.gameObject.GetComponent<DetectionTypes>().StopFollowing();
            }
        }
    }

}
