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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>A MarkingPeriods</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class MarkingPeriods : SifList<MarkingPeriod>
{
	/// <summary>
	/// Creates an instance of a MarkingPeriods
	/// </summary>
	public MarkingPeriods() : base ( EtranscriptsDTD.MARKINGPERIODS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="markingPeriod">A MarkingPeriod</param>
	///
	public MarkingPeriods( MarkingPeriod markingPeriod ) : base( EtranscriptsDTD.MARKINGPERIODS )
	{
		this.SafeAddChild( EtranscriptsDTD.MARKINGPERIODS_MARKINGPERIOD, markingPeriod );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MarkingPeriods( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { EtranscriptsDTD.MARKINGPERIODS_MARKINGPERIOD }; }
	}

	///<summary>Adds the value of the <c>&lt;MarkingPeriod&gt;</c> element.</summary>
	/// <param name="GradeLevelWhenTaken">Student's grade level at time of course.</param>
	/// <param name="CourseCreditsAttempted">Number of course credits attempted.</param>
	/// <param name="CourseCreditsEarned">Number of course credits earned.</param>
	///<remarks>
	/// <para>This form of <c>setMarkingPeriod</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddMarkingPeriod</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddMarkingPeriod( GradeLevel GradeLevelWhenTaken, decimal? CourseCreditsAttempted, decimal? CourseCreditsEarned ) {
		AddChild( EtranscriptsDTD.MARKINGPERIODS_MARKINGPERIOD, new MarkingPeriod( GradeLevelWhenTaken, CourseCreditsAttempted, CourseCreditsEarned ) );
	}

}}