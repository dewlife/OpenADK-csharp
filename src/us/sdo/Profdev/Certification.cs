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

/// <summary>Employee certification area information</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Certification : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Certification
	/// </summary>
	public Certification() : base ( ProfdevDTD.CERTIFICATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="description">Certification description as defined by state</param>
	///
	public Certification( string description ) : base( ProfdevDTD.CERTIFICATION )
	{
		this.Description = description;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Certification( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProfdevDTD.CERTIFICATION_DESCRIPTION }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Certification description as defined by state"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.CERTIFICATION_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.CERTIFICATION_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AreaAuthorized&gt;</c> element.
	/// </summary>
	/// <value> The <c>AreaAuthorized</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Area in which employee has certification"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string AreaAuthorized
	{
		get
		{ 
			return GetFieldValue( ProfdevDTD.CERTIFICATION_AREAAUTHORIZED );
		}
		set
		{
			SetField( ProfdevDTD.CERTIFICATION_AREAAUTHORIZED, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AreaAuthorized&gt;</c> element.
	/// </summary>
	/// <param name="val">A TeachingArea object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Area in which employee has certification"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetAreaAuthorized( TeachingArea val )
	{
		SetField( ProfdevDTD.CERTIFICATION_AREAAUTHORIZED, val );
	}

}}