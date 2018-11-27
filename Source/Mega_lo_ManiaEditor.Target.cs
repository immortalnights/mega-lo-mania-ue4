// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Mega_lo_ManiaEditorTarget : TargetRules
{
	public Mega_lo_ManiaEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Mega_lo_Mania" } );
	}
}
