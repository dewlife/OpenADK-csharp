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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Assessment{

/// <summary>A Scores</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Scores : SifKeyedList<Score>
{
	/// <summary>
	/// Creates an instance of a Scores
	/// </summary>
	public Scores() : base ( AssessmentDTD.SCORES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="score">A Score</param>
	///
	public Scores( Score score ) : base( AssessmentDTD.SCORES )
	{
		this.SafeAddChild( AssessmentDTD.SCORES_SCORE, score );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Scores( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Score&gt;</c> element.</summary>
	/// <param name="AssessmentSubTestRefId">References the AssessmentSubTest that defines the score.</param>
	///<remarks>
	/// <para>This form of <c>setScore</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddScore</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddScore( string AssessmentSubTestRefId ) {
		AddChild( AssessmentDTD.SCORES_SCORE, new Score( AssessmentSubTestRefId ) );
	}

}}