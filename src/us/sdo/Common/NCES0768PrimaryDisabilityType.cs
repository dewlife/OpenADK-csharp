// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a NCES0768PrimaryDisabilityType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a NCES0768PrimaryDisabilityType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class NCES0768PrimaryDisabilityType : SifEnum
	{
	/// <summary>Visual impairment ("2131")</summary>
	public static readonly NCES0768PrimaryDisabilityType VISUAL_IMPAIRMENT = new NCES0768PrimaryDisabilityType("2131");

	/// <summary>Traumatic brain injury ("2130")</summary>
	public static readonly NCES0768PrimaryDisabilityType TRAUMATIC_BRAIN_INJURY = new NCES0768PrimaryDisabilityType("2130");

	/// <summary>Deafness ("2133")</summary>
	public static readonly NCES0768PrimaryDisabilityType DEAFNESS = new NCES0768PrimaryDisabilityType("2133");

	/// <summary>Emotional Disturbance ("2127")</summary>
	public static readonly NCES0768PrimaryDisabilityType EMOTIONAL_DISTURBANCE = new NCES0768PrimaryDisabilityType("2127");

	/// <summary>Mental retardation ("2124")</summary>
	public static readonly NCES0768PrimaryDisabilityType MENTAL_RETARDATION = new NCES0768PrimaryDisabilityType("2124");

	/// <summary>Developmental delay ("2134")</summary>
	public static readonly NCES0768PrimaryDisabilityType DEVELOPMENTAL_DELAY = new NCES0768PrimaryDisabilityType("2134");

	/// <summary>Orthopedic impairment ("2126")</summary>
	public static readonly NCES0768PrimaryDisabilityType ORTHOPEDIC_IMPAIRMENT = new NCES0768PrimaryDisabilityType("2126");

	/// <summary>Autistic/Autism ("2121")</summary>
	public static readonly NCES0768PrimaryDisabilityType AUTISTIC_AUTISM = new NCES0768PrimaryDisabilityType("2121");

	/// <summary>Multiple disabilities ("2125")</summary>
	public static readonly NCES0768PrimaryDisabilityType MULTIPLE_DISABILITIES = new NCES0768PrimaryDisabilityType("2125");

	/// <summary>Deaf-blindness ("2122")</summary>
	public static readonly NCES0768PrimaryDisabilityType DEAF_BLINDNESS = new NCES0768PrimaryDisabilityType("2122");

	/// <summary>Hearing impairment ("2123")</summary>
	public static readonly NCES0768PrimaryDisabilityType HEARING_IMPAIRMENT = new NCES0768PrimaryDisabilityType("2123");

	/// <summary>Other health impairment ("2132")</summary>
	public static readonly NCES0768PrimaryDisabilityType OTHER_HEALTH_IMPAIRMENT = new NCES0768PrimaryDisabilityType("2132");

	/// <summary>Infants and Toddlers with Disabilities ("2135")</summary>
	public static readonly NCES0768PrimaryDisabilityType INFANTS_AND_TODDLERS_WITH_DISABILITIES = new NCES0768PrimaryDisabilityType("2135");

	/// <summary>Specific learning disability ("2128")</summary>
	public static readonly NCES0768PrimaryDisabilityType SPECIFIC_LEARNING_DISABILITY = new NCES0768PrimaryDisabilityType("2128");

	/// <summary>Speech or language impairment ("2129")</summary>
	public static readonly NCES0768PrimaryDisabilityType SPEECH_OR_LANGUAGE_IMPAIRMENT = new NCES0768PrimaryDisabilityType("2129");

	///<summary>Wrap an arbitrary string value in a NCES0768PrimaryDisabilityType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static NCES0768PrimaryDisabilityType Wrap( String wrappedValue ) {
		return new NCES0768PrimaryDisabilityType( wrappedValue );
	}

	private NCES0768PrimaryDisabilityType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
