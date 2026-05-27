// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class kbr : ModuleRules
{
	public kbr(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"kbr",
			"kbr/Variant_Platforming",
			"kbr/Variant_Platforming/Animation",
			"kbr/Variant_Combat",
			"kbr/Variant_Combat/AI",
			"kbr/Variant_Combat/Animation",
			"kbr/Variant_Combat/Gameplay",
			"kbr/Variant_Combat/Interfaces",
			"kbr/Variant_Combat/UI",
			"kbr/Variant_SideScrolling",
			"kbr/Variant_SideScrolling/AI",
			"kbr/Variant_SideScrolling/Gameplay",
			"kbr/Variant_SideScrolling/Interfaces",
			"kbr/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
