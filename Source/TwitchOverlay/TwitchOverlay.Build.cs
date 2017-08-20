// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class TwitchOverlay : ModuleRules
{
	public TwitchOverlay(ReadOnlyTargetRules Target) : base(Target)
    {
        bEnforceIWYU = true;

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore"
        });

        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "Slate",
            "SlateCore",
            "UMG"
        });
	}
}
