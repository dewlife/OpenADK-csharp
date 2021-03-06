//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s). 
// All rights reserved.
//

using System;

namespace OpenADK.Library.Impl
{
    /// <summary>
    /// Summary description for HttpsTransportPlugin.
    /// </summary>
    internal class HttpsTransportPlugin : TransportPlugin
    {
        public override String Protocol
        {
            get { return "https"; }
        }

        public override bool Internal
        {
            get { return false; }
        }

        public override ITransport NewInstance( TransportProperties props )
        {
            return new HttpTransport( (HttpsProperties) props );
        }

        /// <summary>CreateProperties method sets new HttpProperties
        /// object which is not based solely on http or https Transport.
        /// Call CreateProperties when you are using custom 
        ///Transport protocol.
        /// If this method is not called, the TransportProperties are initialized 
        /// with default values, only accepting http and https
        /// <code> TransportPlugin tp = Adk.GetTransportProtocol(supported[i]);
        ///TransportProperties props = tp.CreateProperties();
        ///</code>
        /// </summary>
       public override TransportProperties CreateProperties()
       {
          return new HttpsProperties();
       }
    }
}
