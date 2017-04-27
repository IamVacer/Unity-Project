/* Controls the Vertical Grid to allow viewing from parallax error
 * * A component for "Grid Base(X-Z)"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVerticalGrid : MonoBehaviour {

    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { // if the Left key is pressed
            Debug.Log("up pressed");
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) { // if the Right key is pressed
            Debug.Log("down pressed");
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
    }
}