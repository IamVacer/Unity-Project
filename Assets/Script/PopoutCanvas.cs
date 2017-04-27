/*
 * This script allows "Canvas: Main Help" to be disabled with the press of the ESC key
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PopoutCanvas : MonoBehaviour
{
    public Canvas CanvasView;    // now you have to drag and drop your canvas in the editor in the script component
    private bool viewActive = true; //To display the canvas (true) or not (false)

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) { // if you press the Esc key
            viewActive = !viewActive; // change the state of your bool
            CanvasView.enabled = viewActive; // display or not the canvas (following the state of the bool)
        }
    }
}