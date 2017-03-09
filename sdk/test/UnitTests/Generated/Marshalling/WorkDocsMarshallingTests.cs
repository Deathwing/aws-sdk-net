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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.WorkDocs;
using Amazon.WorkDocs.Model;
using Amazon.WorkDocs.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class WorkDocsMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("workdocs");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void AbortDocumentVersionUploadMarshallTest()
        {
            var operation = service_model.FindOperation("AbortDocumentVersionUpload");

            var request = InstantiateClassGenerator.Execute<AbortDocumentVersionUploadRequest>();
            var marshaller = new AbortDocumentVersionUploadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AbortDocumentVersionUpload", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void ActivateUserMarshallTest()
        {
            var operation = service_model.FindOperation("ActivateUser");

            var request = InstantiateClassGenerator.Execute<ActivateUserRequest>();
            var marshaller = new ActivateUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ActivateUser", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ActivateUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ActivateUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void AddResourcePermissionsMarshallTest()
        {
            var operation = service_model.FindOperation("AddResourcePermissions");

            var request = InstantiateClassGenerator.Execute<AddResourcePermissionsRequest>();
            var marshaller = new AddResourcePermissionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AddResourcePermissions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = AddResourcePermissionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AddResourcePermissionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void CreateFolderMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFolder");

            var request = InstantiateClassGenerator.Execute<CreateFolderRequest>();
            var marshaller = new CreateFolderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateFolder", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateFolderResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateFolderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void CreateNotificationSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNotificationSubscription");

            var request = InstantiateClassGenerator.Execute<CreateNotificationSubscriptionRequest>();
            var marshaller = new CreateNotificationSubscriptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateNotificationSubscription", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateNotificationSubscriptionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateNotificationSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void CreateUserMarshallTest()
        {
            var operation = service_model.FindOperation("CreateUser");

            var request = InstantiateClassGenerator.Execute<CreateUserRequest>();
            var marshaller = new CreateUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateUser", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DeactivateUserMarshallTest()
        {
            var operation = service_model.FindOperation("DeactivateUser");

            var request = InstantiateClassGenerator.Execute<DeactivateUserRequest>();
            var marshaller = new DeactivateUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeactivateUser", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DeleteDocumentMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDocument");

            var request = InstantiateClassGenerator.Execute<DeleteDocumentRequest>();
            var marshaller = new DeleteDocumentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteDocument", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DeleteFolderMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFolder");

            var request = InstantiateClassGenerator.Execute<DeleteFolderRequest>();
            var marshaller = new DeleteFolderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteFolder", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DeleteFolderContentsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFolderContents");

            var request = InstantiateClassGenerator.Execute<DeleteFolderContentsRequest>();
            var marshaller = new DeleteFolderContentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteFolderContents", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DeleteNotificationSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNotificationSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteNotificationSubscriptionRequest>();
            var marshaller = new DeleteNotificationSubscriptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteNotificationSubscription", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DeleteUserMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteUser");

            var request = InstantiateClassGenerator.Execute<DeleteUserRequest>();
            var marshaller = new DeleteUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteUser", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DescribeDocumentVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDocumentVersions");

            var request = InstantiateClassGenerator.Execute<DescribeDocumentVersionsRequest>();
            var marshaller = new DescribeDocumentVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeDocumentVersions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeDocumentVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeDocumentVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DescribeFolderContentsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFolderContents");

            var request = InstantiateClassGenerator.Execute<DescribeFolderContentsRequest>();
            var marshaller = new DescribeFolderContentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeFolderContents", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeFolderContentsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeFolderContentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DescribeNotificationSubscriptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNotificationSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeNotificationSubscriptionsRequest>();
            var marshaller = new DescribeNotificationSubscriptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeNotificationSubscriptions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeNotificationSubscriptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeNotificationSubscriptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DescribeResourcePermissionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResourcePermissions");

            var request = InstantiateClassGenerator.Execute<DescribeResourcePermissionsRequest>();
            var marshaller = new DescribeResourcePermissionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeResourcePermissions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeResourcePermissionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeResourcePermissionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void DescribeUsersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeUsers");

            var request = InstantiateClassGenerator.Execute<DescribeUsersRequest>();
            var marshaller = new DescribeUsersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeUsers", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeUsersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeUsersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void GetDocumentMarshallTest()
        {
            var operation = service_model.FindOperation("GetDocument");

            var request = InstantiateClassGenerator.Execute<GetDocumentRequest>();
            var marshaller = new GetDocumentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDocument", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetDocumentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDocumentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void GetDocumentPathMarshallTest()
        {
            var operation = service_model.FindOperation("GetDocumentPath");

            var request = InstantiateClassGenerator.Execute<GetDocumentPathRequest>();
            var marshaller = new GetDocumentPathRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDocumentPath", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetDocumentPathResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDocumentPathResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void GetDocumentVersionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDocumentVersion");

            var request = InstantiateClassGenerator.Execute<GetDocumentVersionRequest>();
            var marshaller = new GetDocumentVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDocumentVersion", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetDocumentVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDocumentVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void GetFolderMarshallTest()
        {
            var operation = service_model.FindOperation("GetFolder");

            var request = InstantiateClassGenerator.Execute<GetFolderRequest>();
            var marshaller = new GetFolderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetFolder", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFolderResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFolderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void GetFolderPathMarshallTest()
        {
            var operation = service_model.FindOperation("GetFolderPath");

            var request = InstantiateClassGenerator.Execute<GetFolderPathRequest>();
            var marshaller = new GetFolderPathRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetFolderPath", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFolderPathResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFolderPathResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void InitiateDocumentVersionUploadMarshallTest()
        {
            var operation = service_model.FindOperation("InitiateDocumentVersionUpload");

            var request = InstantiateClassGenerator.Execute<InitiateDocumentVersionUploadRequest>();
            var marshaller = new InitiateDocumentVersionUploadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("InitiateDocumentVersionUpload", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InitiateDocumentVersionUploadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InitiateDocumentVersionUploadResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void RemoveAllResourcePermissionsMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveAllResourcePermissions");

            var request = InstantiateClassGenerator.Execute<RemoveAllResourcePermissionsRequest>();
            var marshaller = new RemoveAllResourcePermissionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("RemoveAllResourcePermissions", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void RemoveResourcePermissionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveResourcePermission");

            var request = InstantiateClassGenerator.Execute<RemoveResourcePermissionRequest>();
            var marshaller = new RemoveResourcePermissionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("RemoveResourcePermission", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void UpdateDocumentMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDocument");

            var request = InstantiateClassGenerator.Execute<UpdateDocumentRequest>();
            var marshaller = new UpdateDocumentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateDocument", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void UpdateDocumentVersionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDocumentVersion");

            var request = InstantiateClassGenerator.Execute<UpdateDocumentVersionRequest>();
            var marshaller = new UpdateDocumentVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateDocumentVersion", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void UpdateFolderMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFolder");

            var request = InstantiateClassGenerator.Execute<UpdateFolderRequest>();
            var marshaller = new UpdateFolderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateFolder", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkDocs")]
        public void UpdateUserMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateUser");

            var request = InstantiateClassGenerator.Execute<UpdateUserRequest>();
            var marshaller = new UpdateUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateUser", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}