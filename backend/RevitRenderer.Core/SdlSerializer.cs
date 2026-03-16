using System.Text;

namespace RevitRenderer.Core
{
    public static class SdlSerializer
    {
        public static void Write(Scene scene, string path)
        {
            var sb = new StringBuilder();
            sb.AppendLine("# Simple SDL export");
            foreach(var m in scene.Meshes)
            {
                sb.AppendLine($"object {m.Name} vertices {m.Vertices.Length/3} indices {m.Indices.Length/3}");
            }
            System.IO.File.WriteAllText(path, sb.ToString());
        }
    }
}