// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learning
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ScopeStatus
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ScopeStatus object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class ScopeStatus : SifEnum
	{
	/// <summary>End of transfer. ("ET")</summary>
	public static readonly ScopeStatus ET_END_OF_TRANSFER = new ScopeStatus("ET");

	/// <summary>Beginning of transfer. ("BT")</summary>
	public static readonly ScopeStatus BT_BEGINNING_OF_TRANSFER = new ScopeStatus("BT");

	/// <summary>Unsuccessful import. ("UI")</summary>
	public static readonly ScopeStatus UI_UNSUCCESSFUL_IMPORT = new ScopeStatus("UI");

	/// <summary>Received but import pending. ("RP")</summary>
	public static readonly ScopeStatus RP_RECEIVED_BUT_IMPORT = new ScopeStatus("RP");

	/// <summary>Successful import. ("SI")</summary>
	public static readonly ScopeStatus SI_SUCCESSFUL_IMPORT = new ScopeStatus("SI");

	///<summary>Wrap an arbitrary string value in a ScopeStatus object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ScopeStatus Wrap( String wrappedValue ) {
		return new ScopeStatus( wrappedValue );
	}

	private ScopeStatus( string enumDefValue ) : base( enumDefValue ) {}
	}
}
