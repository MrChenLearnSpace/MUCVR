﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSeparate : MonoBehaviour
{
    //云端版

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        MeshRenderer meshRenderer;
        if (other.gameObject.TryGetComponent<MeshRenderer>(out meshRenderer)) {
            meshRenderer.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other) {
        MeshRenderer meshRenderer;
        if (other.gameObject.TryGetComponent<MeshRenderer>(out meshRenderer)) {
            meshRenderer.enabled = true;
        }
    }
}
