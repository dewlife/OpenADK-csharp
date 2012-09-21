// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Hrfin
{
	///<summary>
	/// Defines the set of values that can be specified whenever a FTAmountType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FTAmountType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class FTAmountType : SifEnum
	{
	/// <summary>Credit ("Credit")</summary>
	public static readonly FTAmountType CREDIT = new FTAmountType("Credit");

	/// <summary>Debit ("Debit")</summary>
	public static readonly FTAmountType DEBIT = new FTAmountType("Debit");

	///<summary>Wrap an arbitrary string value in a FTAmountType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FTAmountType Wrap( String wrappedValue ) {
		return new FTAmountType( wrappedValue );
	}

	private FTAmountType( string enumDefValue ) : base( enumDefValue ) {}
	}
}