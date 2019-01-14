using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject gameObject;

    // Start is called before the first frame update

    private void OnTriggerStay2D(BoxCollider2D collision)
    {
        if (collision.tag == "PlayerCheck")
        {
            DestroyImmediate(gameObject);
        }

    }
}
