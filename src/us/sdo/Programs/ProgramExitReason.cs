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

/// <summary>Required if student has exited the program.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ProgramExitReason : SifElement
{
	/// <summary>
	/// Creates an instance of a ProgramExitReason
	/// </summary>
	public ProgramExitReason() : base ( ProgramsDTD.PROGRAMEXITREASON ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="codeType">If value="NCES" then use code set 0815 Program Exit Reason [NCES Handbooks]</param>
	///
	public ProgramExitReason( ProgramExitReasonCode codeType ) : base( ProgramsDTD.PROGRAMEXITREASON )
	{
		this.SetCodeType( codeType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ProgramExitReason( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>CodeType</c> attribute.
	/// </summary>
	/// <value> The <c>CodeType</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "If value="NCES" then use code set 0815 Program Exit Reason [NCES Handbooks]"</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string CodeType
	{
		get
		{ 
			return GetFieldValue( ProgramsDTD.PROGRAMEXITREASON_CODETYPE );
		}
		set
		{
			SetField( ProgramsDTD.PROGRAMEXITREASON_CODETYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>CodeType</c> attribute.
	/// </summary>
	/// <param name="val">A ProgramExitReasonCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "If value="NCES" then use code set 0815 Program Exit Reason [NCES Handbooks]"</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetCodeType( ProgramExitReasonCode val )
	{
		SetField( ProgramsDTD.PROGRAMEXITREASON_CODETYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Review by program / state.  May be required if student has exited the program."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( ProgramsDTD.PROGRAMEXITREASON_CODE );
		}
		set
		{
			SetField( ProgramsDTD.PROGRAMEXITREASON_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A ProgramExitReasonCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Review by program / state.  May be required if student has exited the program."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetCode( ProgramExitReasonCode val )
	{
		SetField( ProgramsDTD.PROGRAMEXITREASON_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( ProgramsDTD.PROGRAMEXITREASON_OTHERCODELIST);
		}
		set
		{
			RemoveChild( ProgramsDTD.PROGRAMEXITREASON_OTHERCODELIST);
			if( value != null)
			{
				AddChild( ProgramsDTD.PROGRAMEXITREASON_OTHERCODELIST, value );
			}
		}
	}

}}
