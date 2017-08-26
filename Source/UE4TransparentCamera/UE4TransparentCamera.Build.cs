// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class UE4TransparentCamera : ModuleRules
{
	public UE4TransparentCamera(ReadOnlyTargetRules Target) : base(Target)
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
