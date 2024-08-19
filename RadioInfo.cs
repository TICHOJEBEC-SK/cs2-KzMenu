using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Utils;

namespace RadioInfo
{
    public partial class RadioInfo : BasePlugin
    {
        private readonly Dictionary<CCSPlayerController, DateTime> playerLastCommandTime = new Dictionary<CCSPlayerController, DateTime>();
        public override string ModuleAuthor => "TICHOJEBEC";
        public override string ModuleName => "Radio Info";
        public override string ModuleVersion => "v1.0";

        public override void Load(bool hotReload)
        {
            RegisterEventHandler<EventPlayerSpawn>(OnPlayerSpawn);
            AddCommandListener("jointeam", OnPlayerChangeTeam);
            AddCommandListener("menu", OnPlayerCommandMenu);
        }

        private HookResult OnPlayerChangeTeam(CCSPlayerController? player, CommandInfo command)
        {
            if (player == null || !player.IsValid || player.IsBot || player.IsHLTV) return HookResult.Continue;
            player.PrintToChat($" {ChatColors.Lime}𝗖𝗦𝗞𝗢.𝗡𝗘𝗧 ● {ChatColors.Default}You can open the menu by using the radio. Or type {ChatColors.Red}radio1 {ChatColors.Default}in the console.");
            return HookResult.Continue;
        }

        private HookResult OnPlayerSpawn(EventPlayerSpawn @event, GameEventInfo info)
        {
            CCSPlayerController? player = @event.Userid;
            if (player == null || !player.IsValid || player.IsBot || player.IsHLTV) return HookResult.Continue;
            player.PrintToChat($" {ChatColors.Lime}𝗖𝗦𝗞𝗢.𝗡𝗘𝗧 ● {ChatColors.Default}You can open the menu by using the radio. Or type {ChatColors.Red}radio1 {ChatColors.Default}in the console.");
            return HookResult.Continue;
        }
        private HookResult OnPlayerCommandMenu(CCSPlayerController? player, CommandInfo command)
        {
            if (player == null || !player.IsValid || player.IsBot || player.IsHLTV) return HookResult.Continue;
            player.PrintToChat($" {ChatColors.Lime}𝗖𝗦𝗞𝗢.𝗡𝗘𝗧 ● {ChatColors.Default}You can open the menu by using the radio. Or type {ChatColors.Red}radio1 {ChatColors.Default}in the console.");
            return HookResult.Continue;
        }
    }
}
