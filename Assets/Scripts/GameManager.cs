using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Rigidbody m_ball;
    [SerializeField] private float explosionRadius = 9.0f;
    [SerializeField] private float explosionForce;
    [SerializeField] private float explosionUpwardsModifier = 1.0f; //what does this do?



    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(5760, 1080, true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            var newRandomVector = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
            var forceStrength = Vector3.Normalize(newRandomVector) * explosionForce;
            m_ball.AddForce(forceStrength, ForceMode.Impulse);
            Debug.Log("nope");
        }
    }




    //// Adding a impulse force to the cannonball
    //    m_cannonBallRigidBody.AddForce(m_fireForce, ForceMode.Impulse);

    //    //Adding an angular velocity to the cannon ball, lets make it rotate. 
    //    m_cannonBallRigidBody.angularVelocity = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
}
