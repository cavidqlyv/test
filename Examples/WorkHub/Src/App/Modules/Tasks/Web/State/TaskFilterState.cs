﻿using System;
using SoftwareMonkeys.WorkHub.State;

namespace SoftwareMonkeys.WorkHub.Modules.Tasks.Web.State
{
	/// <summary>
	/// Stores the state of the current user's task filter preferences.
	/// </summary>
	static public class TaskFilterState
	{
		static private StateNameValueCollection<bool> filterFlags;
		static public StateNameValueCollection<bool> FilterFlags
		{
			get {
				if (filterFlags == null)
					filterFlags = new StateNameValueCollection<bool>(StateScope.Session, "Tasks.TaskFilterFlags");
				
				return filterFlags;
			}
			set { filterFlags = value; }
		}
		
		static public bool ShowPending
		{
			get {
				if (FilterFlags == null || FilterFlags.Keys == null || !FilterFlags.Keys.Contains("ShowPending"))
					return true;
				return FilterFlags["ShowPending"]; }
			set { FilterFlags["ShowPending"] = value; }
		}
		
		static public bool ShowInProgress
		{
			get {
				if (FilterFlags == null || FilterFlags.Keys == null || !FilterFlags.Keys.Contains("ShowInProgress"))
					return true;
				return FilterFlags["ShowInProgress"]; }
			set { FilterFlags["ShowInProgress"] = value; }
		}
		
		static public bool ShowOnHold
		{
			get {
				if (FilterFlags == null || FilterFlags.Keys == null || !FilterFlags.Keys.Contains("ShowOnHold"))
					return false;
				return FilterFlags["ShowOnHold"]; }
			set { FilterFlags["ShowOnHold"] = value; }
		}
		
		static public bool ShowAssigned
		{
			get {
				if (FilterFlags == null || FilterFlags.Keys == null || !FilterFlags.Keys.Contains("ShowAssigned"))
					return true;
				return FilterFlags["ShowAssigned"]; }
			set { FilterFlags["ShowAssigned"] = value; }
		}
		
		static public bool ShowCompleted
		{
			get {
				if (FilterFlags == null || FilterFlags.Keys == null || !FilterFlags.Keys.Contains("ShowCompleted"))
					return false;
				return FilterFlags["ShowCompleted"]; }
			set { FilterFlags["ShowCompleted"] = value; }
		}
		
		static public bool ShowTested
		{
			get {
				if (FilterFlags == null || FilterFlags.Keys == null || !FilterFlags.Keys.Contains("ShowTested"))
					return false;
				return FilterFlags["ShowTested"]; }
			set { FilterFlags["ShowTested"] = value; }
		}
		
	}
}
