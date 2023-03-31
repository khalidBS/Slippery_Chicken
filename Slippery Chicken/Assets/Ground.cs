using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground: MonoBehaviour
{
    public bool grounded;

    private void OnTriggerStay2D(Collider2D collider) {
        grounded = collider != null;
    }

    private void OnTriggerExit2D(Collider2D collision) {
        grounded = false;

    }
}
