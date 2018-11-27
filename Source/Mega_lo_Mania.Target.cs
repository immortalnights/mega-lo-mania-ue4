// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Mega_lo_ManiaTarget : TargetRules
{
	public Mega_lo_ManiaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Mega_lo_Mania" } );
	}
}
