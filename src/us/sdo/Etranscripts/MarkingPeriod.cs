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

/// <summary>A MarkingPeriod</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class MarkingPeriod : SifElement
{
	/// <summary>
	/// Creates an instance of a MarkingPeriod
	/// </summary>
	public MarkingPeriod() : base ( EtranscriptsDTD.MARKINGPERIOD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="gradeLevelWhenTaken">Student's grade level at time of course.</param>
	///<param name="courseCreditsAttempted">Number of course credits attempted.</param>
	///<param name="courseCreditsEarned">Number of course credits earned.</param>
	///
	public MarkingPeriod( GradeLevel gradeLevelWhenTaken, decimal? courseCreditsAttempted, decimal? courseCreditsEarned ) : base( EtranscriptsDTD.MARKINGPERIOD )
	{
		this.GradeLevelWhenTaken = gradeLevelWhenTaken;
		this.CourseCreditsAttempted = courseCreditsAttempted;
		this.CourseCreditsEarned = courseCreditsEarned;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MarkingPeriod( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { EtranscriptsDTD.MARKINGPERIOD_GRADELEVELWHENTAKEN, EtranscriptsDTD.MARKINGPERIOD_COURSECREDITSATTEMPTED, EtranscriptsDTD.MARKINGPERIOD_COURSECREDITSEARNED }; }
	}

	///<summary>Sets the value of the <c>&lt;TermInfoData&gt;</c> element.</summary>
	/// <param name="SchoolAttendedRefId">Reference to the school of record for the courses being taken (see SchoolAttended).</param>
	///<remarks>
	/// <para>This form of <c>setTermInfoData</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>TermInfoData</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetTermInfoData( string SchoolAttendedRefId ) {
		RemoveChild( EtranscriptsDTD.MARKINGPERIOD_TERMINFODATA);
		AddChild( EtranscriptsDTD.MARKINGPERIOD_TERMINFODATA, new TermInfoData( SchoolAttendedRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TermInfoData&gt;</c> element.
	/// </summary>
	/// <value> A TermInfoData </value>
	/// <remarks>
	/// <para>To remove the <c>TermInfoData</c>, set <c>TermInfoData</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public TermInfoData TermInfoData
	{
		get
		{
			return (TermInfoData)GetChild( EtranscriptsDTD.MARKINGPERIOD_TERMINFODATA);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.MARKINGPERIOD_TERMINFODATA);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.MARKINGPERIOD_TERMINFODATA, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;GradeLevelWhenTaken&gt;</c> element.</summary>
	/// <param name="Code">Code representing the grade level.</param>
	///<remarks>
	/// <para>This form of <c>setGradeLevelWhenTaken</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>GradeLevelWhenTaken</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetGradeLevelWhenTaken( GradeLevelCode Code ) {
		RemoveChild( EtranscriptsDTD.MARKINGPERIOD_GRADELEVELWHENTAKEN);
		AddChild( EtranscriptsDTD.MARKINGPERIOD_GRADELEVELWHENTAKEN, new GradeLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevelWhenTaken&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevel </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Student's grade level at time of course."</para>
	/// <para>To remove the <c>GradeLevel</c>, set <c>GradeLevelWhenTaken</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public GradeLevel GradeLevelWhenTaken
	{
		get
		{
			return (GradeLevel)GetChild( EtranscriptsDTD.MARKINGPERIOD_GRADELEVELWHENTAKEN);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.MARKINGPERIOD_GRADELEVELWHENTAKEN);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.MARKINGPERIOD_GRADELEVELWHENTAKEN, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;MarkData&gt;</c> element.</summary>
	/// <param name="MarkValueInfoDataRefId">Reference to marking system at school of record.</param>
	///<remarks>
	/// <para>This form of <c>setMarkData</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>MarkData</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetMarkData( string MarkValueInfoDataRefId ) {
		RemoveChild( EtranscriptsDTD.MARKINGPERIOD_MARKDATA);
		AddChild( EtranscriptsDTD.MARKINGPERIOD_MARKDATA, new MarkData( MarkValueInfoDataRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MarkData&gt;</c> element.
	/// </summary>
	/// <value> A MarkData </value>
	/// <remarks>
	/// <para>To remove the <c>MarkData</c>, set <c>MarkData</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public MarkData MarkData
	{
		get
		{
			return (MarkData)GetChild( EtranscriptsDTD.MARKINGPERIOD_MARKDATA);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.MARKINGPERIOD_MARKDATA);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.MARKINGPERIOD_MARKDATA, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CourseCreditsAttempted&gt;</c> element.
	/// </summary>
	/// <value> The <c>CourseCreditsAttempted</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of course credits attempted."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? CourseCreditsAttempted
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKINGPERIOD_COURSECREDITSATTEMPTED ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKINGPERIOD_COURSECREDITSATTEMPTED, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CourseCreditsEarned&gt;</c> element.
	/// </summary>
	/// <value> The <c>CourseCreditsEarned</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of course credits earned."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? CourseCreditsEarned
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKINGPERIOD_COURSECREDITSEARNED ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKINGPERIOD_COURSECREDITSEARNED, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreditType&gt;</c> element.
	/// </summary>
	/// <value> The <c>CreditType</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string CreditType
	{
		get
		{ 
			return GetFieldValue( EtranscriptsDTD.MARKINGPERIOD_CREDITTYPE );
		}
		set
		{
			SetField( EtranscriptsDTD.MARKINGPERIOD_CREDITTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;CreditType&gt;</c> element.
	/// </summary>
	/// <param name="val">A CreditTypeType object</param>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetCreditType( CreditTypeType val )
	{
		SetField( EtranscriptsDTD.MARKINGPERIOD_CREDITTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DaysAbsent&gt;</c> element.
	/// </summary>
	/// <value> The <c>DaysAbsent</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? DaysAbsent
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKINGPERIOD_DAYSABSENT ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKINGPERIOD_DAYSABSENT, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DaysPresent&gt;</c> element.
	/// </summary>
	/// <value> The <c>DaysPresent</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? DaysPresent
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKINGPERIOD_DAYSPRESENT ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKINGPERIOD_DAYSPRESENT, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ExcessiveAbsenceIndicator&gt;</c> element.
	/// </summary>
	/// <value> The <c>ExcessiveAbsenceIndicator</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public bool? ExcessiveAbsenceIndicator
	{
		get
		{
			return (bool?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKINGPERIOD_EXCESSIVEABSENCEINDICATOR ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKINGPERIOD_EXCESSIVEABSENCEINDICATOR, new SifBoolean( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ExtendedElements&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ExtendedElements </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_ExtendedElements</c>, set <c>SIF_ExtendedElements</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SIF_ExtendedElements SIF_ExtendedElements
	{
		get
		{
			return (SIF_ExtendedElements)GetChild( EtranscriptsDTD.MARKINGPERIOD_SIF_EXTENDEDELEMENTS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.MARKINGPERIOD_SIF_EXTENDEDELEMENTS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.MARKINGPERIOD_SIF_EXTENDEDELEMENTS, value );
			}
		}
	}

}}