﻿namespace Cavity
{
    using System;
    using Cavity.Configuration;
    using Cavity.Net;
    using Microsoft.Practices.ServiceLocation;
    using Xunit;

    public sealed class ExampleFacts
    {
        [Fact(Skip = "Await xsamples.com implementation.")]
        public void get()
        {
            try
            {
                ServiceLocation.Settings().Configure();

                HttpRequest request =
                    "GET / HTTP/1.1" + Environment.NewLine +
                    "Host: www.example.com" + Environment.NewLine +
                    "Connection: close" + Environment.NewLine +
                    string.Empty;

                var client = new HttpClient();
                client.Navigate(request);

                Assert.Equal<string>("HTTP/1.1 200 OK", client.Response.StatusLine);

                Assert.True(client.Response.Headers.ContainsName("Date"));
                Assert.True(client.Response.Headers.ContainsName("Server"));
                Assert.True(client.Response.Headers.ContainsName("Last-Modified"));
                Assert.True(client.Response.Headers.ContainsName("ETag"));
                Assert.True(client.Response.Headers.ContainsName("Accept-Ranges"));
                Assert.Equal("596", client.Response.Headers["Content-Length"]);
                Assert.Equal("close", client.Response.Headers["Connection"]);
                Assert.Equal("text/html; charset=UTF-8", client.Response.Headers["Content-Type"]);

                Assert.NotNull(client.Response.Body.Content);
            }
            finally
            {
                ServiceLocator.SetLocatorProvider(null);
            }
        }

        [Fact(Skip = "Await xsamples.com implementation.")]
        public void head()
        {
            try
            {
                ServiceLocation.Settings().Configure();

                HttpRequest request =
                    "HEAD / HTTP/1.1" + Environment.NewLine +
                    "Host: www.example.com" + Environment.NewLine +
                    "Connection: close" + Environment.NewLine +
                    string.Empty;

                var client = new HttpClient();
                client.Navigate(request);

                Assert.Equal<string>("HTTP/1.1 200 OK", client.Response.StatusLine);

                Assert.True(client.Response.Headers.ContainsName("Date"));
                Assert.True(client.Response.Headers.ContainsName("Server"));
                Assert.True(client.Response.Headers.ContainsName("Last-Modified"));
                Assert.True(client.Response.Headers.ContainsName("ETag"));
                Assert.True(client.Response.Headers.ContainsName("Accept-Ranges"));
                Assert.Equal("596", client.Response.Headers["Content-Length"]);
                Assert.Equal("close", client.Response.Headers["Connection"]);
                Assert.Equal("text/html; charset=UTF-8", client.Response.Headers["Content-Type"]);

                Assert.Equal(string.Empty, (string)client.Response.Body.Content);
            }
            finally
            {
                ServiceLocator.SetLocatorProvider(null);
            }
        }

        [Fact(Skip = "Await xsamples.com implementation.")]
        public void options()
        {
            try
            {
                ServiceLocation.Settings().Configure();

                HttpRequest request =
                    "OPTIONS / HTTP/1.1" + Environment.NewLine +
                    "Host: www.example.com" + Environment.NewLine +
                    "Connection: close" + Environment.NewLine +
                    string.Empty;

                var client = new HttpClient();
                client.Navigate(request);

                Assert.Equal<string>("HTTP/1.1 200 OK", client.Response.StatusLine);

                Assert.True(client.Response.Headers.ContainsName("Date"));
                Assert.True(client.Response.Headers.ContainsName("Server"));
                Assert.Equal("GET,HEAD,POST,OPTIONS,TRACE", client.Response.Headers["Allow"]);
                Assert.Equal("0", client.Response.Headers["Content-Length"]);
                Assert.Equal("close", client.Response.Headers["Connection"]);
                Assert.Equal("text/html; charset=UTF-8", client.Response.Headers["Content-Type"]);

                Assert.Equal(string.Empty, (string)client.Response.Body.Content);
            }
            finally
            {
                ServiceLocator.SetLocatorProvider(null);
            }
        }

        [Fact(Skip = "Need to check what example.com is doing now.")]
        public void options_any()
        {
            try
            {
                ServiceLocation.Settings().Configure();

                HttpRequest request =
                    "OPTIONS * HTTP/1.1" + Environment.NewLine +
                    "Host: www.example.com" + Environment.NewLine +
                    "Connection: keep-alive" + Environment.NewLine +
                    string.Empty;

                var client = new HttpClient();
                client.Navigate(request);

                Assert.Equal<string>("HTTP/1.1 200 OK", client.Response.StatusLine);
                Assert.True(client.Response.Headers.ContainsName("Allow"));
            }
            finally
            {
                ServiceLocator.SetLocatorProvider(null);
            }
        }

        [Fact(Skip = "Await xsamples.com implementation.")]
        public void trace()
        {
            try
            {
                ServiceLocation.Settings().Configure();

                HttpRequest request =
                    "TRACE / HTTP/1.1" + Environment.NewLine +
                    "Host: www.example.com" + Environment.NewLine +
                    "Connection: close" + Environment.NewLine +
                    string.Empty;

                var client = new HttpClient();
                client.Navigate(request);

                Assert.Equal<string>("HTTP/1.1 200 OK", client.Response.StatusLine);

                Assert.True(client.Response.Headers.ContainsName("Date"));
                Assert.Equal("message/http", client.Response.Headers.ContentType.MediaType);
                Assert.Equal("close", client.Response.Headers["Connection"]);

                Assert.True(((string)client.Response.Body.Content).Contains("TRACE / HTTP/1.1"));
            }
            finally
            {
                ServiceLocator.SetLocatorProvider(null);
            }
        }
    }
}