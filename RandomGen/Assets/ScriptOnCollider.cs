using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOnCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
    }
}
