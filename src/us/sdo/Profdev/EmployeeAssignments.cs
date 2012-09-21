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

namespace OpenADK.Library.us.Profdev{

/// <summary>An EmployeeAssignments</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class EmployeeAssignments : SifKeyedList<EmplAssignment>
{
	/// <summary>
	/// Creates an instance of an EmployeeAssignments
	/// </summary>
	public EmployeeAssignments() : base ( ProfdevDTD.EMPLOYEEASSIGNMENTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assignment">An Assignment</param>
	///
	public EmployeeAssignments( EmplAssignment assignment ) : base( ProfdevDTD.EMPLOYEEASSIGNMENTS )
	{
		this.SafeAddChild( ProfdevDTD.EMPLOYEEASSIGNMENTS_ASSIGNMENT, assignment );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected EmployeeAssignments( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Assignment&gt;</c> element.</summary>
	/// <param name="SchoolInfoRefId">References SchoolInfo object to determine school in which this assignment pertains.</param>
	/// <param name="GradeLevels">A GradeLevels</param>
	/// <param name="JobFunction">A JobFunction</param>
	///<remarks>
	/// <para>This form of <c>setAssignment</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssignment</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddAssignment( string SchoolInfoRefId, GradeLevels GradeLevels, JobFunction JobFunction ) {
		AddChild( ProfdevDTD.EMPLOYEEASSIGNMENTS_ASSIGNMENT, new EmplAssignment( SchoolInfoRefId, GradeLevels, JobFunction ) );
	}

}}