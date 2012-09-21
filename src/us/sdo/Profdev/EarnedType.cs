// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Profdev
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EarnedType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EarnedType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class EarnedType : SifEnum
	{
	/// <summary>Credits ("Credits")</summary>
	public static readonly EarnedType CREDITS = new EarnedType("Credits");

	/// <summary>Hours ("Hours")</summary>
	public static readonly EarnedType HOURS = new EarnedType("Hours");

	///<summary>Wrap an arbitrary string value in an EarnedType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EarnedType Wrap( String wrappedValue ) {
		return new EarnedType( wrappedValue );
	}

	private EarnedType( string enumDefValue ) : base( enumDefValue ) {}
	}
}