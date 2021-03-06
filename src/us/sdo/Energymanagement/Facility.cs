// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Energymanagement
{
	///<summary>
	/// Defines the set of values that can be specified whenever a Facility
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a Facility object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class Facility : SifEnum
	{
	/// <summary>Auditorium ("Auditorium")</summary>
	public static readonly Facility AUDITORIUM = new Facility("Auditorium");

	/// <summary>Swimming Pool ("SwimmingPool")</summary>
	public static readonly Facility SWIMMING_POOL = new Facility("SwimmingPool");

	/// <summary>Home Economics ("HomeEconomics")</summary>
	public static readonly Facility HOME_ECONOMICS = new Facility("HomeEconomics");

	/// <summary>Locker Room ("LockerRoom")</summary>
	public static readonly Facility LOCKER_ROOM = new Facility("LockerRoom");

	/// <summary>Gymnasium ("Gymnasium")</summary>
	public static readonly Facility GYMNASIUM = new Facility("Gymnasium");

	/// <summary>Library ("Library")</summary>
	public static readonly Facility LIBRARY = new Facility("Library");

	/// <summary>Floor ("Floor")</summary>
	public static readonly Facility FLOOR = new Facility("Floor");

	/// <summary>Wing ("Wing")</summary>
	public static readonly Facility WING = new Facility("Wing");

	/// <summary>Shop ("Shop")</summary>
	public static readonly Facility SHOP = new Facility("Shop");

	/// <summary>Storage ("Storage")</summary>
	public static readonly Facility STORAGE = new Facility("Storage");

	/// <summary>Campus ("Campus")</summary>
	public static readonly Facility CAMPUS = new Facility("Campus");

	/// <summary>Building ("Builing")</summary>
	public static readonly Facility BUILDING = new Facility("Builing");

	/// <summary>Study Hall ("StudyHall")</summary>
	public static readonly Facility STUDY_HALL = new Facility("StudyHall");

	/// <summary>Other ("Other")</summary>
	public static readonly Facility OTHER = new Facility("Other");

	/// <summary>Cafeteria ("Cafeteria")</summary>
	public static readonly Facility CAFETERIA = new Facility("Cafeteria");

	/// <summary>office ("Office")</summary>
	public static readonly Facility OFFICE = new Facility("Office");

	/// <summary>Kitchen ("Kitchen")</summary>
	public static readonly Facility KITCHEN = new Facility("Kitchen");

	/// <summary>Classroom ("Classroom")</summary>
	public static readonly Facility CLASSROOM = new Facility("Classroom");

	/// <summary>Hall ("Hall")</summary>
	public static readonly Facility HALL = new Facility("Hall");

	/// <summary>Laboratory ("Laboratory")</summary>
	public static readonly Facility LABORATORY = new Facility("Laboratory");

	///<summary>Wrap an arbitrary string value in a Facility object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static Facility Wrap( String wrappedValue ) {
		return new Facility( wrappedValue );
	}

	private Facility( string enumDefValue ) : base( enumDefValue ) {}
	}
}
