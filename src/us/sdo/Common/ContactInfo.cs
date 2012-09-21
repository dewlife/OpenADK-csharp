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

namespace OpenADK.Library.us.Common{

/// <summary>Common element used to supply information for a contact person at a school, LEA, or other institution.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ContactInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ContactInfo
	/// </summary>
	public ContactInfo() : base ( CommonDTD.CONTACTINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="name">The name of the contact person.</param>
	///
	public ContactInfo( Name name ) : base( CommonDTD.CONTACTINFO )
	{
		this.Name = name;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ContactInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.CONTACTINFO_NAME }; }
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
		RemoveChild( CommonDTD.CONTACTINFO_NAME);
		AddChild( CommonDTD.CONTACTINFO_NAME, new Name( Type, LastName, FirstName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> A Name </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The name of the contact person."</para>
	/// <para>To remove the <c>Name</c>, set <c>Name</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public Name Name
	{
		get
		{
			return (Name)GetChild( CommonDTD.CONTACTINFO_NAME);
		}
		set
		{
			RemoveChild( CommonDTD.CONTACTINFO_NAME);
			if( value != null)
			{
				AddChild( CommonDTD.CONTACTINFO_NAME, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PositionTitle&gt;</c> element.
	/// </summary>
	/// <value> The <c>PositionTitle</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The contact person's position title."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string PositionTitle
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTINFO_POSITIONTITLE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTINFO_POSITIONTITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Role&gt;</c> element.
	/// </summary>
	/// <value> The <c>Role</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Role played by this contact in this instance."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Role
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CONTACTINFO_ROLE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CONTACTINFO_ROLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmailList&gt;</c> element.
	/// </summary>
	/// <value> An EmailList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "List of Email elements."</para>
	/// <para>To remove the <c>EmailList</c>, set <c>EmailList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public EmailList EmailList
	{
		get
		{
			return (EmailList)GetChild( CommonDTD.CONTACTINFO_EMAILLIST);
		}
		set
		{
			RemoveChild( CommonDTD.CONTACTINFO_EMAILLIST);
			if( value != null)
			{
				AddChild( CommonDTD.CONTACTINFO_EMAILLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumberList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "List of PhoneNumber elements."</para>
	/// <para>To remove the <c>PhoneNumberList</c>, set <c>PhoneNumberList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public PhoneNumberList PhoneNumberList
	{
		get
		{
			return (PhoneNumberList)GetChild( CommonDTD.CONTACTINFO_PHONENUMBERLIST);
		}
		set
		{
			RemoveChild( CommonDTD.CONTACTINFO_PHONENUMBERLIST);
			if( value != null)
			{
				AddChild( CommonDTD.CONTACTINFO_PHONENUMBERLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Address&gt;</c> element.</summary>
	/// <param name="Type">Code that defines the location of the address.  Note:  A subset of specific valid values for each instance in a data object may be listed in that object.</param>
	/// <param name="Street">The street part of the address</param>
	/// <param name="City">The city part of the address.</param>
	/// <param name="StateProvince">The state or province code.</param>
	/// <param name="Country">The country code.</param>
	/// <param name="PostalCode">The ZIP/postal code.</param>
	///<remarks>
	/// <para>This form of <c>setAddress</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Address</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAddress( AddressType Type, Street Street, string City, StatePrCode StateProvince, CountryCode Country, string PostalCode ) {
		RemoveChild( CommonDTD.CONTACTINFO_ADDRESS);
		AddChild( CommonDTD.CONTACTINFO_ADDRESS, new Address( Type, Street, City, StateProvince, Country, PostalCode ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Address&gt;</c> element.
	/// </summary>
	/// <value> An Address </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Address of the contact."</para>
	/// <para>To remove the <c>Address</c>, set <c>Address</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Address Address
	{
		get
		{
			return (Address)GetChild( CommonDTD.CONTACTINFO_ADDRESS);
		}
		set
		{
			RemoveChild( CommonDTD.CONTACTINFO_ADDRESS);
			if( value != null)
			{
				AddChild( CommonDTD.CONTACTINFO_ADDRESS, value );
			}
		}
	}

}}