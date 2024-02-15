using Robust.Shared.Prototypes;

namespace Content.Server._Pirate.SpecialForces;

[RegisterComponent]
public sealed partial class SpecialForceComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("actionBssActionName")]
    public string? ActionBssActionName { get; private set; }

    /// <summary>
    /// A dictionary mapping the component type list to the YAML mapping containing their settings.
    /// </summary>

    [DataField("components")]
    [AlwaysPushInheritance]
    public ComponentRegistry Components { get; private set; } = new();

    public EntityUid? BssKey = null;
}