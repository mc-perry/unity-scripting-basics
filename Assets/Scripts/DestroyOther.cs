using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour
{
    public GameObject other;


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Destroy(other);
        }
    }
}
