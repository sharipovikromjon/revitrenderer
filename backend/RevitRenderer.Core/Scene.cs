using System.Numerics;
using System.Collections.Generic;

namespace RevitRenderer.Core
{
    public class Scene
    {
        public List<Mesh> Meshes { get; set; } = new();
        public List<Material> Materials { get; set; } = new();
        public Camera Camera { get; set; } = new Camera();
    }

    public class Mesh
    {
        public string Name { get; set; }
        public float[] Vertices { get; set; }
        public int[] Indices { get; set; }
        public string MaterialName { get; set; }
    }

    public class Material { public string Name { get; set; } }

    public class Camera { public Vector3 Position { get; set; } }
}