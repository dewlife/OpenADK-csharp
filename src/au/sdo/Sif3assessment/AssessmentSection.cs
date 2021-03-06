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

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>An AssessmentSection</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class AssessmentSection : SifElement
{
	/// <summary>
	/// Creates an instance of an AssessmentSection
	/// </summary>
	public AssessmentSection() : base ( Sif3assessmentDTD.ASSESSMENTSECTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentSectionRefId">An AssessmentSectionRefId</param>
	///<param name="assessmentSectionSequence">An AssessmentSectionSequence</param>
	///
	public AssessmentSection( string assessmentSectionRefId, string assessmentSectionSequence ) : base( Sif3assessmentDTD.ASSESSMENTSECTION )
	{
		this.AssessmentSectionRefId = assessmentSectionRefId;
		this.AssessmentSectionSequence = assessmentSectionSequence;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentSection( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.ASSESSMENTSECTION_ASSESSMENTSECTIONREFID, Sif3assessmentDTD.ASSESSMENTSECTION_ASSESSMENTSECTIONSEQUENCE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSectionRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentSectionRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentSectionRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.ASSESSMENTSECTION_ASSESSMENTSECTIONREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.ASSESSMENTSECTION_ASSESSMENTSECTIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSectionSequence&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentSectionSequence</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentSectionSequence
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.ASSESSMENTSECTION_ASSESSMENTSECTIONSEQUENCE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.ASSESSMENTSECTION_ASSESSMENTSECTIONSEQUENCE, new SifString( value ), value );
		}
	}

}}
