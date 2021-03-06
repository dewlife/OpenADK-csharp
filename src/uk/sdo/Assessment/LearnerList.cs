// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Assessment{

/// <summary>A LearnerList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class LearnerList : SifKeyedList<LearnerPersonalRefId>
{
	/// <summary>
	/// Creates an instance of a LearnerList
	/// </summary>
	public LearnerList() : base ( AssessmentDTD.LEARNERLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learnerPersonalRefId">The ID (GUID) of a learner assigned to take an assessment.</param>
	///
	public LearnerList( LearnerPersonalRefId learnerPersonalRefId ) : base( AssessmentDTD.LEARNERLIST )
	{
		this.SafeAddChild( AssessmentDTD.LEARNERLIST_LEARNERPERSONALREFID, learnerPersonalRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LearnerList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.LEARNERLIST_LEARNERPERSONALREFID }; }
	}

	///<summary>Adds the value of the <c>&lt;LearnerPersonalRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;LearnerPersonalRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLearnerPersonalRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLearnerPersonalRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public void AddLearnerPersonalRefId( string Value ) {
		AddChild( AssessmentDTD.LEARNERLIST_LEARNERPERSONALREFID, new LearnerPersonalRefId( Value ) );
	}

}}
