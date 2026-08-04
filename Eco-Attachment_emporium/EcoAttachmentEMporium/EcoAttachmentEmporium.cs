using System.Reflection;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Mod;
using WTTServerCommonLib.Models;
using Range = SemanticVersioning.Range;
using EcoAttachmentEmporium.Helpers;

namespace EcoAttachmentEmporium;

public record ModMetadata : IModMetadata
{
    public string ModGuid { get; init; } = "com.wtt.ecoattachmentemporium";
    public string Name { get; init; } = "Eco-Attachment-Emporium";
    public string Author { get; init; } = "Eco";
    public List<string>? Contributors { get; init; } = null;
    public SemanticVersioning.Version Version { get; init; } = new(typeof(ModMetadata).Assembly.GetName().Version?.ToString(3));
    public Range SptVersion { get; init; } = new("~4.1.1");
    public List<string>? Incompatibilities { get; init; }
    public Dictionary<string, Range>? ModDependencies { get; init; } = new()
    {
        { "com.wtt.commonlib", new Range("~3.0.3") }
    };
    public string? Url { get; init; }
    public bool HasPrepatcher { get; init; } = false;
    public string License { get; init; } = "MIT";
}


[Injectable(TypePriority = OnLoadOrder.Preload + 2)]
public class DoomArcadeServer(
    WTTServerCommonLib.WTTServerCommonLib wttCommon,
    EcoQuestHelper ecoQuestHelper) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly);
        await wttCommon.CustomBotLoadoutService.CreateCustomBotLoadouts(assembly);
        await wttCommon.CustomAssortSchemeService.CreateCustomAssortSchemes(assembly);
        ecoQuestHelper.ModifyQuests();
    }
}
