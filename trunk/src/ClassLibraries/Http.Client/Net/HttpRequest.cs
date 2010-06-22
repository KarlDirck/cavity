﻿namespace Cavity.Net
{
    using System;
    using System.IO;
    using Cavity.Net.Mime;

    public sealed class HttpRequest : ComparableObject, IHttpRequest
    {
        private RequestLine _requestLine;

        public HttpRequest(RequestLine requestLine)
            : this()
        {
            this.RequestLine = requestLine;
        }

        private HttpRequest()
        {
        }

        public Uri AbsoluteUri
        {
            get
            {
                return new Uri(this.RequestLine.RequestUri, UriKind.RelativeOrAbsolute);
            }
        }

        public IContent Body
        {
            get;
            private set;
        }

        public IHttpHeaderCollection Headers
        {
            get;
            private set;
        }

        public RequestLine RequestLine
        {
            get
            {
                return this._requestLine;
            }

            private set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("value");
                }

                this._requestLine = value;
            }
        }

        public static implicit operator HttpRequest(string value)
        {
            return object.ReferenceEquals(null, value) ? null as HttpRequest : HttpRequest.Parse(value);
        }

        public static HttpRequest Parse(string value)
        {
            if (null == value)
            {
                throw new ArgumentNullException("value");
            }

            return new HttpRequest(RequestLine.Parse(value));
        }

        public void Write(StreamWriter writer)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            throw new NotSupportedException();
        }

        public override string ToString()
        {
            return this.RequestLine;
        }
    }
}