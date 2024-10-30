// <copyright file="WPGlobalCNPPaymentAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Utilities.Logger.Configuration;
using WPGlobalCNPPaymentAPI.Standard.Controllers;
using WPGlobalCNPPaymentAPI.Standard.Http.Client;
using WPGlobalCNPPaymentAPI.Standard.Logging;
using WPGlobalCNPPaymentAPI.Standard.Utilities;

namespace WPGlobalCNPPaymentAPI.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class WPGlobalCNPPaymentAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://5gedge.verizon.com/api/mec/eds" },
                    { Server.Thingspace, "https://thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://thingspace.verizon.com/api/ts/v1" },
                    { Server.M2m, "https://thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://5gedge.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://5gedge.verizon.com/api/mec/services" },
                    { Server.QualityOfService, "https://thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
            {
                Environment.Staging, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://staging.5gedge.verizon.com/api/mec/eds" },
                    { Server.Thingspace, "https://staging.thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://staging.thingspace.verizon.com/api/ts/v1" },
                    { Server.M2m, "https://staging.thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://staging.thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://staging.thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://staging.thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://staging.thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://staging.thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://staging.5gedge.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://staging.thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://staging.thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://staging.thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://staging.5gedge.verizon.com/api/mec/services" },
                    { Server.QualityOfService, "https://staging.thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
            {
                Environment.Dev, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://devmanagement-staging.5gedge.verizon.com:80/mec/eds" },
                    { Server.Thingspace, "https://devmanagement-staging.thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://devmanagement-staging.thingspace.verizon.com:80/ts/v1" },
                    { Server.M2m, "https://devmanagement-staging.thingspace.verizon.com:80/m2m" },
                    { Server.DeviceLocation, "https://devmanagement-staging.thingspace.verizon.com:80/loc/v1" },
                    { Server.SubscriptionServer, "https://devmanagement-staging.thingspace.verizon.com:80/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://devmanagement-staging.thingspace.verizon.com:80/fota/v1" },
                    { Server.SoftwareManagementV2, "https://devmanagement-staging.thingspace.verizon.com:80/fota/v2" },
                    { Server.SoftwareManagementV3, "https://devmanagement-staging.thingspace.verizon.com:80/fota/v3" },
                    { Server.Performance, "https://devmanagement-staging.5gedge.verizon.com:80/mec" },
                    { Server.DeviceDiagnostics, "https://devmanagement-staging.thingspace.verizon.com:80/diagnostics/v1" },
                    { Server.CloudConnector, "https://devmanagement-staging.thingspace.verizon.com:80/cc/v1" },
                    { Server.HyperPreciseLocation, "https://devmanagement-staging.thingspace.verizon.com:80/hyper-precise/v1" },
                    { Server.Services, "https://devmanagement-staging.5gedge.verizon.com:80/mec/services" },
                    { Server.QualityOfService, "https://devmanagement-staging.thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
            {
                Environment.Qa, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://tsd-nginx-qa-us-east-1.5gedge.verizon.com/api/mec/eds" },
                    { Server.Thingspace, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/ts/v1" },
                    { Server.M2m, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://tsd-nginx-qa-us-east-1.5gedge.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://tsd-nginx-qa-us-east-1.5gedge.verizon.com/api/mec/services" },
                    { Server.QualityOfService, "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
            {
                Environment.MockServerOnlyAvailableForThingspaceM2mAPIs, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://mock-staging.thingspace.verizon.com/api/mec/eds" },
                    { Server.Thingspace, "https://mock-staging.thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://mock-staging.thingspace.verizon.com/api/ts/v1" },
                    { Server.M2m, "https://mock-staging.thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://mock-staging.thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://mock-staging.thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://mock-staging.thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://mock-staging.thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://mock-staging.thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://mock-staging.thingspace.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://mock-staging.thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://mock-staging.thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://mock-staging.thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://mock-staging.thingspace.verizon.com/api/mec/services" },
                    { Server.QualityOfService, "https://mock-staging.thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private SdkLoggingConfiguration sdkLoggingConfiguration;
        private const string userAgent = "Use placeholders: DotNet 4.5.4 {os-info}";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<MPaymentsController> mPayments;
        private readonly Lazy<MTokensController> mTokens;

        private WPGlobalCNPPaymentAPIClient(
            Environment environment,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration,
            SdkLoggingConfiguration sdkLoggingConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            this.sdkLoggingConfiguration = sdkLoggingConfiguration;

            globalConfiguration = new GlobalConfiguration.Builder()
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Thingspace)
                .LoggingConfig(sdkLoggingConfiguration)
                .UserAgent(userAgent)
                .Build();


            this.mPayments = new Lazy<MPaymentsController>(
                () => new MPaymentsController(globalConfiguration));
            this.mTokens = new Lazy<MTokensController>(
                () => new MTokensController(globalConfiguration));
        }

        /// <summary>
        /// Gets MPaymentsController controller.
        /// </summary>
        public MPaymentsController MPaymentsController => this.mPayments.Value;

        /// <summary>
        /// Gets MTokensController controller.
        /// </summary>
        public MTokensController MTokensController => this.mTokens.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:THINGSPACE.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Thingspace)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the WPGlobalCNPPaymentAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .LoggingConfig(sdkLoggingConfiguration)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> WPGlobalCNPPaymentAPIClient.</returns>
        internal static WPGlobalCNPPaymentAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("WP_GLOBAL_CNP_PAYMENT_API_STANDARD_ENVIRONMENT");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = WPGlobalCNPPaymentAPI.Standard.Environment.Production;
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;
            private SdkLoggingConfiguration sdkLoggingConfiguration;

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

            /// <summary>
            /// Sets the default logging configuration, using the Console logger.
            /// </summary>
            /// <returns>Builder.</returns>
            public Builder LoggingConfig()
            {
                this.sdkLoggingConfiguration = SdkLoggingConfiguration.Console();
                return this;
            }

            /// <summary>
            /// Sets the logging configuration using the provided <paramref name="action"/>.
            /// </summary>
            /// <param name="action">The action to perform on the logging configuration builder.</param>
            /// <returns>Builder.</returns>
            /// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is null.</exception>
            public Builder LoggingConfig(Action<LogBuilder> action)
            {
                if (action is null) throw new ArgumentNullException(nameof(action));
                var logBuilder =
                    LogBuilder.CreateFromConfig(sdkLoggingConfiguration ?? SdkLoggingConfiguration.Console());
                action(logBuilder);
                this.sdkLoggingConfiguration = logBuilder.Build();
                return this;
            }

            internal Builder LoggingConfig(SdkLoggingConfiguration configuration)
            {
                sdkLoggingConfiguration = configuration;
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the WPGlobalCNPPaymentAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>WPGlobalCNPPaymentAPIClient.</returns>
            public WPGlobalCNPPaymentAPIClient Build()
            {
                return new WPGlobalCNPPaymentAPIClient(
                    environment,
                    httpCallback,
                    httpClientConfig.Build(),
                    sdkLoggingConfiguration);
            }
        }
    }
}
