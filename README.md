# C# API Request

## Install
``` powershell
PM> Install-Package Microsoft.AspNet.WebApi.Client -Version 5.2.7
PM> Install-Package Microsoft.Extensions.DependencyInjection.Abstractions -Version 3.1.8
PM> Install-Package Microsoft.Extensions.Http -Version 3.1.8
```

## APIs
| API | HTTPS port | HTTP port |
|:---:|:---:|:---:|
| Foo API | 42000 | 42001 |
| Bar API | 43000 | 43001 |

## Test endpoints
| Route | HttpVerb | Requires Body | Has Response | Status Code |
|:---|:---:|:---:|:---:|:---|
| api/v1/bar/get-with-response | GET | | ✓ | 200 (OK) |
| api/v1/bar/get-without-response | GET | | | 204 (No Content) |
| api/v1/bar/post-with-body-and-with-response | POST | ✓ | ✓ |  200 (OK) |
| api/v1/bar/post-with-body-and-without-response | POST | ✓ | | 204 (No Content) |
| api/v1/bar/post-without-body-and-with-response | POST | | ✓ | 200 (OK) |
| api/v1/bar/post-without-body-and-without-response | POST | | | 204 (No Content) |
| api/v1/bar/put-with-body-and-with-response | PUT | ✓ | ✓ |  200 (OK) |
| api/v1/bar/put-with-body-and-without-response | PUT | ✓ | | 204 (No Content) |
| api/v1/bar/put-without-body-and-with-response | PUT | | ✓ | 200 (OK) |
| api/v1/bar/put-without-body-and-without-response | PUT | | | 204 (No Content) |
| api/v1/bar/patch-with-body-and-with-response | PATCH | ✓ | ✓ |  200 (OK) |
| api/v1/bar/patch-with-body-and-without-response | PATCH | ✓ | | 204 (No Content) |
| api/v1/bar/patch-without-body-and-with-response | PATCH | | ✓ | 200 (OK) |
| api/v1/bar/patch-without-body-and-without-response | PATCH | | | 204 (No Content) |
| api/v1/bar/delete-with-response | DELETE | | ✓ | 200 (OK) |
| api/v1/bar/delete-without-response | DELETE | | | 204 (No Content) |
| api/v1/foo/get-with-response | GET | | ✓ | 200 (OK) |
| api/v1/foo/get-without-response | GET | | | 204 (No Content) |
| api/v1/foo/post-with-body-and-with-response | POST | ✓ | ✓ |  200 (OK) |
| api/v1/foo/post-with-body-and-without-response | POST | ✓ | | 204 (No Content) |
| api/v1/foo/post-without-body-and-with-response | POST | | ✓ | 200 (OK) |
| api/v1/foo/post-without-body-and-without-response | POST | | | 204 (No Content) |
| api/v1/foo/put-with-body-and-with-response | PUT | ✓ | ✓ |  200 (OK) |
| api/v1/foo/put-with-body-and-without-response | PUT | ✓ | | 204 (No Content) |
| api/v1/foo/put-without-body-and-with-response | PUT | | ✓ | 200 (OK) |
| api/v1/foo/put-without-body-and-without-response | PUT | | | 204 (No Content) |
| api/v1/foo/patch-with-body-and-with-response | PATCH | ✓ | ✓ |  200 (OK) |
| api/v1/foo/patch-with-body-and-without-response | PATCH | ✓ | | 204 (No Content) |
| api/v1/foo/patch-without-body-and-with-response | PATCH | | ✓ | 200 (OK) |
| api/v1/foo/patch-without-body-and-without-response | PATCH | | | 204 (No Content) |
| api/v1/foo/delete-with-response | DELETE | | ✓ | 200 (OK) |
| api/v1/foo/delete-without-response | DELETE | | | 204 (No Content) |
