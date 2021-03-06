// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Catering
{
	///<summary>
	/// Defines the set of values that can be specified whenever a Day
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a Day object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class Day : SifEnum
	{
	/// <summary>Sun ("Sun")</summary>
	public static readonly Day SUN = new Day("Sun");

	/// <summary>All ("All")</summary>
	public static readonly Day ALL = new Day("All");

	/// <summary>Mon ("Mon")</summary>
	public static readonly Day MON = new Day("Mon");

	/// <summary>Tue ("Tue")</summary>
	public static readonly Day TUE = new Day("Tue");

	/// <summary>Wed ("Wed")</summary>
	public static readonly Day WED = new Day("Wed");

	/// <summary>Fri ("Fri")</summary>
	public static readonly Day FRI = new Day("Fri");

	/// <summary>Thu ("Thu")</summary>
	public static readonly Day THU = new Day("Thu");

	/// <summary>Sat ("Sat")</summary>
	public static readonly Day SAT = new Day("Sat");

	///<summary>Wrap an arbitrary string value in a Day object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static Day Wrap( String wrappedValue ) {
		return new Day( wrappedValue );
	}

	private Day( string enumDefValue ) : base( enumDefValue ) {}
	}
}
