using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mesh : MonoBehaviour
{
    [ContextMenu("Convert to regular mesh")]
    void Convert()
        {
            SkinnedMeshRenderer skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
            MeshFilter filter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
            filter.mesh = skinnedMeshRenderer.sharedMesh;
            renderer.sharedMaterials = skinnedMeshRenderer.sharedMaterials;
            DestroyImmediate(skinnedMeshRenderer);
            DestroyImmediate(this);
        }
    

}