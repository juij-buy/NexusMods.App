using JetBrains.Annotations;
using NexusMods.Abstractions.GameLocators;
using NexusMods.Abstractions.MnemonicDB.Attributes;
using NexusMods.Hashing.xxHash64;
using NexusMods.MnemonicDB.Abstractions;
using NexusMods.MnemonicDB.Abstractions.Models;
using NexusMods.Paths;

namespace NexusMods.Abstractions.Loadouts;

/// <summary>
/// Represents a file in a Loadout.
/// </summary>
[Include<LoadoutItemWithTargetPath>]
[PublicAPI]
public partial class LoadoutFile : IModelDefinition
{
    private const string Namespace = "NexusMods.Loadouts.LoadoutFile";

    /// <summary>
    /// Hash of the file.
    /// </summary>
    public static readonly HashAttribute Hash = new(Namespace, nameof(Hash)) { IsIndexed = true };

    /// <summary>
    /// Size of the file.
    /// </summary>
    public static readonly SizeAttribute Size = new(Namespace, nameof(Size));

    public partial struct ReadOnly : IHavePathHashSizeAndReference
    {

#region IHavePathHashSizeAndReference

        GamePath IHavePathHashSizeAndReference.Path => LoadoutItemWithTargetPath.TargetPath.Get(this);

        Hash IHavePathHashSizeAndReference.Hash => LoadoutFile.Hash.Get(this);

        Size IHavePathHashSizeAndReference.Size => LoadoutFile.Size.Get(this);
        EntityId IHavePathHashSizeAndReference.Reference => Id;

#endregion
    }

}
