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
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Distribute operations.
    /// </summary>
    public partial interface IDistribute
    {
        /// <summary>
        /// Get a release with id `release_id`. if `release_id` is `latest`,
        /// return the latest release that was distributed to the current
        /// user (from all the distribution groups).
        /// </summary>
        /// <param name='releaseId'>
        /// The ID of the release, or `latest` to get the latest release from
        /// all the distribution groups assigned to the current user.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetReleaseOrLatestReleaseWithHttpMessagesAsync(string releaseId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a release.
        /// </summary>
        /// <param name='releaseId'>
        /// The ID of the release
        /// </param>
        /// <param name='body'>
        /// The release information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PatchAppsByOwnerNameByAppNameReleasesByReleaseIdWithHttpMessagesAsync(double releaseId, ReleaseUpdateRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a release.
        /// </summary>
        /// <param name='releaseId'>
        /// The ID of the release
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ErrorDetails>> DeleteAppsByOwnerNameByAppNameReleasesByReleaseIdWithHttpMessagesAsync(string releaseId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return detailed information about releases.
        /// </summary>
        /// <param name='publishedOnly'>
        /// when true, filters out releases that were uplaoded but were never
        /// distributed. Releases that under deleted distribution groups will
        /// not be filtered out.
        /// </param>
        /// <param name='filter'>
        /// OBSOLETE. Will be removed in next version. An OData style filter.
        /// Currently only support the 'eq' comparision type. E.g.
        /// ?$filter=status eq 'Available'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ReleaseDetails>>> GetAppsByOwnerNameByAppNameReleasesWithHttpMessagesAsync(bool? publishedOnly = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Commits or aborts the upload process for a release for the
        /// specified application
        /// </summary>
        /// <param name='uploadId'>
        /// The ID of the upload
        /// </param>
        /// <param name='body'>
        /// The release information
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ReleaseUploadEndResponse>> PatchAppsByOwnerNameByAppNameReleaseUploadsByUploadIdWithHttpMessagesAsync(string uploadId, ReleaseUploadEndRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begins the upload process for a new release for the specified
        /// application.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ReleaseUploadBeginResponse>> PostAppsByOwnerNameByAppNameReleaseUploadsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the latest release from every distribution group associated
        /// with an application.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<BasicReleaseDetails>>> GetLatestReleasesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the latest package from every distribution group associated
        /// with an application.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<BasicPackageDetails>>> GetLatestPackagesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a package with id 'package_id'. if 'package_id' is 'latest',
        /// return the latest package that was distributed to the current
        /// user (from all the distribution groups).
        /// </summary>
        /// <param name='packageId'>
        /// The ID of the package, or 'latest' to get the latest package from
        /// all the distribution groups assigned to the current user.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetPackageOrLatestPackageWithHttpMessagesAsync(string packageId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name='packageId'>
        /// The ID of the package
        /// </param>
        /// <param name='body'>
        /// The package information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PatchAppsByOwnerNameByAppNamePackagesByPackageIdWithHttpMessagesAsync(double packageId, PackageUpdateRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a package.
        /// </summary>
        /// <param name='packageId'>
        /// The ID of the package
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ErrorDetails>> DeleteAppsByOwnerNameByAppNamePackagesByPackageIdWithHttpMessagesAsync(string packageId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return detailed information about packages.
        /// </summary>
        /// <param name='publishedOnly'>
        /// when true, filters out packages that were uplaoded but were never
        /// distributed. Packages that under deleted distribution groups will
        /// not be filtered out.
        /// </param>
        /// <param name='filter'>
        /// OBSOLETE. Will be removed in next version. An OData style filter.
        /// Currently only support the 'eq' comparision type. E.g.
        /// ?$filter=status eq 'Available'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<PackageDetails>>> GetAppsByOwnerNameByAppNamePackagesWithHttpMessagesAsync(bool? publishedOnly = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Commits or aborts the upload process for a package for the
        /// specified application
        /// </summary>
        /// <param name='uploadId'>
        /// The ID of the upload
        /// </param>
        /// <param name='body'>
        /// The package information
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PackageUploadEndResponse>> PatchAppsByOwnerNameByAppNamePackageUploadsByUploadIdWithHttpMessagesAsync(string uploadId, PackageUploadEndRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begins the upload process for a new package for the specified
        /// application
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PackageUploadBeginResponse>> PostAppsByOwnerNameByAppNamePackageUploadsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return detailed information about a distributed release in a given
        /// distribution group.
        /// </summary>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group.
        /// </param>
        /// <param name='releaseId'>
        /// Must be `latest`, a specific `release_id` is not supported at this
        /// time.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetLatestReleaseForDistributionGroupWithHttpMessagesAsync(string distributionGroupName, string releaseId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a release with id 'release_id' in a given distribution
        /// group.
        /// </summary>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group.
        /// </param>
        /// <param name='releaseId'>
        /// The ID identifying the unique release.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteReleaseForDistributionGroupWithHttpMessagesAsync(string distributionGroupName, string releaseId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return detailed information about distributed releases in a given
        /// distribution group.
        /// </summary>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetReleasesForDistributionGroupWithHttpMessagesAsync(string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return detailed information about a distributed package in a given
        /// distribution group.
        /// </summary>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group.
        /// </param>
        /// <param name='packageId'>
        /// For GET calls, this must be 'latest', specific package_id's are
        /// not supported at this time.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetLatestPackageForDistributionGroupWithHttpMessagesAsync(string distributionGroupName, string packageId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return detailed information about distributed packages in a given
        /// distribution group.
        /// </summary>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetPackagesForDistributionGroupWithHttpMessagesAsync(string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
