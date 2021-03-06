// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using OpenADK.Util;
using OpenADK.Library;
using OpenADK.Library.Impl;
using CommonDTD = OpenADK.Library.us.Common.CommonDTD;
using ReportingDTD = OpenADK.Library.us.Reporting.ReportingDTD;

namespace OpenADK.Library.us.Dw
{

// BEGIN FILE... (SIFDTD_Comments_CS.txt)

	/// <summary>Metadata for the Schools Interoperability Framework (SIF)</summary>
	/// <remarks>
	/// <para>
	/// SIFDTD defines global {@linkplain com.edustructures.sifworks.ElementDef} 
	/// constants that describe SIF Data Objects, elements, and attributes across all 
	/// supported versions of the SIF Specification. The ADK uses this metadata 
	/// internally to parse and render SIF Data Objects.  In addition, many of the 
	/// framework APIs require that the programmer pass an ElementDef constant from 
	/// the SIFDTD class to identify an object, element, or attribute.
	/// </para>
	/// <para>
	/// ElementDef constants are named <c>[PARENT_]ENTITY</c>, where 
	/// <c>PARENT</c> is the name of the parent element and 
	/// <c>ENTITY</c> is the name of the element or attribute 
	/// encapsulated by the ElementDef. Some examples of ElementDef constants defined
	/// by this class include:
	/// </para>
	/// <list type="table">
	/// <listheader><term>IElementDef</term><description>Description</description></listheader>
	/// <item><term><c>SIFDTD.STUDENTPERSONAL</c></term><description>Identifies the StudentPersonal data object</description></item>
	/// <item><term><c>SIFDTD.SCHOOLINFO</c></term><description>Identifies the SchoolInfo data object</description></item>
	/// </list>
	/// Many of the Adk's public interfaces require an ElementDef constant to be passed
	/// as a parameter. For example, the first parameter to the <see cref="IZone.SetSubscriber"/>
	/// method is an IElementDef:
	/// <code>myZone.setSubscriber( SIFDTD.BUSINFO, this, ADKFlags.PROV_SUBSCRIBE );</code>
	/// ElementDef also identifies child elements and attributes as demonstrated by the	<c>Query.AddCondition</c> method:
	/// <code>
	/// Query query = new Query( SifDtd.STUDENTPERSONAL );
	/// query.AddCondition( SifDtd.STUDENTPERSONAL_REFID, Condition.EQ, "4A37969803F0D00322AF0EB969038483" );
	/// </code>
	/// <para>
	/// <b>SDO Libraries</b>
	/// </para>
	/// <para>
	/// ElementDef metadata is grouped into "SDO Libraries", which are organized along 
	/// SIF Working Group boundaries. SDO Libraries are loaded into the <c>SifDdt</c> 
	/// class when the Adk is initialized. All or part of the metadata is loaded into depending on the flags passed to the
	/// <see cref="Adk.Initialize(SifVersion, SdoLibraryType)"/> method,
	/// metadata from one or more SDO Libraries may be loaded. For example, the following
	/// call loads metadata for the <c>Student Information Working Group Objects</c>  
	/// and <c>Transportation And Geographic Information Working Group Objects</c> 
	/// (Common Elements and <c>Infrastructure Working Group Objects</c> metadata is always loaded
	/// </para>
	/// <code>Adk.Initialize( SiFVersion.LATEST, SdoLibraryType.Student | SdoLibraryType.Trans )</code>
	/// <para>
	/// If an given SDO Library is not loaded, all of the SIFDTD constants that belong
	/// to that library will be <code>null</code> and cannot be referenced. For example,
	/// given the SDO Libraries loaded above, attempting to reference the 
	/// <code>SIFDTD.LIBRARYPATRONSTATUS</code> object from the Library Automation Working
	/// Group would result in a NullPointerException:
	/// </para>
	/// <code>SifDtd.LIBRARYPATRONSTATUS.Name;</code>
	/// </remarks>
	public class DwDTD : OpenADK.Library.Impl.SdoLibraryImpl
	{
	/** Defines the &lt;AggregateCharacteristicInfo&gt; SIF Data Object */
	public static IElementDef AGGREGATECHARACTERISTICINFO = null;
	/** Defines the &lt;AggregateCharacteristicInfoRefId&gt; SIF Data Object */
	public static IElementDef AGGREGATECHARACTERISTICINFOREFID = null;
	/** Defines the &lt;AggregateStatisticFact&gt; SIF Data Object */
	public static IElementDef AGGREGATESTATISTICFACT = null;
	/** Defines the &lt;AggregateStatisticInfo&gt; SIF Data Object */
	public static IElementDef AGGREGATESTATISTICINFO = null;
	/** Defines the &lt;CalculationRule&gt; SIF Data Object */
	public static IElementDef CALCULATIONRULE = null;
	/** Defines the &lt;Characteristics&gt; SIF Data Object */
	public static IElementDef CHARACTERISTICS = null;
	/** Defines the &lt;ExclusionRule&gt; SIF Data Object */
	public static IElementDef EXCLUSIONRULE = null;
	/** Defines the &lt;ExclusionRules&gt; SIF Data Object */
	public static IElementDef EXCLUSIONRULES = null;
	/** Defines the &lt;Location&gt; SIF Data Object */
	public static IElementDef LOCATION = null;
	/** Defines the &lt;LocationRefId&gt; SIF Data Object */
	public static IElementDef LOCATIONREFID = null;


	// Field elements of AGGREGATECHARACTERISTICINFO (4 fields)
	/** Defines the RefId attribute as a child of &lt;AggregateCharacteristicInfo&gt; */
	public static IElementDef AGGREGATECHARACTERISTICINFO_REFID = null;
	/** Defines the &lt;Description&gt; element as a child of &lt;AggregateCharacteristicInfo&gt; */
	public static IElementDef AGGREGATECHARACTERISTICINFO_DESCRIPTION = null;
	/** Defines the &lt;Definition&gt; element as a child of &lt;AggregateCharacteristicInfo&gt; */
	public static IElementDef AGGREGATECHARACTERISTICINFO_DEFINITION = null;
	/** Defines the &lt;ElementName&gt; element as a child of &lt;AggregateCharacteristicInfo&gt; */
	public static IElementDef AGGREGATECHARACTERISTICINFO_ELEMENTNAME = null;
	/** SIF 1.5 and later: Defines the built-in SIF_ExtendedElements element common to all SIF Data Objects */
	public static IElementDef AGGREGATECHARACTERISTICINFO_SIF_EXTENDEDELEMENTS = null;
	/** SIF 2.0 and later: Defines the built-in SIF_Metadata element common to all SIF Data Objects */
	public static IElementDef AGGREGATECHARACTERISTICINFO_SIF_METADATA = null;

	// Field elements of AGGREGATECHARACTERISTICINFOREFID (0 fields)

	// Field elements of AGGREGATESTATISTICFACT (5 fields)
	/** Defines the RefId attribute as a child of &lt;AggregateStatisticFact&gt; */
	public static IElementDef AGGREGATESTATISTICFACT_REFID = null;
	/** Defines the &lt;Characteristics&gt; element as a child of &lt;AggregateStatisticFact&gt; */
	public static IElementDef AGGREGATESTATISTICFACT_CHARACTERISTICS = null;
	/** Defines the &lt;AggregateStatisticInfoRefId&gt; element as a child of &lt;AggregateStatisticFact&gt; */
	public static IElementDef AGGREGATESTATISTICFACT_AGGREGATESTATISTICINFOREFID = null;
	/** Defines the &lt;Excluded&gt; element as a child of &lt;AggregateStatisticFact&gt; */
	public static IElementDef AGGREGATESTATISTICFACT_EXCLUDED = null;
	/** Defines the &lt;Value&gt; element as a child of &lt;AggregateStatisticFact&gt; */
	public static IElementDef AGGREGATESTATISTICFACT_VALUE = null;
	/** SIF 1.5 and later: Defines the built-in SIF_ExtendedElements element common to all SIF Data Objects */
	public static IElementDef AGGREGATESTATISTICFACT_SIF_EXTENDEDELEMENTS = null;
	/** SIF 2.0 and later: Defines the built-in SIF_Metadata element common to all SIF Data Objects */
	public static IElementDef AGGREGATESTATISTICFACT_SIF_METADATA = null;

	// Field elements of AGGREGATESTATISTICINFO (11 fields)
	/** Defines the RefId attribute as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_REFID = null;
	/** Defines the &lt;StatisticName&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_STATISTICNAME = null;
	/** Defines the &lt;CalculationRule&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_CALCULATIONRULE = null;
	/** Defines the &lt;ApprovalDate&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_APPROVALDATE = null;
	/** Defines the &lt;ExpirationDate&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_EXPIRATIONDATE = null;
	/** Defines the &lt;ExclusionRules&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_EXCLUSIONRULES = null;
	/** Defines the &lt;Source&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_SOURCE = null;
	/** Defines the &lt;EffectiveDate&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_EFFECTIVEDATE = null;
	/** Defines the &lt;DiscontinueDate&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_DISCONTINUEDATE = null;
	/** Defines the &lt;Location&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_LOCATION = null;
	/** Defines the &lt;Measure&gt; element as a child of &lt;AggregateStatisticInfo&gt; */
	public static IElementDef AGGREGATESTATISTICINFO_MEASURE = null;
	/** SIF 1.5 and later: Defines the built-in SIF_ExtendedElements element common to all SIF Data Objects */
	public static IElementDef AGGREGATESTATISTICINFO_SIF_EXTENDEDELEMENTS = null;
	/** SIF 2.0 and later: Defines the built-in SIF_Metadata element common to all SIF Data Objects */
	public static IElementDef AGGREGATESTATISTICINFO_SIF_METADATA = null;

	// Field elements of CALCULATIONRULE (1 fields)
	/** Defines the Type attribute as a child of &lt;CalculationRule&gt; */
	public static IElementDef CALCULATIONRULE_TYPE = null;

	// Field elements of CHARACTERISTICS (1 fields)
	/** Defines the &lt;AggregateCharacteristicInfoRefId&gt; element as a child of &lt;Characteristics&gt; */
	public static IElementDef CHARACTERISTICS_AGGREGATECHARACTERISTICINFOREFID = null;

	// Field elements of EXCLUSIONRULE (1 fields)
	/** Defines the Type attribute as a child of &lt;ExclusionRule&gt; */
	public static IElementDef EXCLUSIONRULE_TYPE = null;

	// Field elements of EXCLUSIONRULES (1 fields)
	/** Defines the &lt;ExclusionRule&gt; element as a child of &lt;ExclusionRules&gt; */
	public static IElementDef EXCLUSIONRULES_EXCLUSIONRULE = null;

	// Field elements of LOCATION (3 fields)
	/** Defines the Type attribute as a child of &lt;Location&gt; */
	public static IElementDef LOCATION_TYPE = null;
	/** Defines the &lt;LocationName&gt; element as a child of &lt;Location&gt; */
	public static IElementDef LOCATION_LOCATIONNAME = null;
	/** Defines the &lt;LocationRefId&gt; element as a child of &lt;Location&gt; */
	public static IElementDef LOCATION_LOCATIONREFID = null;

	// Field elements of LOCATIONREFID (1 fields)
	/** Defines the SIF_RefObject attribute as a child of &lt;LocationRefId&gt; */
	public static IElementDef LOCATIONREFID_SIF_REFOBJECT = null;

	public override void Load()
	{
		//  Objects defined by this SDO Library...

		AGGREGATECHARACTERISTICINFO = new ElementDefImpl( null, "AggregateCharacteristicInfo", null, 0, SifDtd.DW, "us", (ElementDefImpl.FD_OBJECT), SifVersion.SIF15r1, SifVersion.SIF26 );
		AGGREGATECHARACTERISTICINFOREFID = new ElementDefImpl( null, "AggregateCharacteristicInfoRefId", null, 0, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		AGGREGATESTATISTICFACT = new ElementDefImpl( null, "AggregateStatisticFact", null, 0, SifDtd.DW, "us", (ElementDefImpl.FD_OBJECT), SifVersion.SIF15r1, SifVersion.SIF26 );
		AGGREGATESTATISTICINFO = new ElementDefImpl( null, "AggregateStatisticInfo", null, 0, SifDtd.DW, "us", (ElementDefImpl.FD_OBJECT), SifVersion.SIF15r1, SifVersion.SIF26 );
		CALCULATIONRULE = new ElementDefImpl( null, "CalculationRule", null, 0, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		CHARACTERISTICS = new ElementDefImpl( null, "Characteristics", null, 0, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26 );
		EXCLUSIONRULE = new ElementDefImpl( null, "ExclusionRule", null, 0, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		EXCLUSIONRULES = new ElementDefImpl( null, "ExclusionRules", null, 0, SifDtd.DW, "us", 0, SifVersion.SIF20, SifVersion.SIF26 );
		LOCATION = new ElementDefImpl( null, "Location", null, 0, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26 );
		LOCATIONREFID = new ElementDefImpl( null, "LocationRefId", null, 0, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );


		// <AggregateCharacteristicInfo> fields (4 entries)
		DwDTD.AGGREGATECHARACTERISTICINFO_REFID = new ElementDefImpl( AGGREGATECHARACTERISTICINFO, "RefId", null, 1, SifDtd.DW, "us", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATECHARACTERISTICINFO_DESCRIPTION = new ElementDefImpl( AGGREGATECHARACTERISTICINFO, "Description", null, 2, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATECHARACTERISTICINFO_DEFINITION = new ElementDefImpl( AGGREGATECHARACTERISTICINFO, "Definition", null, 3, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATECHARACTERISTICINFO_ELEMENTNAME = new ElementDefImpl( AGGREGATECHARACTERISTICINFO, "ElementName", null, 4, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		AGGREGATECHARACTERISTICINFO_SIF_EXTENDEDELEMENTS = new ElementDefImpl( AGGREGATECHARACTERISTICINFO, "SIF_ExtendedElements", null, 127, SifDtd.GLOBAL, null, (0), SifVersion.SIF15r1, SifVersion.SIF26 );
		AGGREGATECHARACTERISTICINFO_SIF_METADATA = new ElementDefImpl( AGGREGATECHARACTERISTICINFO, "SIF_Metadata", null, 128, SifDtd.DATAMODEL, "us", (0), SifVersion.SIF20, SifVersion.SIF26 );

		// <AggregateCharacteristicInfoRefId> fields (0 entries)

		// <AggregateStatisticFact> fields (5 entries)
		DwDTD.AGGREGATESTATISTICFACT_REFID = new ElementDefImpl( AGGREGATESTATISTICFACT, "RefId", null, 1, SifDtd.DW, "us", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICFACT_CHARACTERISTICS = new ElementDefImpl( AGGREGATESTATISTICFACT, "Characteristics", null, 2, SifDtd.DW, "us", (ElementDefImpl.FD_COLLAPSE), SifVersion.SIF15r1, SifVersion.SIF26 );
		DwDTD.AGGREGATESTATISTICFACT_CHARACTERISTICS.DefineVersionInfo(SifVersion.SIF20, "Characteristics", 3, 0); // (Sif 20 alias)
		DwDTD.AGGREGATESTATISTICFACT_AGGREGATESTATISTICINFOREFID = new ElementDefImpl( AGGREGATESTATISTICFACT, "AggregateStatisticInfoRefId", "~XPathSurrogate{Statistic/@AggregateStatisticInfoRefId=.}Statistic", 3, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICFACT_AGGREGATESTATISTICINFOREFID.DefineVersionInfo(SifVersion.SIF20, "AggregateStatisticInfoRefId", 2, (ElementDefImpl.FD_FIELD)); // (Sif 20 alias)
		DwDTD.AGGREGATESTATISTICFACT_EXCLUDED = new ElementDefImpl( AGGREGATESTATISTICFACT, "Excluded", null, 4, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICFACT_VALUE = new ElementDefImpl( AGGREGATESTATISTICFACT, "Value", null, 5, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.DECIMAL );
		AGGREGATESTATISTICFACT_SIF_EXTENDEDELEMENTS = new ElementDefImpl( AGGREGATESTATISTICFACT, "SIF_ExtendedElements", null, 127, SifDtd.GLOBAL, null, (0), SifVersion.SIF15r1, SifVersion.SIF26 );
		AGGREGATESTATISTICFACT_SIF_METADATA = new ElementDefImpl( AGGREGATESTATISTICFACT, "SIF_Metadata", null, 128, SifDtd.DATAMODEL, "us", (0), SifVersion.SIF20, SifVersion.SIF26 );

		// <AggregateStatisticInfo> fields (11 entries)
		DwDTD.AGGREGATESTATISTICINFO_REFID = new ElementDefImpl( AGGREGATESTATISTICINFO, "RefId", null, 1, SifDtd.DW, "us", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICINFO_STATISTICNAME = new ElementDefImpl( AGGREGATESTATISTICINFO, "StatisticName", null, 2, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICINFO_CALCULATIONRULE = new ElementDefImpl( AGGREGATESTATISTICINFO, "CalculationRule", null, 3, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICINFO_APPROVALDATE = new ElementDefImpl( AGGREGATESTATISTICINFO, "ApprovalDate", null, 4, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.DATE );
		DwDTD.AGGREGATESTATISTICINFO_EXPIRATIONDATE = new ElementDefImpl( AGGREGATESTATISTICINFO, "ExpirationDate", null, 5, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.DATE );
		DwDTD.AGGREGATESTATISTICINFO_EXCLUSIONRULES = new ElementDefImpl( AGGREGATESTATISTICINFO, "ExclusionRules", null, 6, SifDtd.DW, "us", (ElementDefImpl.FD_COLLAPSE), SifVersion.SIF15r1, SifVersion.SIF26 );
		DwDTD.AGGREGATESTATISTICINFO_EXCLUSIONRULES.DefineVersionInfo(SifVersion.SIF20, "ExclusionRules", 6, 0); // (Sif 20 alias)
		DwDTD.AGGREGATESTATISTICINFO_SOURCE = new ElementDefImpl( AGGREGATESTATISTICINFO, "Source", null, 7, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICINFO_EFFECTIVEDATE = new ElementDefImpl( AGGREGATESTATISTICINFO, "EffectiveDate", null, 8, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.DATE );
		DwDTD.AGGREGATESTATISTICINFO_DISCONTINUEDATE = new ElementDefImpl( AGGREGATESTATISTICINFO, "DiscontinueDate", null, 9, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.DATE );
		DwDTD.AGGREGATESTATISTICINFO_LOCATION = new ElementDefImpl( AGGREGATESTATISTICINFO, "Location", null, 10, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26 );
		DwDTD.AGGREGATESTATISTICINFO_MEASURE = new ElementDefImpl( AGGREGATESTATISTICINFO, "Measure", "~XPathSurrogate{Measure/@Type=.}", 11, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.AGGREGATESTATISTICINFO_MEASURE.DefineVersionInfo(SifVersion.SIF20, "Measure", 11, (ElementDefImpl.FD_FIELD)); // (Sif 20 alias)
		AGGREGATESTATISTICINFO_SIF_EXTENDEDELEMENTS = new ElementDefImpl( AGGREGATESTATISTICINFO, "SIF_ExtendedElements", null, 127, SifDtd.GLOBAL, null, (0), SifVersion.SIF15r1, SifVersion.SIF26 );
		AGGREGATESTATISTICINFO_SIF_METADATA = new ElementDefImpl( AGGREGATESTATISTICINFO, "SIF_Metadata", null, 128, SifDtd.DATAMODEL, "us", (0), SifVersion.SIF20, SifVersion.SIF26 );

		// <CalculationRule> fields (1 entries)
		DwDTD.CALCULATIONRULE_TYPE = new ElementDefImpl( CALCULATIONRULE, "Type", null, 1, SifDtd.DW, "us", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );

		// <Characteristics> fields (1 entries)
		DwDTD.CHARACTERISTICS_AGGREGATECHARACTERISTICINFOREFID = new ElementDefImpl( CHARACTERISTICS, "AggregateCharacteristicInfoRefId", "~XPathSurrogate{Characteristic/@AggregateCharacteristicInfoRefId=.}Characteristic", 1, SifDtd.DW, "us", (ElementDefImpl.FD_REPEATABLE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.CHARACTERISTICS_AGGREGATECHARACTERISTICINFOREFID.DefineVersionInfo(SifVersion.SIF20, "AggregateCharacteristicInfoRefId", 1, (ElementDefImpl.FD_REPEATABLE)); // (Sif 20 alias)

		// <ExclusionRule> fields (1 entries)
		DwDTD.EXCLUSIONRULE_TYPE = new ElementDefImpl( EXCLUSIONRULE, "Type", null, 1, SifDtd.DW, "us", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );

		// <ExclusionRules> fields (1 entries)
		DwDTD.EXCLUSIONRULES_EXCLUSIONRULE = new ElementDefImpl( EXCLUSIONRULES, "ExclusionRule", null, 1, SifDtd.DW, "us", (ElementDefImpl.FD_REPEATABLE), SifVersion.SIF20, SifVersion.SIF26, SifTypeConverters.STRING );

		// <Location> fields (3 entries)
		DwDTD.LOCATION_TYPE = new ElementDefImpl( LOCATION, "Type", null, 1, SifDtd.DW, "us", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.LOCATION_LOCATIONNAME = new ElementDefImpl( LOCATION, "LocationName", null, 2, SifDtd.DW, "us", (ElementDefImpl.FD_FIELD), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.LOCATION_LOCATIONREFID = new ElementDefImpl( LOCATION, "LocationRefId", null, 3, SifDtd.DW, "us", 0, SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );

		// <LocationRefId> fields (1 entries)
		DwDTD.LOCATIONREFID_SIF_REFOBJECT = new ElementDefImpl( LOCATIONREFID, "SIF_RefObject", "ObjectName", 1, SifDtd.DW, "us", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF15r1, SifVersion.SIF26, SifTypeConverters.STRING );
		DwDTD.LOCATIONREFID_SIF_REFOBJECT.DefineVersionInfo(SifVersion.SIF20, "SIF_RefObject", 1, (ElementDefImpl.FD_ATTRIBUTE)); // (Sif 20 alias)
	}

	#region Update SifDtd
	public override void AddElementMappings( IDictionary<String, IElementDef> dictionary )
	{
		dictionary[ "AggregateStatisticInfo" ] = AGGREGATESTATISTICINFO;
		dictionary[ "AggregateStatisticInfo_SIF_ExtendedElements" ] = AGGREGATESTATISTICINFO_SIF_EXTENDEDELEMENTS ;
		dictionary[ "AggregateStatisticInfo_SIF_Metadata" ] = AGGREGATESTATISTICINFO_SIF_METADATA;
		dictionary["AggregateStatisticInfo_ApprovalDate"] = DwDTD.AGGREGATESTATISTICINFO_APPROVALDATE ;
		dictionary["AggregateStatisticInfo_CalculationRule"] = DwDTD.AGGREGATESTATISTICINFO_CALCULATIONRULE ;
		dictionary["AggregateStatisticInfo_DiscontinueDate"] = DwDTD.AGGREGATESTATISTICINFO_DISCONTINUEDATE ;
		dictionary["AggregateStatisticInfo_EffectiveDate"] = DwDTD.AGGREGATESTATISTICINFO_EFFECTIVEDATE ;
		dictionary["AggregateStatisticInfo_ExclusionRule"] = DwDTD.EXCLUSIONRULES_EXCLUSIONRULE ;//Collapsed in 1.5r1
		dictionary["AggregateStatisticInfo_ExclusionRules"] = DwDTD.AGGREGATESTATISTICINFO_EXCLUSIONRULES ;
		dictionary["AggregateStatisticInfo_ExpirationDate"] = DwDTD.AGGREGATESTATISTICINFO_EXPIRATIONDATE ;
		dictionary["AggregateStatisticInfo_Location"] = DwDTD.AGGREGATESTATISTICINFO_LOCATION ;
		dictionary["AggregateStatisticInfo_Measure"] = DwDTD.AGGREGATESTATISTICINFO_MEASURE ;
		dictionary["AggregateStatisticInfo_RefId"] = DwDTD.AGGREGATESTATISTICINFO_REFID ;
		dictionary["AggregateStatisticInfo_Source"] = DwDTD.AGGREGATESTATISTICINFO_SOURCE ;
		dictionary["AggregateStatisticInfo_StatisticName"] = DwDTD.AGGREGATESTATISTICINFO_STATISTICNAME ;
		dictionary[ "ExclusionRules" ] = EXCLUSIONRULES;
		dictionary["ExclusionRules_ExclusionRule"] = DwDTD.EXCLUSIONRULES_EXCLUSIONRULE ;
		dictionary[ "Characteristics" ] = CHARACTERISTICS;
		dictionary["Characteristics_AggregateCharacteristicInfoRefId"] = DwDTD.CHARACTERISTICS_AGGREGATECHARACTERISTICINFOREFID ;//2.0 alias
		dictionary["Characteristics_Characteristic"] = DwDTD.CHARACTERISTICS_AGGREGATECHARACTERISTICINFOREFID ;
		dictionary[ "ExclusionRule" ] = EXCLUSIONRULE;
		dictionary["ExclusionRule_Type"] = DwDTD.EXCLUSIONRULE_TYPE ;
		dictionary[ "AggregateCharacteristicInfoRefId" ] = AGGREGATECHARACTERISTICINFOREFID;
		dictionary[ "LocationRefId" ] = LOCATIONREFID;
		dictionary["LocationRefId_ObjectName"] = DwDTD.LOCATIONREFID_SIF_REFOBJECT ;
		dictionary["LocationRefId_SIF_RefObject"] = DwDTD.LOCATIONREFID_SIF_REFOBJECT ;//2.0 alias
		dictionary[ "Location" ] = LOCATION;
		dictionary["Location_LocationName"] = DwDTD.LOCATION_LOCATIONNAME ;
		dictionary["Location_LocationRefId"] = DwDTD.LOCATION_LOCATIONREFID ;
		dictionary["Location_Type"] = DwDTD.LOCATION_TYPE ;
		dictionary[ "AggregateStatisticFact" ] = AGGREGATESTATISTICFACT;
		dictionary[ "AggregateStatisticFact_SIF_ExtendedElements" ] = AGGREGATESTATISTICFACT_SIF_EXTENDEDELEMENTS ;
		dictionary[ "AggregateStatisticFact_SIF_Metadata" ] = AGGREGATESTATISTICFACT_SIF_METADATA;
		dictionary["AggregateStatisticFact_AggregateStatisticInfoRefId"] = DwDTD.AGGREGATESTATISTICFACT_AGGREGATESTATISTICINFOREFID ;//2.0 alias
		dictionary["AggregateStatisticFact_Characteristic"] = DwDTD.CHARACTERISTICS_AGGREGATECHARACTERISTICINFOREFID ;//Collapsed in 1.5r1
		dictionary["AggregateStatisticFact_Characteristics"] = DwDTD.AGGREGATESTATISTICFACT_CHARACTERISTICS ;
		dictionary["AggregateStatisticFact_Excluded"] = DwDTD.AGGREGATESTATISTICFACT_EXCLUDED ;
		dictionary["AggregateStatisticFact_RefId"] = DwDTD.AGGREGATESTATISTICFACT_REFID ;
		dictionary["AggregateStatisticFact_Statistic"] = DwDTD.AGGREGATESTATISTICFACT_AGGREGATESTATISTICINFOREFID ;
		dictionary["AggregateStatisticFact_Value"] = DwDTD.AGGREGATESTATISTICFACT_VALUE ;
		dictionary[ "AggregateCharacteristicInfo" ] = AGGREGATECHARACTERISTICINFO;
		dictionary[ "AggregateCharacteristicInfo_SIF_ExtendedElements" ] = AGGREGATECHARACTERISTICINFO_SIF_EXTENDEDELEMENTS ;
		dictionary[ "AggregateCharacteristicInfo_SIF_Metadata" ] = AGGREGATECHARACTERISTICINFO_SIF_METADATA;
		dictionary["AggregateCharacteristicInfo_Definition"] = DwDTD.AGGREGATECHARACTERISTICINFO_DEFINITION ;
		dictionary["AggregateCharacteristicInfo_Description"] = DwDTD.AGGREGATECHARACTERISTICINFO_DESCRIPTION ;
		dictionary["AggregateCharacteristicInfo_ElementName"] = DwDTD.AGGREGATECHARACTERISTICINFO_ELEMENTNAME ;
		dictionary["AggregateCharacteristicInfo_RefId"] = DwDTD.AGGREGATECHARACTERISTICINFO_REFID ;
		dictionary[ "CalculationRule" ] = CALCULATIONRULE;
		dictionary["CalculationRule_Type"] = DwDTD.CALCULATIONRULE_TYPE ;
	}
	#endregion
}}
