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

namespace OpenADK.Library.uk.Catering{

/// <summary>A Meals</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Meals : SifList<Meal>
{
	/// <summary>
	/// Creates an instance of a Meals
	/// </summary>
	public Meals() : base ( CateringDTD.MEALS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="meal">A Meal</param>
	///
	public Meals( Meal meal ) : base( CateringDTD.MEALS )
	{
		this.SafeAddChild( CateringDTD.MEALS_MEAL, meal );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Meals( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { CateringDTD.MEALS_MEAL }; }
	}

	///<summary>Adds the value of the <c>&lt;Meal&gt;</c> element.</summary>
	/// <param name="Day">The Day of week that Meal is required</param>
	/// <param name="MealTime">Which meal of the day is required</param>
	/// <param name="MealType">What type of meal is required</param>
	///<remarks>
	/// <para>This form of <c>setMeal</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddMeal</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddMeal( Day Day, MealTime MealTime, MealType MealType ) {
		AddChild( CateringDTD.MEALS_MEAL, new Meal( Day, MealTime, MealType ) );
	}

}}
