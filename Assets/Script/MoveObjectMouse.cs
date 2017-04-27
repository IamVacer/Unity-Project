/* This script allows the points of the data to be manipulated by users
 * To be used as a component for "Cubeprefab"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectMouse : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown() {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag() {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
