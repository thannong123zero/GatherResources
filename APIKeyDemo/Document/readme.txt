Authentication methods in asp.net core

In addition to api key authentication, we can use other authentication methods like Basic authentication, Token-based authentication and OAuth authentication.

Basic authentication relies on a username and password combination sent in the request headers.
While easy to implement, it lacks advanced security features such as token expiration or refresh.
This makes it less suitable for  public-facing APIs, as there is risk of exposing credentials in requests.

Token-based authentication issues a token, often a JSON Web Token, upon successful login.
Thse tokens contain user-specific information and an expiration time.
Unlike API key and Basic autentication, token-based authentication offers hiegher securituy.
Tokens can expire, reducing the window of vulnerability of comprosied,and we can crytographically sign for added sucurity.

Oauth is an authorization framework to delegate access rights to third-party applications.
We commonly use it when an application needs to access resources on behalf of a a user without sharing the user's credentials.
Oath enables us to manage authorization and access control securely and in a standardized manner, making it an ideal choice for scenarios that demand franular access control.

---------------------*-------------------

Different ways of passing api key in a request
there are several wapys can include the api key in a request:
+ Query parameters
+ Request body
+ Request headers

Different Ways to Implement API Key Authentication:
+ Custom attribute
+ Custom middleware
+ Endpoint filters
+ Policy-based authorization

Reference: https://code-maze.com/aspnetcore-api-key-authentication/
Extend: https://code-maze.com/aspnet-configuration-securing-sensitive-data/?_gl=1*8ahrvu*_ga*MjVvTVg4M3BOa0pOenNOUk1fSjVWREh5d0pHRmhFOU5PZnYwZFdyQTdtdGU3dDJPRXBKczl5elZTUEpjRjJaVA..
