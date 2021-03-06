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

/// <summary>A StudentContact</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class StudentContact : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentContact
	/// </summary>
	public StudentContact() : base( Adk.SifVersion, StudentDTD.STUDENTCONTACT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID of this contact.</param>
	///<param name="studentPersonalRefId">The GUID of the student whose contact this is.</param>
	///<param name="name">The name of the contact.  Note: Type attribute value of 04 must be used here.</param>
	///<param name="contactFlags">A ContactFlags</param>
	///
	public StudentContact( string refId, string studentPersonalRefId, Name name, ContactFlags contactFlags ) : base( Adk.SifVersion, StudentDTD.STUDENTCONTACT )
	{
		this.RefId = refId;
		this.StudentPersonalRefId = studentPersonalRefId;
		this.Name = name;
		this.ContactFlags = contactFlags;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentContact( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENTCONTACT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID of this contact."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACT_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACT_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID of the student whose contact this is."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACT_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACT_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for this contact.  Note: LocalId may be used as a unique person identifier        rather than a unique contact identifier.  In this case there may be more than one StudentContact instance with the same LocalId."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACT_LOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACT_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherIdList&gt;</c> element.
	/// </summary>
	/// <value> An OtherIdList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherIdList</c>, set <c>OtherIdList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public OtherIdList OtherIdList
	{
		get
		{
			return (OtherIdList)GetChild( StudentDTD.STUDENTCONTACT_OTHERIDLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_OTHERIDLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_OTHERIDLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Name&gt;</c> element.</summary>
	/// <param name="Type">
	/// Code that specifies what type of name this is. If
	/// unsure, use LGL.</param>
	///<remarks>
	/// <para>This form of <c>setName</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Name</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetName( NameType Type ) {
		RemoveChild( StudentDTD.STUDENTCONTACT_NAME);
		AddChild( StudentDTD.STUDENTCONTACT_NAME, new Name( Type ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> A Name </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The name of the contact.  Note: Type attribute value of 04 must be used here."</para>
	/// <para>To remove the <c>Name</c>, set <c>Name</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public Name Name
	{
		get
		{
			return (Name)GetChild( StudentDTD.STUDENTCONTACT_NAME);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_NAME);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_NAME, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;OtherNames&gt;</c> element.</summary>
	/// <param name="Name">A Name</param>
	///<remarks>
	/// <para>This form of <c>setOtherNames</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>OtherNames</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetOtherNames( Name Name ) {
		RemoveChild( StudentDTD.STUDENTCONTACT_OTHERNAMES);
		AddChild( StudentDTD.STUDENTCONTACT_OTHERNAMES, new OtherNames( Name ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherNames&gt;</c> element.
	/// </summary>
	/// <value> An OtherNames </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Previous, alternate or other names or aliases associated with the contact."</para>
	/// <para>To remove the <c>OtherNames</c>, set <c>OtherNames</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public OtherNames OtherNames
	{
		get
		{
			return (OtherNames)GetChild( StudentDTD.STUDENTCONTACT_OTHERNAMES);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_OTHERNAMES);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_OTHERNAMES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Demographics&gt;</c> element.
	/// </summary>
	/// <value> A Demographics </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Demographic information about the contact."</para>
	/// <para>To remove the <c>Demographics</c>, set <c>Demographics</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public Demographics Demographics
	{
		get
		{
			return (Demographics)GetChild( StudentDTD.STUDENTCONTACT_DEMOGRAPHICS);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_DEMOGRAPHICS);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_DEMOGRAPHICS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AddressList&gt;</c> element.</summary>
	/// <param name="Address">An Address</param>
	///<remarks>
	/// <para>This form of <c>setAddressList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AddressList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAddressList( Address Address ) {
		RemoveChild( StudentDTD.STUDENTCONTACT_ADDRESSLIST);
		AddChild( StudentDTD.STUDENTCONTACT_ADDRESSLIST, new AddressList( Address ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AddressList&gt;</c> element.
	/// </summary>
	/// <value> An AddressList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The contact's address(es)."</para>
	/// <para>To remove the <c>AddressList</c>, set <c>AddressList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public AddressList AddressList
	{
		get
		{
			return (AddressList)GetChild( StudentDTD.STUDENTCONTACT_ADDRESSLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_ADDRESSLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_ADDRESSLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.</summary>
	/// <param name="PhoneNumber">A PhoneNumber</param>
	///<remarks>
	/// <para>This form of <c>setPhoneNumberList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PhoneNumberList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPhoneNumberList( PhoneNumber PhoneNumber ) {
		RemoveChild( StudentDTD.STUDENTCONTACT_PHONENUMBERLIST);
		AddChild( StudentDTD.STUDENTCONTACT_PHONENUMBERLIST, new PhoneNumberList( PhoneNumber ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumberList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The contact's phone number(s)."</para>
	/// <para>To remove the <c>PhoneNumberList</c>, set <c>PhoneNumberList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PhoneNumberList PhoneNumberList
	{
		get
		{
			return (PhoneNumberList)GetChild( StudentDTD.STUDENTCONTACT_PHONENUMBERLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_PHONENUMBERLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_PHONENUMBERLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;EmailList&gt;</c> element.</summary>
	/// <param name="Email">An Email</param>
	///<remarks>
	/// <para>This form of <c>setEmailList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>EmailList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetEmailList( Email Email ) {
		RemoveChild( StudentDTD.STUDENTCONTACT_EMAILLIST);
		AddChild( StudentDTD.STUDENTCONTACT_EMAILLIST, new EmailList( Email ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmailList&gt;</c> element.
	/// </summary>
	/// <value> An EmailList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The contact's e-mail address(es)."</para>
	/// <para>To remove the <c>EmailList</c>, set <c>EmailList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public EmailList EmailList
	{
		get
		{
			return (EmailList)GetChild( StudentDTD.STUDENTCONTACT_EMAILLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_EMAILLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_EMAILLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Relationship&gt;</c> element.
	/// </summary>
	/// <value> The <c>Relationship</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Defines the relationship of the contact to the student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Relationship
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTCONTACT_RELATIONSHIP );
		}
		set
		{
			SetField( StudentDTD.STUDENTCONTACT_RELATIONSHIP, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Relationship&gt;</c> element.
	/// </summary>
	/// <param name="val">A AU0609RelationshipToStudentType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Defines the relationship of the contact to the student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetRelationship( AU0609RelationshipToStudentType val )
	{
		SetField( StudentDTD.STUDENTCONTACT_RELATIONSHIP, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmploymentType&gt;</c> element.
	/// </summary>
	/// <value> The <c>EmploymentType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code that defines employment type. This is compulsory for Parents or Guardians of the Student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string EmploymentType
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTCONTACT_EMPLOYMENTTYPE );
		}
		set
		{
			SetField( StudentDTD.STUDENTCONTACT_EMPLOYMENTTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;EmploymentType&gt;</c> element.
	/// </summary>
	/// <param name="val">A EmploymentType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code that defines employment type. This is compulsory for Parents or Guardians of the Student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetEmploymentType( EmploymentType val )
	{
		SetField( StudentDTD.STUDENTCONTACT_EMPLOYMENTTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolEducationalLevel&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolEducationalLevel</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The highest level of education completed by the contact person."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolEducationalLevel
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACT_SCHOOLEDUCATIONALLEVEL ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACT_SCHOOLEDUCATIONALLEVEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NonSchoolEducation&gt;</c> element.
	/// </summary>
	/// <value> The <c>NonSchoolEducation</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This reflects the level of the Contact‚Äôs Non-School Education."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string NonSchoolEducation
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTCONTACT_NONSCHOOLEDUCATION );
		}
		set
		{
			SetField( StudentDTD.STUDENTCONTACT_NONSCHOOLEDUCATION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;NonSchoolEducation&gt;</c> element.
	/// </summary>
	/// <param name="val">A NonSchoolEducationType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This reflects the level of the Contact‚Äôs Non-School Education."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetNonSchoolEducation( NonSchoolEducationType val )
	{
		SetField( StudentDTD.STUDENTCONTACT_NONSCHOOLEDUCATION, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ContactFlags&gt;</c> element.
	/// </summary>
	/// <value> A ContactFlags </value>
	/// <remarks>
	/// <para>To remove the <c>ContactFlags</c>, set <c>ContactFlags</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ContactFlags ContactFlags
	{
		get
		{
			return (ContactFlags)GetChild( StudentDTD.STUDENTCONTACT_CONTACTFLAGS);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACT_CONTACTFLAGS);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACT_CONTACTFLAGS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MainlySpeaksEnglishAtHome&gt;</c> element.
	/// </summary>
	/// <value> The <c>MainlySpeaksEnglishAtHome</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is English the main language spoken at home?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string MainlySpeaksEnglishAtHome
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTCONTACT_MAINLYSPEAKSENGLISHATHOME );
		}
		set
		{
			SetField( StudentDTD.STUDENTCONTACT_MAINLYSPEAKSENGLISHATHOME, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;MainlySpeaksEnglishAtHome&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is English the main language spoken at home?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetMainlySpeaksEnglishAtHome( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTCONTACT_MAINLYSPEAKSENGLISHATHOME, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ContactSequence&gt;</c> element.
	/// </summary>
	/// <value> The <c>ContactSequence</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number indicating the order in which the person should be contacted."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? ContactSequence
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACT_CONTACTSEQUENCE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACT_CONTACTSEQUENCE, new SifInt( value ), value );
		}
	}

}}
