using UnityEngine;
using System.Collections;

public class MoveToLocation : MonoBehaviour
{

    public void MoveLocation(GameObject targetLocation)
    {
        // move THIS to the in game location of target
        this.transform.position = targetLocation.transform.position;
    }
}
