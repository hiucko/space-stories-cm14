using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;
using Robust.Shared.Prototypes;

namespace Content.Shared._RMC14.Dropship.Fabricator;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, AutoGenerateComponentPause]
[Access(typeof(DropshipFabricatorSystem))]
public sealed partial class DropshipFabricatorPointsComponent : Component
{
    [DataField, AutoNetworkedField]
    public int Points;

    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer)), AutoNetworkedField, AutoPausedField]
    public TimeSpan NextPointsAt;

    [DataField, AutoNetworkedField]
    public Dictionary<EntProtoId, int> Purchases = new();
}
