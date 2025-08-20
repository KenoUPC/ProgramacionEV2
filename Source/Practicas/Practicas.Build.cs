// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Practicas : ModuleRules
{
	public Practicas(ReadOnlyTargetRules Target) : base(Target)
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
			"Practicas",
			"Practicas/Variant_Platforming",
			"Practicas/Variant_Platforming/Animation",
			"Practicas/Variant_Combat",
			"Practicas/Variant_Combat/AI",
			"Practicas/Variant_Combat/Animation",
			"Practicas/Variant_Combat/Gameplay",
			"Practicas/Variant_Combat/Interfaces",
			"Practicas/Variant_Combat/UI",
			"Practicas/Variant_SideScrolling",
			"Practicas/Variant_SideScrolling/AI",
			"Practicas/Variant_SideScrolling/Gameplay",
			"Practicas/Variant_SideScrolling/Interfaces",
			"Practicas/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
