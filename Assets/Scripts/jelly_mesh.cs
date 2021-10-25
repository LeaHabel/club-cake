using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jelly_mesh : MonoBehaviour
{
    private Mesh OriginalMesh, MeshClone;
    private MeshRenderer renderer;
    
    void Start()
    {
        // init mesh, it's clone and the mesh renderer
        OriginalMesh = GetComponent<MeshFilter>().sharedMesh;
        MeshClone = Instantiate(OriginalMesh);
        GetComponent<MeshFilter>().sharedMesh = MeshClone;
        renderer = GetComponent<MeshRenderer>();
    }
    
    void Update()
    {
        
    }

    public class JellyVertex
    {
        public int ID;
        public Vector3 Position;
        public Vector3 velocity, Force;

        public JellyVertex(int _id, Vector3 _pos)
        {
            ID = _id;
            Position = _pos;
            //test
        }
    }
}
