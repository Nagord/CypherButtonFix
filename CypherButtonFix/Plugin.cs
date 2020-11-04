using PulsarPluginLoader;

namespace CypherButtonFix
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0.0";

        public override string Author => "Dragon, Engbot";

        public override string LongDescription => "text";

        public override string Name => "CypherButtonFix";

        public override string HarmonyIdentifier()
        {
            return "Dragon.CypherButtonFix";
        }
    }
}
