using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class MoveAnimal : MonoBehaviour
{
    public float vitesse = 3f;  // Vitesse de d�placement de l'animal
    public float rayonDetection = 5f;  // Rayon de d�tection des obstacles
    public LayerMask obstaclesLayer;  // Couche de collision des obstacles

    private Vector3 destination;  // Destination vers laquelle se d�placer

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * vitesse;
    }

    private void Update()
    {
        
    }

   

    private void SetRandomDestination()
    {
        return;
    }

    private void MoveTowardsDestination(Vector3 destination)
    {
        return;
    }
}