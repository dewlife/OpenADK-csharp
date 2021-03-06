// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.System
{
	///<summary>
	/// Defines the set of values that can be specified whenever a RoleScopeRefIdType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a RoleScopeRefIdType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class RoleScopeRefIdType : SifEnum
	{
	/// <summary>StudentActivityParticipation ("StudentActivityParticipation")</summary>
	public static readonly RoleScopeRefIdType STUDENT_ACTIVITY_PARTICIPATION = new RoleScopeRefIdType("StudentActivityParticipation");

	/// <summary>SchoolInfo ("SchoolInfo")</summary>
	public static readonly RoleScopeRefIdType SCHOOL_INFO = new RoleScopeRefIdType("SchoolInfo");

	/// <summary>TeachingGroup ("TeachingGroup")</summary>
	public static readonly RoleScopeRefIdType TEACHING_GROUP = new RoleScopeRefIdType("TeachingGroup");

	///<summary>Wrap an arbitrary string value in a RoleScopeRefIdType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static RoleScopeRefIdType Wrap( String wrappedValue ) {
		return new RoleScopeRefIdType( wrappedValue );
	}

	private RoleScopeRefIdType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
