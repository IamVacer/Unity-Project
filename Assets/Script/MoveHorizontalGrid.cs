/* Controls the Horizontal Grid to allow viewing from parallax error
 * A component for "Grid Base(Y-Z)"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontalGrid : MonoBehaviour
{
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) { // if the Up key is pressed
            Debug.Log("up pressed");
            Vector3 position = this.transform.position;
            position.y ++;
            this.transform.position = position;
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) { // if the Down key is pressed
            Debug.Log("down pressed");
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}