using LuzFaltex.VintageStore.CoreLib.Providers;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo("LuzFaltex.VintageStore.CoreLib",
                    Authors = new string[] { "Unknown" },
                    Description = "This is a sample mod",
                    Version = "1.0.0")]

namespace LuzFaltex.VintageStore.CoreLib
{
    /// <summary>
    /// Describes the <see cref="LuzFaltex.VintageStore.CoreLib"/> <see cref="ModSystem"/>.
    /// </summary>
    public class CoreLib : ModSystem
    {
        /// <summary>
        /// Gets the provider library for this runtime instance.
        /// </summary>
        public ProviderLibrary ProviderLibrary { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreLib"/> class.
        /// </summary>
        public CoreLib()
        {
            ProviderLibrary = new ProviderLibrary();
        }

        public override void Start(ICoreAPI api)
        {
            api.ModLoader.GetModSystem("LuzFaltex.Vin")
        }
    }
}
