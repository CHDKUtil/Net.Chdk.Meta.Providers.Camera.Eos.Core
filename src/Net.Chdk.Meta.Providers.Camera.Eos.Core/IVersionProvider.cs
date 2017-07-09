using Net.Chdk.Meta.Model.Camera.Eos;
using Net.Chdk.Meta.Model.CameraList;
using Net.Chdk.Meta.Model.CameraTree;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    public interface IVersionProvider
    {
        VersionData GetVersion(string version, TreeRevisionData treeRevision, ListPlatformData list, TreePlatformData tree);
    }
}
