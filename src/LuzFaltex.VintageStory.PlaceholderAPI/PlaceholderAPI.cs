using Vintagestory.API.Common;

[assembly: ModInfo("LuzFaltex.VintageStory.PlaceholderAPI",
                    Authors = new string[] { "Unknown" },
                    Description = "This is a sample mod",
                    Version = "1.0.0")]

namespace LuzFaltex.VintageStory.PlaceholderAPI
{
    /// <summary>
    /// A recreation of the PlaceholderAPI plugin from Minecraft.
    /// </summary>
    /// <seealso href="https://github.com/PlaceholderAPI/PlaceholderAPI"/>
    public class PlaceholderAPI : ModSystem
    {
        public PlaceholderLib PlaceholderLib { get; }

        public PlaceholderAPI()
        {
            PlaceholderLib = new PlaceholderLib();
        }
    }
}
