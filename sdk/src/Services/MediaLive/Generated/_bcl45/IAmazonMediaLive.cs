/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaLive.Model;

namespace Amazon.MediaLive
{
    /// <summary>
    /// Interface for accessing MediaLive
    ///
    /// API for AWS Elemental MediaLive
    /// </summary>
    public partial interface IAmazonMediaLive : IAmazonService, IDisposable
    {

        
        #region  CreateChannel


        /// <summary>
        /// Creates a new channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInput


        /// <summary>
        /// Create an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        CreateInputResponse CreateInput(CreateInputRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        Task<CreateInputResponse> CreateInputAsync(CreateInputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInputSecurityGroup


        /// <summary>
        /// Creates a Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        CreateInputSecurityGroupResponse CreateInputSecurityGroup(CreateInputSecurityGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        Task<CreateInputSecurityGroupResponse> CreateInputSecurityGroupAsync(CreateInputSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Starts deletion of channel. The associated outputs are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInput


        /// <summary>
        /// Deletes the input end point
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        DeleteInputResponse DeleteInput(DeleteInputRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        Task<DeleteInputResponse> DeleteInputAsync(DeleteInputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInputSecurityGroup


        /// <summary>
        /// Deletes an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        DeleteInputSecurityGroupResponse DeleteInputSecurityGroup(DeleteInputSecurityGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        Task<DeleteInputSecurityGroupResponse> DeleteInputSecurityGroupAsync(DeleteInputSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Gets details about a channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse DescribeChannel(DescribeChannelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInput


        /// <summary>
        /// Produces details about an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        DescribeInputResponse DescribeInput(DescribeInputRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        Task<DescribeInputResponse> DescribeInputAsync(DescribeInputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInputSecurityGroup


        /// <summary>
        /// Produces a summary of an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        DescribeInputSecurityGroupResponse DescribeInputSecurityGroup(DescribeInputSecurityGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        Task<DescribeInputSecurityGroupResponse> DescribeInputSecurityGroupAsync(DescribeInputSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Produces list of channels that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInputs


        /// <summary>
        /// Produces list of inputs that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        ListInputsResponse ListInputs(ListInputsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListInputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        Task<ListInputsResponse> ListInputsAsync(ListInputsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInputSecurityGroups


        /// <summary>
        /// Produces a list of Input Security Groups for an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ListInputSecurityGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        ListInputSecurityGroupsResponse ListInputSecurityGroups(ListInputSecurityGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListInputSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        Task<ListInputSecurityGroupsResponse> ListInputSecurityGroupsAsync(ListInputSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartChannel


        /// <summary>
        /// Starts an existing channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        StartChannelResponse StartChannel(StartChannelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        Task<StartChannelResponse> StartChannelAsync(StartChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopChannel


        /// <summary>
        /// Stops a running channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        StopChannelResponse StopChannel(StopChannelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        Task<StopChannelResponse> StopChannelAsync(StopChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}