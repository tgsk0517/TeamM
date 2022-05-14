using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    public GameObject towerPrefab;
    [HideInInspector]
    public bool isMoved =false;
    [HideInInspector]
    public bool isClone = false;
    //[HideInInspector]
    public Vector3 pos;
    private Vector3 worldPosition;
    private int possibleNum = 3;

    private void Start()
    {
        pos = transform.position;
    }

    private void Update()
    {
        if(isMoved)
        {
            OnMouseDrag();
        }
        if(isClone)
        {
            GameObject instance = (GameObject)Instantiate(towerPrefab, worldPosition, Quaternion.identity);
            isClone = false;
        }
    }

    private void OnMouseEnter()
    {
        if (possibleNum > 0)
        {
            possibleNum--;
        }
    }
    private void OnMouseDrag()
    {
        Vector3 thisPosition = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(thisPosition);
        worldPosition.z = 0f;
        this.transform.position = worldPosition;
    }
    public void ChangePos()
    {
        transform.position = pos;
    }
}
