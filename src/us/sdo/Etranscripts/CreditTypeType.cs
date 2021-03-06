// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Etranscripts
{
	///<summary>
	/// Defines the set of values that can be specified whenever a CreditTypeType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a CreditTypeType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class CreditTypeType : SifEnum
	{
	/// <summary>Trimester hour credit ("0587")</summary>
	public static readonly CreditTypeType TRIMESTER_HOUR = new CreditTypeType("0587");

	/// <summary>Quinmester hour credit ("0589")</summary>
	public static readonly CreditTypeType QUINMESTER_HOUR = new CreditTypeType("0589");

	/// <summary>Quarter hour credit ("0588")</summary>
	public static readonly CreditTypeType QUARTER_HOUR = new CreditTypeType("0588");

	/// <summary>Intersession hour credit ("0592")</summary>
	public static readonly CreditTypeType INTERSESSION_HOUR = new CreditTypeType("0592");

	/// <summary>Other ("9999")</summary>
	public static readonly CreditTypeType OTHER = new CreditTypeType("9999");

	/// <summary>Twelve month hour credit ("0596")</summary>
	public static readonly CreditTypeType TWELVE_MONTH_HOUR = new CreditTypeType("0596");

	/// <summary>Summer term hour credit ("0591")</summary>
	public static readonly CreditTypeType SUMMER_TERM_HOUR = new CreditTypeType("0591");

	/// <summary>Credit by examination ("0599")</summary>
	public static readonly CreditTypeType EXAMINATION = new CreditTypeType("0599");

	/// <summary>Vocation credit ("0597")</summary>
	public static readonly CreditTypeType VOCATION = new CreditTypeType("0597");

	/// <summary>Mini-term hour credit ("0590")</summary>
	public static readonly CreditTypeType MINITERM_HOUR = new CreditTypeType("0590");

	/// <summary>Semester hour credit ("0586")</summary>
	public static readonly CreditTypeType SEMESTER_HOUR = new CreditTypeType("0586");

	/// <summary>Long session hour credit ("0595")</summary>
	public static readonly CreditTypeType LONG_SESSION_HOUR = new CreditTypeType("0595");

	/// <summary>Carnegie unit ("0585")</summary>
	public static readonly CreditTypeType CARNEGIE = new CreditTypeType("0585");

	/// <summary>None ("9998")</summary>
	public static readonly CreditTypeType NONE = new CreditTypeType("9998");

	/// <summary>Converted occupational experience credit ("0601")</summary>
	public static readonly CreditTypeType CONVERTED_OCCUPATIONAL_EXPERIENCE = new CreditTypeType("0601");

	/// <summary>Adult education credit ("0598")</summary>
	public static readonly CreditTypeType ADULT_EDUCATION = new CreditTypeType("0598");

	/// <summary>Correspondence credit ("0600")</summary>
	public static readonly CreditTypeType CORRESPONDENCE = new CreditTypeType("0600");

	///<summary>Wrap an arbitrary string value in a CreditTypeType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static CreditTypeType Wrap( String wrappedValue ) {
		return new CreditTypeType( wrappedValue );
	}

	private CreditTypeType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
