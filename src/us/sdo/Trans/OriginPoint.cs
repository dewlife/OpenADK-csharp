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

namespace OpenADK.Library.us.Trans{

/// <summary>An OriginPoint</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class OriginPoint : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an OriginPoint
	/// </summary>
	public OriginPoint() : base ( TransDTD.ORIGINPOINT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="busRouteDetailRefId">GUID that identifies the bus stop/route where the student gets on the bus.</param>
	///
	public OriginPoint( string busRouteDetailRefId ) : base( TransDTD.ORIGINPOINT )
	{
		this.BusRouteDetailRefId = busRouteDetailRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OriginPoint( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { TransDTD.ORIGINPOINT_BUSROUTEDETAILREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>BusRouteDetailRefId</c> attribute.
	/// </summary>
	/// <value> The <c>BusRouteDetailRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies the bus stop/route where the student gets on the bus."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string BusRouteDetailRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.ORIGINPOINT_BUSROUTEDETAILREFID ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ORIGINPOINT_BUSROUTEDETAILREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ArrivalTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>ArrivalTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The time that the bus associated with this route will stop at this bus stop."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public DateTime? ArrivalTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( TransDTD.ORIGINPOINT_ARRIVALTIME ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ORIGINPOINT_ARRIVALTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>RouteNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A unique identifier for the route. For instance, you may have route 16AM in the morning and a 16PM in the afternoon."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string RouteNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.ORIGINPOINT_ROUTENUMBER ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ORIGINPOINT_ROUTENUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>RouteDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Short explanation of the route."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string RouteDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.ORIGINPOINT_ROUTEDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ORIGINPOINT_ROUTEDESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;VehicleNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>VehicleNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Vehicle number of the bus."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string VehicleNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.ORIGINPOINT_VEHICLENUMBER ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ORIGINPOINT_VEHICLENUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BusStopDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>BusStopDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An explanation of this location."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string BusStopDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.ORIGINPOINT_BUSSTOPDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ORIGINPOINT_BUSSTOPDESCRIPTION, new SifString( value ), value );
		}
	}

}}