// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.Infra
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EncryptionLevel
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EncryptionLevel object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class EncryptionLevel : SifEnum
	{
	/// <summary>Symmetric key length of at least 56 bits is to be used ("2")</summary>
	public static readonly EncryptionLevel TWO = new EncryptionLevel("2");

	/// <summary>No encryption required ("0")</summary>
	public static readonly EncryptionLevel ZERO = new EncryptionLevel("0");

	/// <summary>Symmetric key length of at least 128 bits is to be used ("4")</summary>
	public static readonly EncryptionLevel FOUR = new EncryptionLevel("4");

	/// <summary>Symmetric key length of at least 40 bits is to be used ("1")</summary>
	public static readonly EncryptionLevel ONE = new EncryptionLevel("1");

	/// <summary>Symmetric key length of at least 80 bits is to be used ("3")</summary>
	public static readonly EncryptionLevel THREE = new EncryptionLevel("3");

	///<summary>Wrap an arbitrary string value in an EncryptionLevel object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EncryptionLevel Wrap( String wrappedValue ) {
		return new EncryptionLevel( wrappedValue );
	}

	private EncryptionLevel( string enumDefValue ) : base( enumDefValue ) {}
	}
}