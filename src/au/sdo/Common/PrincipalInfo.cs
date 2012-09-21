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

namespace OpenADK.Library.au.Common{

/// <summary>A PrincipalInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class PrincipalInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a PrincipalInfo
	/// </summary>
	public PrincipalInfo() : base ( CommonDTD.PRINCIPALINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="contactName">The name of the principal.</param>
	///
	public PrincipalInfo( ContactName contactName ) : base( CommonDTD.PRINCIPALINFO )
	{
		this.ContactName = contactName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PrincipalInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.PRINCIPALINFO_CONTACTNAME }; }
	}

	///<summary>Sets the value of the <c>&lt;ContactName&gt;</c> element.</summary>
	/// <param name="Type">A Type</param>
	///<remarks>
	/// <para>This form of <c>setContactName</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ContactName</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetContactName( string Type ) {
		RemoveChild( CommonDTD.PRINCIPALINFO_CONTACTNAME);
		AddChild( CommonDTD.PRINCIPALINFO_CONTACTNAME, new ContactName( Type ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ContactName&gt;</c> element.
	/// </summary>
	/// <value> A ContactName </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The name of the principal."</para>
	/// <para>To remove the <c>ContactName</c>, set <c>ContactName</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ContactName ContactName
	{
		get
		{
			return (ContactName)GetChild( CommonDTD.PRINCIPALINFO_CONTACTNAME);
		}
		set
		{
			RemoveChild( CommonDTD.PRINCIPALINFO_CONTACTNAME);
			if( value != null)
			{
				AddChild( CommonDTD.PRINCIPALINFO_CONTACTNAME, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ContactTitle&gt;</c> element.
	/// </summary>
	/// <value> The <c>ContactTitle</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The principal's title."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string ContactTitle
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.PRINCIPALINFO_CONTACTTITLE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.PRINCIPALINFO_CONTACTTITLE, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.</summary>
	/// <param name="PhoneNumber">A PhoneNumber</param>
	///<remarks>
	/// <para>This form of <c>setPhoneNumberList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PhoneNumberList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPhoneNumberList( PhoneNumber PhoneNumber ) {
		RemoveChild( CommonDTD.PRINCIPALINFO_PHONENUMBERLIST);
		AddChild( CommonDTD.PRINCIPALINFO_PHONENUMBERLIST, new PhoneNumberList( PhoneNumber ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumberList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The principal’s phone number(s)."</para>
	/// <para>To remove the <c>PhoneNumberList</c>, set <c>PhoneNumberList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PhoneNumberList PhoneNumberList
	{
		get
		{
			return (PhoneNumberList)GetChild( CommonDTD.PRINCIPALINFO_PHONENUMBERLIST);
		}
		set
		{
			RemoveChild( CommonDTD.PRINCIPALINFO_PHONENUMBERLIST);
			if( value != null)
			{
				AddChild( CommonDTD.PRINCIPALINFO_PHONENUMBERLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;EmailList&gt;</c> element.</summary>
	/// <param name="Email">An Email</param>
	///<remarks>
	/// <para>This form of <c>setEmailList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>EmailList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetEmailList( Email Email ) {
		RemoveChild( CommonDTD.PRINCIPALINFO_EMAILLIST);
		AddChild( CommonDTD.PRINCIPALINFO_EMAILLIST, new EmailList( Email ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmailList&gt;</c> element.
	/// </summary>
	/// <value> An EmailList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The principal’s e-mail address(es)."</para>
	/// <para>To remove the <c>EmailList</c>, set <c>EmailList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public EmailList EmailList
	{
		get
		{
			return (EmailList)GetChild( CommonDTD.PRINCIPALINFO_EMAILLIST);
		}
		set
		{
			RemoveChild( CommonDTD.PRINCIPALINFO_EMAILLIST);
			if( value != null)
			{
				AddChild( CommonDTD.PRINCIPALINFO_EMAILLIST, value );
			}
		}
	}

}}