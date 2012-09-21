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

/// <summary>Information identifying the driver.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class BusDriver : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a BusDriver
	/// </summary>
	public BusDriver() : base ( TransDTD.BUSDRIVER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="status">Boarding status of the driver.</param>
	///
	public BusDriver( StaffBoardingStatus status ) : base( TransDTD.BUSDRIVER )
	{
		this.SetStatus( status );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected BusDriver( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { TransDTD.BUSDRIVER_STATUS }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Status</c> attribute.
	/// </summary>
	/// <value> The <c>Status</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Boarding status of the driver."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Status
	{
		get
		{ 
			return GetFieldValue( TransDTD.BUSDRIVER_STATUS );
		}
		set
		{
			SetField( TransDTD.BUSDRIVER_STATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Status</c> attribute.
	/// </summary>
	/// <param name="val">A StaffBoardingStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Boarding status of the driver."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetStatus( StaffBoardingStatus val )
	{
		SetField( TransDTD.BUSDRIVER_STATUS, val );
	}

	///<summary>Sets the value of the <c>&lt;Name&gt;</c> element.</summary>
	/// <param name="Type">Code that specifies what type of name this is.  If unsure, use 04.</param>
	/// <param name="LastName">The last name.</param>
	/// <param name="FirstName">The first name.</param>
	///<remarks>
	/// <para>This form of <c>setName</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Name</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetName( NameType Type, string LastName, string FirstName ) {
		RemoveChild( TransDTD.BUSDRIVER_NAME);
		AddChild( TransDTD.BUSDRIVER_NAME, new Name( Type, LastName, FirstName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> A Name </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The name of the driver. Condition is that at least one of this and BusDriver/EmpLink must be included."</para>
	/// <para>To remove the <c>Name</c>, set <c>Name</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public Name Name
	{
		get
		{
			return (Name)GetChild( TransDTD.BUSDRIVER_NAME);
		}
		set
		{
			RemoveChild( TransDTD.BUSDRIVER_NAME);
			if( value != null)
			{
				AddChild( TransDTD.BUSDRIVER_NAME, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmployeePersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>EmployeePersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The GUID of the driver's EmployeePersonal object. Condition is that at least one of this and BusDriver/Name must be included."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;EmployeePersonalRefId&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string EmployeePersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.BUSDRIVER_EMPLOYEEPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSDRIVER_EMPLOYEEPERSONALREFID, new SifString( value ), value );
		}
	}

}}