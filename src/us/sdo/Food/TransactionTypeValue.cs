// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Food
{
	///<summary>
	/// Defines the set of values that can be specified whenever a TransactionTypeValue
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a TransactionTypeValue object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class TransactionTypeValue : SifEnum
	{
	/// <summary>Repayment ("Repayment")</summary>
	public static readonly TransactionTypeValue REPAYMENT = new TransactionTypeValue("Repayment");

	/// <summary>Prepayment ("Prepayment")</summary>
	public static readonly TransactionTypeValue PREPAYMENT = new TransactionTypeValue("Prepayment");

	/// <summary>Refund ("Refund")</summary>
	public static readonly TransactionTypeValue REFUND = new TransactionTypeValue("Refund");

	/// <summary>Adjustment ("Adjustment")</summary>
	public static readonly TransactionTypeValue ADJUSTMENT = new TransactionTypeValue("Adjustment");

	/// <summary>Purchase ("Purchase")</summary>
	public static readonly TransactionTypeValue PURCHASE = new TransactionTypeValue("Purchase");

	///<summary>Wrap an arbitrary string value in a TransactionTypeValue object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static TransactionTypeValue Wrap( String wrappedValue ) {
		return new TransactionTypeValue( wrappedValue );
	}

	private TransactionTypeValue( string enumDefValue ) : base( enumDefValue ) {}
	}
}