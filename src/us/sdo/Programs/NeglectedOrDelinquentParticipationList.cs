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

namespace OpenADK.Library.us.Programs{

/// <summary>A NeglectedOrDelinquentParticipationList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class NeglectedOrDelinquentParticipationList : SifKeyedList<NeglectedOrDelinquentParticipation>
{
	/// <summary>
	/// Creates an instance of a NeglectedOrDelinquentParticipationList
	/// </summary>
	public NeglectedOrDelinquentParticipationList() : base ( ProgramsDTD.NEGLECTEDORDELINQUENTPARTICIPATIONLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="neglectedOrDelinquentParticipation">The type and number of days a student participated in a Neglected or Delinquent program during the reporting period.</param>
	///
	public NeglectedOrDelinquentParticipationList( NeglectedOrDelinquentParticipation neglectedOrDelinquentParticipation ) : base( ProgramsDTD.NEGLECTEDORDELINQUENTPARTICIPATIONLIST )
	{
		this.SafeAddChild( ProgramsDTD.NEGLECTEDORDELINQUENTPARTICIPATIONLIST_NEGLECTEDORDELINQUENTPARTICIPATION, neglectedOrDelinquentParticipation );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected NeglectedOrDelinquentParticipationList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { ProgramsDTD.NEGLECTEDORDELINQUENTPARTICIPATIONLIST_NEGLECTEDORDELINQUENTPARTICIPATION }; }
	}

	///<summary>Adds the value of the <c>&lt;NeglectedOrDelinquentParticipation&gt;</c> element.</summary>
	/// <param name="Type">The specific classification for the neglected or delinquent program.</param>
	///<remarks>
	/// <para>This form of <c>setNeglectedOrDelinquentParticipation</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddNeglectedOrDelinquentParticipation</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddNeglectedOrDelinquentParticipation( NeglectedOrDelinquentParticipationType Type ) {
		AddChild( ProgramsDTD.NEGLECTEDORDELINQUENTPARTICIPATIONLIST_NEGLECTEDORDELINQUENTPARTICIPATION, new NeglectedOrDelinquentParticipation( Type ) );
	}

}}
