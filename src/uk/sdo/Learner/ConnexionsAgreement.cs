// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ConnexionsAgreement
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ConnexionsAgreement object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class ConnexionsAgreement : SifEnum
	{
	/// <summary>Unsought - School has not yet sent out Fair Processing Notices (Data cannot be shared with Connexions) ("UNS")</summary>
	public static readonly ConnexionsAgreement UNSOUGHT = new ConnexionsAgreement("UNS");

	/// <summary>Permission has been given by the parent or guardian ("Yes")</summary>
	public static readonly ConnexionsAgreement YES = new ConnexionsAgreement("Yes");

	/// <summary>Sought, No Reply - School has sent out Fair Processing Notices, but has received no reply from parent or guardian (Data can be shared with Connexions) ("SNR")</summary>
	public static readonly ConnexionsAgreement SOUGHT_NO_REPLY = new ConnexionsAgreement("SNR");

	/// <summary>Parent or guardian has refused permission ("No")</summary>
	public static readonly ConnexionsAgreement NO = new ConnexionsAgreement("No");

	///<summary>Wrap an arbitrary string value in a ConnexionsAgreement object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ConnexionsAgreement Wrap( String wrappedValue ) {
		return new ConnexionsAgreement( wrappedValue );
	}

	private ConnexionsAgreement( string enumDefValue ) : base( enumDefValue ) {}
	}
}
