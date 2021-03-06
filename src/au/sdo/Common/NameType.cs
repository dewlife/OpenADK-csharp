// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a NameType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a NameType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class NameType : SifEnum
	{
	/// <summary>Tribal Name ("TRB")</summary>
	public static readonly NameType TRIBAL = new NameType("TRB");

	/// <summary>Preferred Name ("PRF")</summary>
	public static readonly NameType PREFERRED = new NameType("PRF");

	/// <summary>New born identification name ("NEW")</summary>
	public static readonly NameType NEW = new NameType("NEW");

	/// <summary>Also known as or alias ("AKA")</summary>
	public static readonly NameType AKA = new NameType("AKA");

	/// <summary>Stage name ("STG")</summary>
	public static readonly NameType STAGE = new NameType("STG");

	/// <summary>Maiden Name ("MDN")</summary>
	public static readonly NameType MAIDEN = new NameType("MDN");

	/// <summary>Previous name ("PRV")</summary>
	public static readonly NameType PREVIOUS = new NameType("PRV");

	/// <summary>Name at Birth ("BTH")</summary>
	public static readonly NameType BIRTH = new NameType("BTH");

	/// <summary>Non Specific Name Usage Type ("OTH")</summary>
	public static readonly NameType OTH = new NameType("OTH");

	/// <summary>Legal Name of the client as defined by the organisation which collects it (legal not defined in this standard ("LGL")</summary>
	public static readonly NameType LEGAL = new NameType("LGL");

	///<summary>Wrap an arbitrary string value in a NameType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static NameType Wrap( String wrappedValue ) {
		return new NameType( wrappedValue );
	}

	private NameType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
