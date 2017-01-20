// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace NomadCode.MobileCenter
{
	using System;
	using System.Collections.Generic;
	using System.Net.Http;
	using System.Threading;
	using System.Threading.Tasks;
	using Newtonsoft.Json;
	using Microsoft.Rest;
	using Models;

	/// <summary>
	/// Mobile Center Frontdoor Graph API Service
	/// </summary>
	public partial interface IMobileCenterClient : IDisposable
	{
		/// <summary>
		/// The base URI of the service.
		/// </summary>
		Uri BaseUri { get; set; }

		/// <summary>
		/// Gets or sets json serialization settings.
		/// </summary>
		JsonSerializerSettings SerializationSettings { get; }

		/// <summary>
		/// Gets or sets json deserialization settings.
		/// </summary>
		JsonSerializerSettings DeserializationSettings { get; }

		/// <summary>
		/// The name of the application
		/// </summary>
		string AppName { get; set; }

		/// <summary>
		/// The name of the owner
		/// </summary>
		string OwnerName { get; set; }

		/// <summary>
		/// The app ID
		/// </summary>
		string AppId { get; set; }

		/// <summary>
		/// The build ID
		/// </summary>
		int BuildId { get; set; }

		/// <summary>
		/// The branch name
		/// </summary>
		string Branch { get; set; }

		/// <summary>
		/// The SHA hash
		/// </summary>
		string Sha { get; set; }

		/// <summary>
		/// The selected form of the object. Possible values include: 'lite',
		/// 'full'
		/// </summary>
		string Form { get; set; }

		/// <summary>
		/// An auth token
		/// </summary>
		string Token { get; set; }

		/// <summary>
		/// The ID of the symbol upload
		/// </summary>
		string SymbolUploadId { get; set; }

		/// <summary>
		/// The ID of the symbol (uuid of the symbol)
		/// </summary>
		string SymbolId { get; set; }

		///// <summary>
		///// id of a specific group
		///// </summary>
		//string CrashGroupId { get; set; }

		/// <summary>
		/// id of a specific error
		/// </summary>
		string CrashId { get; set; }

		/// <summary>
		/// version
		/// </summary>
		string AppVersion { get; set; }

		/// <summary>
		/// </summary>
		DateTime? DateFrom { get; set; }

		/// <summary>
		/// </summary>
		DateTime? DateTo { get; set; }

		/// <summary>
		/// Earliest date when the last time a crash occured in a error group
		/// </summary>
		DateTime? LastOccurrenceFrom { get; set; }

		/// <summary>
		/// Latest date when the last time a crash occured in a error group
		/// </summary>
		DateTime? LastOccurrenceTo { get; set; }

		/// <summary>
		/// Possible values include: 'something', 'else'
		/// </summary>
		string ErrorType { get; set; }

		/// <summary>
		/// Possible values include: 'GroupType1', 'GroupType2'
		/// </summary>
		string GroupType { get; set; }

		/// <summary>
		/// Possible values include: 'open', 'closed', 'ignored'
		/// </summary>
		string GroupStatus { get; set; }

		/// <summary>
		/// true if the error should include the raw error report. Default is
		/// false
		/// </summary>
		bool? IncludeReport { get; set; }

		/// <summary>
		/// true if the error should include the custom log report. Default is
		/// false
		/// </summary>
		bool? IncludeLog { get; set; }

		/// <summary>
		/// A freetext search that matches in error, error types, error
		/// stack_traces and error user
		/// </summary>
		string GroupTextSearch { get; set; }

		///// <summary>
		///// Start date time in data in ISO 8601 date time format
		///// </summary>
		//DateTime Start { get; set; }

		/// <summary>
		/// Start date time in data in ISO 8601 date time format. It must be
		/// within the current day in the UTC timezone. The default value is
		/// the start time of the current day in UTC timezone.
		/// </summary>
		DateTime? Start { get; set; }

		/// <summary>
		/// Last date time in data in ISO 8601 date time format
		/// </summary>
		DateTime? End { get; set; }

		/// <summary>
		/// The id of the crash group
		/// </summary>
		string CrashGroupId { get; set; }

		/// <summary>
		/// </summary>
		CrashGroupContainer CrashGroups { get; set; }

		/// <summary>
		/// The id of the event
		/// </summary>
		string EventName { get; set; }

		/// <summary>
		/// The id of the event property
		/// </summary>
		string EventPropertyName { get; set; }

		/// <summary>
		/// Size of interval in ISO 8601 duration format.
		/// (PnYnMnDTnHnMnS|PnW|P&lt;date&gt;T&lt;time&gt;). The valid
		/// durations are 1 day (P1D), 1 week (P1W), and 30 days (P30D).
		/// </summary>
		string Interval { get; set; }

		/// <summary>
		/// </summary>
		IList<string> Versions { get; set; }

		/// <summary>
		/// </summary>
		string Version { get; set; }

		/// <summary>
		/// to select the specific events
		/// </summary>
		IList<string> EventNames { get; set; }

		/// <summary>
		/// The number of results to return
		/// </summary>
		long? Count { get; set; }

		/// <summary>
		/// The maximum number of results to return. (0 will fetch all results)
		/// </summary>
		long? Top { get; set; }

		/// <summary>
		/// The offset (starting at 0) of the first result to return. This
		/// parameter along with limit is used to perform pagination.
		/// </summary>
		long? Skip { get; set; }

		/// <summary>
		/// A filter as specified in
		/// https://github.com/Microsoft/api-guidelines/blob/master/Guidelines.md#97-filtering.
		/// </summary>
		string Filter { get; set; }

		/// <summary>
		/// Controls whether or not to include a count of all the items
		/// accross all pages. Possible values include: 'allpages', 'none'
		/// </summary>
		string Inlinecount { get; set; }

		/// <summary>
		/// controls the sorting order and sorting based on which column
		/// </summary>
		string Orderby { get; set; }

		/// <summary>
		/// Subscription credentials which uniquely identify client
		/// subscription.
		/// </summary>
		ServiceClientCredentials Credentials { get; }


		/// <summary>
		/// Gets the IAccount.
		/// </summary>
		IAccount Account { get; }

		/// <summary>
		/// Gets the IBuildOperations.
		/// </summary>
		IBuildOperations BuildOperations { get; }

		/// <summary>
		/// Gets the ICrashOperations.
		/// </summary>
		ICrashOperations CrashOperations { get; }

		/// <summary>
		/// Gets the ITest.
		/// </summary>
		ITest Test { get; }

		/// <summary>
		/// Gets the IData.
		/// </summary>
		IData Data { get; }

		/// <summary>
		/// Gets the IDistribute.
		/// </summary>
		IDistribute Distribute { get; }

		/// <summary>
		/// Gets the IAnalytics.
		/// </summary>
		IAnalytics Analytics { get; }

	}
}
