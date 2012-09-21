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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Student{

/// <summary>A SchoolEnrollment</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SchoolEnrollment : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SchoolEnrollment
	/// </summary>
	public SchoolEnrollment() : base ( StudentDTD.SCHOOLENROLLMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="schoolName">Name of school/campus.</param>
	///
	public SchoolEnrollment( string schoolName ) : base( StudentDTD.SCHOOLENROLLMENT )
	{
		this.SchoolName = schoolName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SchoolEnrollment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.SCHOOLENROLLMENT_SCHOOLNAME }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolName&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of school/campus."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLNAME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The ID (GUID) of the school. Provide both the SchoolInfo RefId and LocalId elements if possible. If not, one or the other must be provided."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-defined identifier for this school. Provide both the LocalId and SchoolId elements if possible. If not, one or the other must be provided."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLLOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLLOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolStateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolStateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The state or province defined identifier for this school."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolStateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLSTATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLENROLLMENT_SCHOOLSTATEPROVINCEID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Student&gt;</c> element.</summary>
	/// <param name="StudentSchoolEnrollmentRefId">The ID (GUID) of the StudentSchoolEnrollment object from which the enrollment information is derived.</param>
	///<remarks>
	/// <para>This form of <c>setStudent</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Student</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetStudent( string StudentSchoolEnrollmentRefId ) {
		RemoveChild( StudentDTD.SCHOOLENROLLMENT_STUDENT);
		AddChild( StudentDTD.SCHOOLENROLLMENT_STUDENT, new Student( StudentSchoolEnrollmentRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Student&gt;</c> element.
	/// </summary>
	/// <value> A Student </value>
	/// <remarks>
	/// <para>To remove the <c>Student</c>, set <c>Student</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public Student Student
	{
		get
		{
			return (Student)GetChild( StudentDTD.SCHOOLENROLLMENT_STUDENT);
		}
		set
		{
			RemoveChild( StudentDTD.SCHOOLENROLLMENT_STUDENT);
			if( value != null)
			{
				AddChild( StudentDTD.SCHOOLENROLLMENT_STUDENT, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Staff&gt;</c> element.</summary>
	/// <param name="StaffAssignmentRefId">The ID (GUID) of the StaffAssignment object from which the enrollment information is derived.</param>
	///<remarks>
	/// <para>This form of <c>setStaff</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Staff</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetStaff( string StaffAssignmentRefId ) {
		RemoveChild( StudentDTD.SCHOOLENROLLMENT_STAFF);
		AddChild( StudentDTD.SCHOOLENROLLMENT_STAFF, new Staff( StaffAssignmentRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Staff&gt;</c> element.
	/// </summary>
	/// <value> A Staff </value>
	/// <remarks>
	/// <para>To remove the <c>Staff</c>, set <c>Staff</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public Staff Staff
	{
		get
		{
			return (Staff)GetChild( StudentDTD.SCHOOLENROLLMENT_STAFF);
		}
		set
		{
			RemoveChild( StudentDTD.SCHOOLENROLLMENT_STAFF);
			if( value != null)
			{
				AddChild( StudentDTD.SCHOOLENROLLMENT_STAFF, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;EnrollmentList&gt;</c> element.</summary>
	/// <param name="Enrollment">An Enrollment</param>
	///<remarks>
	/// <para>This form of <c>setEnrollmentList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>EnrollmentList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetEnrollmentList( Enrollment Enrollment ) {
		RemoveChild( StudentDTD.SCHOOLENROLLMENT_ENROLLMENTLIST);
		AddChild( StudentDTD.SCHOOLENROLLMENT_ENROLLMENTLIST, new EnrollmentList( Enrollment ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EnrollmentList&gt;</c> element.
	/// </summary>
	/// <value> An EnrollmentList </value>
	/// <remarks>
	/// <para>To remove the <c>EnrollmentList</c>, set <c>EnrollmentList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public EnrollmentList EnrollmentList
	{
		get
		{
			return (EnrollmentList)GetChild( StudentDTD.SCHOOLENROLLMENT_ENROLLMENTLIST);
		}
		set
		{
			RemoveChild( StudentDTD.SCHOOLENROLLMENT_ENROLLMENTLIST);
			if( value != null)
			{
				AddChild( StudentDTD.SCHOOLENROLLMENT_ENROLLMENTLIST, value );
			}
		}
	}

}}