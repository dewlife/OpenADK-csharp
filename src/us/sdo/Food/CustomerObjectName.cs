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
	/// Defines the set of values that can be specified whenever a CustomerObjectName
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a CustomerObjectName object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class CustomerObjectName : SifEnum
	{
	/// <summary>Other ("Other")</summary>
	public static readonly CustomerObjectName OTHER = new CustomerObjectName("Other");

	/// <summary>StaffPersonal ("StaffPersonal")</summary>
	public static readonly CustomerObjectName STAFFPERSONAL = new CustomerObjectName("StaffPersonal");

	/// <summary>StudentPersonal ("StudentPersonal")</summary>
	public static readonly CustomerObjectName STUDENTPERSONAL = new CustomerObjectName("StudentPersonal");

	///<summary>Wrap an arbitrary string value in a CustomerObjectName object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static CustomerObjectName Wrap( String wrappedValue ) {
		return new CustomerObjectName( wrappedValue );
	}

	private CustomerObjectName( string enumDefValue ) : base( enumDefValue ) {}
	}
}