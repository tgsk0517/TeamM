using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField]
    private GameObject clikedObject;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clikedObject = null;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                if (hit2d.transform.gameObject.tag == "tower")
                {
                    clikedObject = hit2d.transform.gameObject;
                    clikedObject.GetComponent<tower>().isMoved = true;
                }
            }
        }
        if (Input.GetMouseButtonUp(0) && clikedObject)
        {
            clikedObject.GetComponent<tower>().isMoved = false;
            clikedObject.GetComponent<tower>().isClone = true;
            clikedObject.GetComponent<tower>().ChangePos();
            clikedObject = null;
        }
    }

}
