using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] GameObject baseVFX;
    [SerializeField] GameObject trailVFX;
    public string InteractionPrompt => _prompt;
    
    public bool Interact(Interactor interactor)
    {
        Debug.Log("touchy");
        Destroy(gameObject);
        Vector3 r = Vector3.zero;
        r.x = -90;
        Vector3 pos = transform.position;
        pos.y += 1;
        GameObject disapear = Instantiate(baseVFX, pos, Quaternion.Euler(r));
        GameObject disapear2 = Instantiate(trailVFX, pos, Quaternion.Euler(r));
        return true;
    }
}
