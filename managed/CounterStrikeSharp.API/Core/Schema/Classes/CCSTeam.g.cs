// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CCSTeam : CTeam
{
    public CCSTeam (IntPtr pointer) : base(pointer) {}

	// m_nLastRecievedShorthandedRoundBonus
	[SchemaMember("CCSTeam", "m_nLastRecievedShorthandedRoundBonus")]
	public ref Int32 LastRecievedShorthandedRoundBonus => ref Schema.GetRef<Int32>(this.Handle, "CCSTeam", "m_nLastRecievedShorthandedRoundBonus");

	// m_nShorthandedRoundBonusStartRound
	[SchemaMember("CCSTeam", "m_nShorthandedRoundBonusStartRound")]
	public ref Int32 ShorthandedRoundBonusStartRound => ref Schema.GetRef<Int32>(this.Handle, "CCSTeam", "m_nShorthandedRoundBonusStartRound");

	// m_bSurrendered
	[SchemaMember("CCSTeam", "m_bSurrendered")]
	public ref bool Surrendered => ref Schema.GetRef<bool>(this.Handle, "CCSTeam", "m_bSurrendered");

	// m_szTeamMatchStat
	[SchemaMember("CCSTeam", "m_szTeamMatchStat")]
	public string TeamMatchStat
	{
		get { return Schema.GetString(this.Handle, "CCSTeam", "m_szTeamMatchStat"); }
		set { Schema.SetStringBytes(this.Handle, "CCSTeam", "m_szTeamMatchStat", value, 512); }
	}

	// m_numMapVictories
	[SchemaMember("CCSTeam", "m_numMapVictories")]
	public ref Int32 NumMapVictories => ref Schema.GetRef<Int32>(this.Handle, "CCSTeam", "m_numMapVictories");

	// m_scoreFirstHalf
	[SchemaMember("CCSTeam", "m_scoreFirstHalf")]
	public ref Int32 ScoreFirstHalf => ref Schema.GetRef<Int32>(this.Handle, "CCSTeam", "m_scoreFirstHalf");

	// m_scoreSecondHalf
	[SchemaMember("CCSTeam", "m_scoreSecondHalf")]
	public ref Int32 ScoreSecondHalf => ref Schema.GetRef<Int32>(this.Handle, "CCSTeam", "m_scoreSecondHalf");

	// m_scoreOvertime
	[SchemaMember("CCSTeam", "m_scoreOvertime")]
	public ref Int32 ScoreOvertime => ref Schema.GetRef<Int32>(this.Handle, "CCSTeam", "m_scoreOvertime");

	// m_szClanTeamname
	[SchemaMember("CCSTeam", "m_szClanTeamname")]
	public string ClanTeamname
	{
		get { return Schema.GetString(this.Handle, "CCSTeam", "m_szClanTeamname"); }
		set { Schema.SetStringBytes(this.Handle, "CCSTeam", "m_szClanTeamname", value, 129); }
	}

	// m_iClanID
	[SchemaMember("CCSTeam", "m_iClanID")]
	public ref UInt32 ClanID => ref Schema.GetRef<UInt32>(this.Handle, "CCSTeam", "m_iClanID");

	// m_szTeamFlagImage
	[SchemaMember("CCSTeam", "m_szTeamFlagImage")]
	public string TeamFlagImage
	{
		get { return Schema.GetString(this.Handle, "CCSTeam", "m_szTeamFlagImage"); }
		set { Schema.SetStringBytes(this.Handle, "CCSTeam", "m_szTeamFlagImage", value, 8); }
	}

	// m_szTeamLogoImage
	[SchemaMember("CCSTeam", "m_szTeamLogoImage")]
	public string TeamLogoImage
	{
		get { return Schema.GetString(this.Handle, "CCSTeam", "m_szTeamLogoImage"); }
		set { Schema.SetStringBytes(this.Handle, "CCSTeam", "m_szTeamLogoImage", value, 8); }
	}

	// m_flNextResourceTime
	[SchemaMember("CCSTeam", "m_flNextResourceTime")]
	public ref float NextResourceTime => ref Schema.GetRef<float>(this.Handle, "CCSTeam", "m_flNextResourceTime");

	// m_iLastUpdateSentAt
	[SchemaMember("CCSTeam", "m_iLastUpdateSentAt")]
	public ref Int32 LastUpdateSentAt => ref Schema.GetRef<Int32>(this.Handle, "CCSTeam", "m_iLastUpdateSentAt");

}