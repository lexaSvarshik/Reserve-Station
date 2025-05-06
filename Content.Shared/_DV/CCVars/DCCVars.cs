using Robust.Shared.Configuration;

namespace Content.Shared._DV.CCVars;

/// <summary>
/// DeltaV specific cvars.
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming - Shush you
public sealed class DCCVars
{
    /* Laying down combat */

    /// <summary>
    /// Modifier to apply to all melee attacks when laying down.
    /// Don't increase this above 1...
    /// </summary>
    public static readonly CVarDef<float> LayingDownMeleeMod =
        CVarDef.Create("game.laying_down_melee_mod", 0.25f, CVar.REPLICATED);
}
